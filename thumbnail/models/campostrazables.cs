using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thumbnail.models
{
    public class campostrazables
    {
        private Boolean _EsPrincipal { get; set; }
        private string _Campo { get; set; }
        private string _Mascara { get; set; }
        private string _Dato { get; set; }

        public Boolean EsPrincipal { get{return _EsPrincipal;} set{_EsPrincipal = value;} }
        public string Campo { get{return _Campo; } set{_Campo = value;} }
        public string Mascara { get{return _Mascara;} set{_Mascara=value;} }
        public string Dato { get { return _Dato; } set { _Dato = value; } }
    }

}
