//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL_BLL.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\ThucHanh\\PhatTrienPhanMem\\QuanLyQuanCafe\\Images\\DoUong\\")]
        public string ImagesPath {
            get {
                return ((string)(this["ImagesPath"]));
            }
            set {
                this["ImagesPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#ff5722")]
        public string ThemeColor {
            get {
                return ((string)(this["ThemeColor"]));
            }
            set {
                this["ThemeColor"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-JAA4L10;Initial Catalog=dbQuanLyQuanCafe;User ID=sa;Password=" +
            "sa2012")]
        public string dbQuanLyQuanCafeConnectionString {
            get {
                return ((string)(this["dbQuanLyQuanCafeConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-JAA4L10;Initial Catalog=dbQuanLyQuanCafe;User ID=sa;Password=" +
            "sa2015")]
        public string dbQLQCFConn {
            get {
                return ((string)(this["dbQLQCFConn"]));
            }
            set {
                this["dbQLQCFConn"] = value;
            }
        }
    }
}
