﻿#pragma checksum "..\..\PauseMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DEF380A8C2FECC12936181F8E4734BA0"
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
    /// PauseMenu
    /// </summary>
    public partial class PauseMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\PauseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_resume;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\PauseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image btn_go_to_menu;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PauseMenu.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Animation;component/pausemenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PauseMenu.xaml"
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
            this.btn_resume = ((System.Windows.Controls.Image)(target));
            
            #line 11 "..\..\PauseMenu.xaml"
            this.btn_resume.MouseMove += new System.Windows.Input.MouseEventHandler(this.Image_MouseMove);
            
            #line default
            #line hidden
            
            #line 11 "..\..\PauseMenu.xaml"
            this.btn_resume.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 12 "..\..\PauseMenu.xaml"
            this.btn_resume.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ResumeGameing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_go_to_menu = ((System.Windows.Controls.Image)(target));
            
            #line 15 "..\..\PauseMenu.xaml"
            this.btn_go_to_menu.MouseMove += new System.Windows.Input.MouseEventHandler(this.Image_MouseMove);
            
            #line default
            #line hidden
            
            #line 15 "..\..\PauseMenu.xaml"
            this.btn_go_to_menu.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 16 "..\..\PauseMenu.xaml"
            this.btn_go_to_menu.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GoToMenu);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_exit = ((System.Windows.Controls.Image)(target));
            
            #line 19 "..\..\PauseMenu.xaml"
            this.btn_exit.MouseMove += new System.Windows.Input.MouseEventHandler(this.Image_MouseMove);
            
            #line default
            #line hidden
            
            #line 19 "..\..\PauseMenu.xaml"
            this.btn_exit.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Image_MouseLeave);
            
            #line default
            #line hidden
            
            #line 20 "..\..\PauseMenu.xaml"
            this.btn_exit.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

