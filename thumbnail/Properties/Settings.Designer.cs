﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18052
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace thumbnail.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Depth32Bit")]
        public global::System.Windows.Forms.ColorDepth ThumbNailColorDepth {
            get {
                return ((global::System.Windows.Forms.ColorDepth)(this["ThumbNailColorDepth"]));
            }
            set {
                this["ThumbNailColorDepth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("108, 108")]
        public global::System.Drawing.Size ThumbNailSize {
            get {
                return ((global::System.Drawing.Size)(this["ThumbNailSize"]));
            }
            set {
                this["ThumbNailSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SwapGallery")]
        public string PathRepoImgs {
            get {
                return ((string)(this["PathRepoImgs"]));
            }
            set {
                this["PathRepoImgs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ScannFile_")]
        public string ScannFileName {
            get {
                return ((string)(this["ScannFileName"]));
            }
            set {
                this["ScannFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Quantum Productora de Software (273064285)")]
        public string KDImageLicenseName {
            get {
                return ((string)(this["KDImageLicenseName"]));
            }
            set {
                this["KDImageLicenseName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6360-8836-5591-7141-5489")]
        public string KDImageLicenseKey {
            get {
                return ((string)(this["KDImageLicenseKey"]));
            }
            set {
                this["KDImageLicenseKey"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=xmalmorthen.dyndns.org;Initial Catalog=Bd_Exp_Transportes;Persist Sec" +
            "urity Info=True;User ID=sa;Password=malditamater")]
        public string Bd_Exp_TransportesConnectionString {
            get {
                return ((string)(this["Bd_Exp_TransportesConnectionString"]));
            }
        }
    }
}
