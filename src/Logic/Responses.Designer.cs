﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spoofi.FreudBot.Logic {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Responses {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Responses() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Spoofi.FreudBot.Logic.Responses", typeof(Responses).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List of available commands (for you): /list
        ///
        ///Note: for using all of available commands, you must be in a list of allowed users.
        ///
        ///Your&apos;s chat identifier is {0}. Send it to @spoofi, if you want to use all my commands..
        /// </summary>
        internal static string MessageHandler_HandleCommand_help {
            get {
                return ResourceManager.GetString("MessageHandler_HandleCommand_help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Available commands:
        ///{0}.
        /// </summary>
        internal static string MessageHandler_HandleCommand_list {
            get {
                return ResourceManager.GetString("MessageHandler_HandleCommand_list", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi!
        ///Brief information about me you can see by using command /help.
        /// </summary>
        internal static string MessageHandler_HandleCommand_start {
            get {
                return ResourceManager.GetString("MessageHandler_HandleCommand_start", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, but I don&apos;t know this command :(.
        /// </summary>
        internal static string MessageHandler_HandleCommand_unknown_command {
            get {
                return ResourceManager.GetString("MessageHandler_HandleCommand_unknown_command", resourceCulture);
            }
        }
    }
}
