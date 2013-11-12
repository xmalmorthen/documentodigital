using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using scanndoc.Properties;

namespace scanndoc.forms
{
    public partial class frm_tramitedefecto : Form
    {
        public frm_tramitedefecto()
        {
            InitializeComponent();

            tramitepordefault = obtenertramitepordefault();
        }

        private void frm_tramitedefecto_Paint(object sender, PaintEventArgs e)
        {
            this.Paint -= frm_tramitedefecto_Paint;

            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            obtenerlistatramites();
            formatear_celda_principal();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;  
        }

        List<scanndoc.data_members.vw_ListaTramitesActivos> tramites;
        private void obtenerlistatramites() {
            try
            {
                tramites = Program.Bd_Expedientes_Digitales.GetTable<data_members.vw_ListaTramitesActivos>().ToList();
                BindingSource.DataSource = tramites;
                datagridview.Update();
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
        }

        private void txt_buscar_EditValueChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                List<scanndoc.data_members.vw_ListaTramitesActivos> valores = (from query in tramites
                                                                where query.Nombre_tramite.ToString().ToLower().Contains(txt_buscar.Text.ToString().ToLower())
                                                                select query).ToList();
                BindingSource.DataSource = valores;
                datagridview.Update();
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;  
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        short tramitepordefault;
        private short obtenertramitepordefault() {
            try
            {
                return Convert.ToInt16(Program.Bd_Expedientes_Digitales.tbl_configuraciones.SingleOrDefault(c => c.id == Settings.Default.Config_IdTramiteporDefault).Valor.ToString());
            }
            catch (Exception e)
            {
                scanndoc.classes.errorlogs.seterror(e);
            }
            return 0;
        }

        private void formatear_celda_principal()
        {
            DataGridViewCellStyle stylein = new DataGridViewCellStyle();
            stylein.BackColor = Settings.Default.CampoPrincipal_RowColorGrid;
            stylein.ForeColor = Color.Black;

            DataGridViewCellStyle styleout = new DataGridViewCellStyle();
            styleout.BackColor = Color.White;
            styleout.ForeColor = Color.Black;

            foreach (DataGridViewRow row in datagridview.Rows)
            {
                if ((int)row.Cells["idtramiteDataGridViewTextBoxColumn"].Value == tramitepordefault)
                {
                    row.Cells["seleccion"].Value = true;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style = stylein;
                    }
                }
                else {
                    row.Cells["seleccion"].Value = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style = styleout;
                    }
                }
            }
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return; 

            string newidtramte = datagridview.Rows[e.RowIndex].Cells["idtramiteDataGridViewTextBoxColumn"].Value.ToString();

            if (tramitepordefault == Convert.ToInt16(newidtramte)) return;

            this.Cursor = Cursors.WaitCursor;
            tlp_proc.Visible = true;

            Application.DoEvents();

            try
            {
                data_members.tbl_configuraciones configs = Program.Bd_Expedientes_Digitales.tbl_configuraciones.SingleOrDefault(c => c.id == Settings.Default.Config_IdTramiteporDefault);
                configs.Valor = newidtramte;
                Program.Bd_Expedientes_Digitales.SubmitChanges();
                datagridview.Rows[e.RowIndex].Cells["seleccion"].Value = true;
            }
            catch (Exception err)
            {
                scanndoc.classes.errorlogs.seterror(err);
            }

            tramitepordefault = obtenertramitepordefault();
            formatear_celda_principal();

            Application.DoEvents();

            tlp_proc.Visible = false;
            this.Cursor = Cursors.Default;
        }
    }
}
