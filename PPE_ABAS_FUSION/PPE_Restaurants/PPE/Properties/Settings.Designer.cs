﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE_ABAS_RES.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=romainvaleye.ovh;user id=admin_abas_user;password=abas_pwd;persistsecurity" +
            "info=True;database=admin_abas_db")]
        public string AbasConnectionString {
            get {
                return ((string)(this["AbasConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=romainvaleye.ovh;user id=abas_user;password=3c51713e-534e-4a1d-bc8e-e51c29" +
            "d3014e;persistsecurityinfo=True;database=abas_db")]
        public string abas_dbDTSET {
            get {
                return ((string)(this["abas_dbDTSET"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=ms-development.fr;user id=admin_abasUser;database=admin_abas;persistsecuri" +
            "tyinfo=True")]
        public string admin_abasConnectionString {
            get {
                return ((string)(this["admin_abasConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=ms-development.fr;user id=admin_abasUser;database=admin_abas;persistsecuri" +
            "tyinfo=False")]
        public string admin_abasConnectionString1 {
            get {
                return ((string)(this["admin_abasConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=ms-development.fr;user id=admin_abasUser;database=admin_abas;password=vG9n" +
            "eMzz51;persistsecurityinfo=False")]
        public string admin_abasConnectionString2 {
            get {
                return ((string)(this["admin_abasConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=ms-development.fr;user id=admin_abasUser;persistsecurityinfo=True;database" +
            "=admin_abas")]
        public string admin_abasConnectionString3 {
            get {
                return ((string)(this["admin_abasConnectionString3"]));
            }
        }
    }
}
