﻿#pragma checksum "..\..\..\..\View\MainWindow1Xaml.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E5EB98C553E11F30FD8B8C9E878587BF5571A42C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Assignment2_Group4_SE1610.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace Assignment2_Group4_SE1610.View {
    
    
    /// <summary>
    /// MainWindow1Xaml
    /// </summary>
    public partial class MainWindow1Xaml : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\View\MainWindow1Xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cartTitle;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\MainWindow1Xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem loginMBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\MainWindow1Xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem albumMenu;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Assignment2_Group4_SE1610;component/view/mainwindow1xaml.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\MainWindow1Xaml.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\..\View\MainWindow1Xaml.xaml"
            ((Assignment2_Group4_SE1610.View.MainWindow1Xaml)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\..\View\MainWindow1Xaml.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cartTitle = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\..\View\MainWindow1Xaml.xaml"
            this.cartTitle.Click += new System.Windows.RoutedEventHandler(this.cartTitle_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.loginMBtn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\..\View\MainWindow1Xaml.xaml"
            this.loginMBtn.Click += new System.Windows.RoutedEventHandler(this.loginMBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.albumMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\..\View\MainWindow1Xaml.xaml"
            this.albumMenu.Click += new System.Windows.RoutedEventHandler(this.albumMenu_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

