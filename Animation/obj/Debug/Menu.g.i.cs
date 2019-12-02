﻿#pragma checksum "..\..\Menu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E56817E3BFB29ABE4C9BFC7F89314F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Animation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Animation {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MainCanvas;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_new_game;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_options;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_players;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_exit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Animation;component/menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\Menu.xaml"
            ((Animation.Menu)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 10 "..\..\Menu.xaml"
            ((Animation.Menu)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.btn_new_game = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\Menu.xaml"
            this.btn_new_game.MouseMove += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseDown);
            
            #line default
            #line hidden
            
            #line 20 "..\..\Menu.xaml"
            this.btn_new_game.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseUp);
            
            #line default
            #line hidden
            
            #line 21 "..\..\Menu.xaml"
            this.btn_new_game.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StartNewGame);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_options = ((System.Windows.Controls.Image)(target));
            
            #line 24 "..\..\Menu.xaml"
            this.btn_options.MouseMove += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseDown);
            
            #line default
            #line hidden
            
            #line 25 "..\..\Menu.xaml"
            this.btn_options.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseUp);
            
            #line default
            #line hidden
            
            #line 26 "..\..\Menu.xaml"
            this.btn_options.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_options_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_players = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\Menu.xaml"
            this.btn_players.MouseMove += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseDown);
            
            #line default
            #line hidden
            
            #line 30 "..\..\Menu.xaml"
            this.btn_players.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseUp);
            
            #line default
            #line hidden
            
            #line 31 "..\..\Menu.xaml"
            this.btn_players.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_players_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_exit = ((System.Windows.Controls.Image)(target));
            
            #line 34 "..\..\Menu.xaml"
            this.btn_exit.MouseMove += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseDown);
            
            #line default
            #line hidden
            
            #line 35 "..\..\Menu.xaml"
            this.btn_exit.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ButtonsMuoseUp);
            
            #line default
            #line hidden
            
            #line 37 "..\..\Menu.xaml"
            this.btn_exit.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.btn_exit_MouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
