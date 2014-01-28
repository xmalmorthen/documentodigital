using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace scanndoc.models
{
    public static class RefreshDataBase
    {
        public static void UpdateContent() {
            ChangeSet cs = Program.Bd_Expedientes_Digitales.GetChangeSet();
            Program.Bd_Expedientes_Digitales.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, cs.Updates);
        }
    }
}
