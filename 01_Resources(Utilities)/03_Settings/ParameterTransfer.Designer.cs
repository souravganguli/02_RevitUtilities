﻿//------------------------------------------------------------------------------
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
    internal sealed partial class ParameterTransfer : global::System.Configuration.ApplicationSettingsBase {
        
        private static ParameterTransfer defaultInstance = ((ParameterTransfer)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ParameterTransfer())));
        
        public static ParameterTransfer Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ParameterToCopyFrom {
            get {
                return ((string)(this["ParameterToCopyFrom"]));
            }
            set {
                this["ParameterToCopyFrom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ParameterToCopyTo {
            get {
                return ((string)(this["ParameterToCopyTo"]));
            }
            set {
                this["ParameterToCopyTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Yes")]
        public string ParameterType {
            get {
                return ((string)(this["ParameterType"]));
            }
            set {
                this["ParameterType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("No")]
        public string Groups {
            get {
                return ((string)(this["Groups"]));
            }
            set {
                this["Groups"] = value;
            }
        }
    }
}
