//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _02_RevitUtilities._01_Resources_Utilities_._03_Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class JoinGeometry : global::System.Configuration.ApplicationSettingsBase {
        
        private static JoinGeometry defaultInstance = ((JoinGeometry)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new JoinGeometry())));
        
        public static JoinGeometry Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool JoinOrder {
            get {
                return ((bool)(this["JoinOrder"]));
            }
            set {
                this["JoinOrder"] = value;
            }
        }
    }
}
