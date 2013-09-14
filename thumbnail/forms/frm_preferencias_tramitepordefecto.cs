using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using thumbnail.classes;
using System.Collections;
using thumbnail.models;
using thumbnail.Properties;

namespace thumbnail.forms
{
    public partial class frm_preferencias_tramitepordefecto : Form
    {
        public frm_preferencias_tramitepordefecto()
        {
            InitializeComponent();
        }

        List<data_members.vw_ListaTramitesActivos> tramites;
        private void match_registros()
        {
            try
            {
                tramites = Program.Bd_Exp_Transportes.GetTable<data_members.vw_ListaTramitesActivos>().ToList();
                BindingSource.DataSource = tramites;
            }
            catch (Exception)
            {
                throw;
            }
        }

        struct struct_format
        {
            private short _key;
            public short value { get { return _key; } set { _key = value; } }
        }
        private void lista_nodias()
        {
            List<struct_format> dias = new List<struct_format>();
            for (short i = 0; i <= 7; i++)
            {
                struct_format ord = new struct_format();
                ord.value = i;
                dias.Add(ord);
            }
            bindingSource_NoDias.DataSource = dias;
            nodiasbloqueoDataGridViewTextBoxColumn.DataSource = bindingSource_NoDias;
            nodiasbloqueoDataGridViewTextBoxColumn.DisplayMember = "value";
            nodiasbloqueoDataGridViewTextBoxColumn.ValueMember = "value";
        }

        private void lista_nohoras()
        {
            List<struct_format> horas = new List<struct_format>();
            for (short i = 0; i <= 24; i++)
            {
                struct_format ord = new struct_format();
                ord.value = i;
                horas.Add(ord);
            }
            bindingSource_NoHoras.DataSource = horas;
            nohorasbloqueoDataGridViewTextBoxColumn.DataSource = bindingSource_NoHoras;
            nohorasbloqueoDataGridViewTextBoxColumn.DisplayMember = "value";
            nohorasbloqueoDataGridViewTextBoxColumn.ValueMember = "value";
        }

        private void lista_tiposdebloqueos() {
            try
            {
                bindingSource_tipobloqueos.DataSource = Program.Bd_Exp_Transportes.GetTable<data_members.ca_tiposbloqueos>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ver_Click(null, null);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_buscar_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                List<thumbnail.data_members.vw_ListaTramitesActivos> valores = (from query in tramites
                                                                                 where query.Nombre_tramite.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                                 select query).ToList();
                BindingSource.DataSource = valores;
                dataGridView.Update();
            }
            catch (Exception)
            {
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;        
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            int id_tramite = (BindingSource.Current as data_members.vw_ListaTramitesActivos).id_tramite;
            frm_tramites_view frm = new frm_tramites_view(id_tramite);
            frm.ShowDialog(this);            
        }

        private void frm_preferencias_tramitepordefecto_Paint(object sender, PaintEventArgs e)
        {
            this.Paint -= frm_preferencias_tramitepordefecto_Paint;

            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            lista_tiposdebloqueos();
            lista_nohoras();
            lista_nodias();
            match_registros();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;

            dataGridView.RowValidated += new DataGridViewCellEventHandler(dataGridView_RowValidated);
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            editado = false;

            DataGridViewCell celltipobloqueo = dataGridView.Rows[e.RowIndex].Cells["descripcionbloqueoDataGridViewTextBoxColumn"];
            DataGridViewCell celldias = dataGridView.Rows[e.RowIndex].Cells["nodiasbloqueoDataGridViewTextBoxColumn"];
            DataGridViewCell cellhoras = dataGridView.Rows[e.RowIndex].Cells["nohorasbloqueoDataGridViewTextBoxColumn"];

            if (celltipobloqueo.Value == null ||
                Program.Bd_Exp_Transportes.ca_tiposbloqueos.Single(query => query.id == (int)celltipobloqueo.Value).Descripcion.ToString().ToLower() == "bloquear manualmente")
            {
                celldias.ReadOnly = true;
                cellhoras.ReadOnly = true;
                celldias.Value = null;
                cellhoras.Value = null;
                bindingSource_NoDias.MoveFirst();
                bindingSource_NoHoras.MoveFirst();
            }
            else {
                celldias.ReadOnly = false;
                cellhoras.ReadOnly = false;
            }
        }
        
        private void dataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewCell celltipobloqueo = dataGridView.Rows[e.RowIndex].Cells["descripcionbloqueoDataGridViewTextBoxColumn"];
            DataGridViewCell celldias = dataGridView.Rows[e.RowIndex].Cells["nodiasbloqueoDataGridViewTextBoxColumn"];
            DataGridViewCell cellhoras = dataGridView.Rows[e.RowIndex].Cells["nohorasbloqueoDataGridViewTextBoxColumn"];

            dataGridView.Rows[e.RowIndex].ErrorText = "";

            if (celltipobloqueo.Value != null &&
                Program.Bd_Exp_Transportes.ca_tiposbloqueos.Single(query => query.id == (int)celltipobloqueo.Value).Descripcion.ToString().ToLower() == "bloquear despues de determinado tiempo")
            {
                if (celldias.Value == null && cellhoras.Value == null)
                {
                    e.Cancel = true;
                    dataGridView.Rows[e.RowIndex].ErrorText = "Debe especificar al menos el día u hora de bloqueo.";
                }
            }
            else {
                celldias.Value = null;
                cellhoras.Value = null;
                bindingSource_NoDias.MoveFirst();
                bindingSource_NoHoras.MoveFirst();
            }
        }

