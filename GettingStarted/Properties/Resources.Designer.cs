﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GettingStarted.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GettingStarted.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Here&apos;s a first example on how to use the ShellBrowser components.
        ///
        ///We placed a ShellHistoryToolStrip on top, a ShellTreeView on the left and a ShellListView on the right.
        ///All these components have their property &apos;ShellControlConnector&apos; set to the same instance. This invisible control acts 
        ///as a mediator between the different controls and synchronizes them.
        ///We then enhanced the ToolStrip with a toggle button that enables or disables the &apos;Checkboxes&apos; property of the controls.
        ///
        ///Of course it&apos;s easy to al [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SimpleExample1 {
            get {
                return ResourceManager.GetString("SimpleExample1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We use a ShellComboBox to mimic the dropdown menu of the Explorer.
        ///
        ///You can type into the combobox and have the autocompletion just as you would do in the Windows Explorer.
        ///Again, a ShellControlConnector mediates events between different controls.
        ///
        ///This time we used a ShellListView with viewstate &quot;Thumbnails&quot;. It can display all documents that have thumbnail handlers registered in the windows operating system. 
        ///The ThumbnailImage on the right side is a component for displaying the thumbnail of a singl [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SimpleExample2 {
            get {
                return ResourceManager.GetString("SimpleExample2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ShellChangeNotifier control notifies if changes occur on the filesystem.
        ///
        ///Add folders from the upper ShellListView to the FileListView below by dragging them with the mouse. The collection of items specifies where 
        ///the ShellChangeNotifier should listen for file or folder events. If the list is empty, the control notifies changes of the whole file system.
        ///
        ///On the left you can choose on what events the control should create a change event. In our example, we fill a textbox with 
        ///relevant information [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SimpleExample3 {
            get {
                return ResourceManager.GetString("SimpleExample3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ShellDriveList control lists the configured drive letters and available space.
        ///    It is linked to a component displaying the contents of the selected drives.
        ///    You can define warning and error threshholds for the freespace and assign different custom colors to visualize when a drive is almost full.
        ///    
        ///    The right side component is an ExplorerBrowser. It can be configured to cover a complete Windows Explorer window. See the ExplorerBrowserSample to view options in detail.
        ///    .
        /// </summary>
        internal static string SimpleExample4 {
            get {
                return ResourceManager.GetString("SimpleExample4", resourceCulture);
            }
        }
    }
}