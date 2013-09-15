using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using scanndoc.data_members;

namespace scanndoc.models
{
    public static class Usuario
    {
        private static ca_usuarios _Logeado = new ca_usuarios();
        public static ca_usuarios Logeado { get { return _Logeado; } set { _Logeado = value; } }
    }


}