        private void dataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!editado) return;
            actualizarplanbloqueo();
        }

        private void actualizarplanbloqueo()
        {
            try
            {
                Boolean guardar = false;
                Boolean nuevo = false;

                int id_re_expediente_tramite = (BindingSource.Current as data_members.vw_ListaTramitesActivos).id_re_expedientes_tramites;

                data_members.re_expedientestramites_tiposbloqueos tramite =
                    Program.Bd_Exp_Transportes.re_expedientestramites_tiposbloqueos.SingleOrDefault(query => query.id_re_expediente_tramite == id_re_expediente_tramite);

                if (tramite != null) {
                    if (tramite.id_re_expediente_tramite != id_re_expediente_tramite) {
                        tramite.id_re_expediente_tramite = id_re_expediente_tramite;
                        guardar = true;
                    }
                    if (tramite.id_tipobloqueo != (BindingSource.Current as data_members.vw_ListaTramitesActivos).id_tipobloqueo)
                    {
                        tramite.id_tipobloqueo = (BindingSource.Current as data_members.vw_ListaTramitesActivos).id_tipobloqueo;
                        guardar=true;
                    }
                    if (tramite.no_horas != (BindingSource.Current as data_members.vw_ListaTramitesActivos).no_horas_bloqueo)
                    {
                        tramite.no_horas = (BindingSource.Current as data_members.vw_ListaTramitesActivos).no_horas_bloqueo;
                        guardar = true;
                    }
                    if (tramite.no_dias != (BindingSource.Current as data_members.vw_ListaTramitesActivos).no_dias_bloqueo)
                    {
                        tramite.no_dias = (BindingSource.Current as data_members.vw_ListaTramitesActivos).no_dias_bloqueo;
                        guardar = true;
                    }
                } 
                else 
                {
                    guardar = true;
                    tramite = new data_members.re_expedientestramites_tiposbloqueos();
                    tramite.id_re_expediente_tramite = id_re_expediente_tramite;
                    tramite.id_tipobloqueo = (BindingSource.Current as data_members.vw_ListaTramitesActivos).id_tipobloqueo;
                    tramite.no_horas = (BindingSource.Current as data_members.vw_ListaTramitesActivos).no_horas_bloqueo;
                    tramite.no_dias = (BindingSource.Current as data_members.vw_ListaTramitesActivos).no_dias_bloqueo;
                    nuevo = true;
                }

                if (!guardar) return;

                this.Cursor = Cursors.WaitCursor;
                tlp_proc.Visible = true;

                Application.DoEvents();

                if (nuevo)
                {
                    Program.Bd_Exp_Transportes.re_expedientestramites_tiposbloqueos.InsertOnSubmit(tramite);
                }

                Program.Bd_Exp_Transportes.SubmitChanges();

                Application.DoEvents();

                tlp_proc.Visible = false;
                this.Cursor = Cursors.Default;                
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        Boolean editado;
        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editado = true;
        }
    }
}
