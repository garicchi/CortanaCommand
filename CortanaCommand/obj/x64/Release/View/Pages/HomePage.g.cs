﻿#pragma checksum "C:\Users\garicchi\Projects\Repository\Windows\CortanaCommand\CortanaCommand\View\Pages\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B073857D5D087EED955A0807AC7A860"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CortanaCommand
{
    partial class HomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.listColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 2:
                {
                    this.gridList = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.frameCommand = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 4:
                {
                    this.listBox_command = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 31 "..\..\..\..\View\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.listBox_command).ItemClick += this.listBox_command_ItemClick;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.Grid element5 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 40 "..\..\..\..\View\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)element5).RightTapped += this.gridListTemplate_RightTapped;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element6 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 43 "..\..\..\..\View\Pages\HomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element6).Click += this.menuItemDelete_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
