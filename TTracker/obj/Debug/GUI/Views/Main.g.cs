﻿#pragma checksum "..\..\..\..\GUI\Views\Main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DD989CF980B4A98FAF29CED03EC9394262F3298190843AD9BD9EA0F6DC8E4E02"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TTracker;
using TTracker.GUI.ViewModels;
using TTracker.GUI.Views;


namespace TTracker {
    
    
    /// <summary>
    /// Main
    /// </summary>
    public partial class Main : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Ribbon;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TicketManagement;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalendarButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TimeButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatisticsButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccountButton;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\GUI\Views\Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame NavigationFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/TTracker;component/gui/views/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\Views\Main.xaml"
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
            this.Ribbon = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\GUI\Views\Main.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.HomeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TicketManagement = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\GUI\Views\Main.xaml"
            this.TicketManagement.Click += new System.Windows.RoutedEventHandler(this.TicketManagement_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CalendarButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\GUI\Views\Main.xaml"
            this.CalendarButton.Click += new System.Windows.RoutedEventHandler(this.CalendarButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TimeButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\GUI\Views\Main.xaml"
            this.TimeButton.Click += new System.Windows.RoutedEventHandler(this.TimeEngine_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StatisticsButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\GUI\Views\Main.xaml"
            this.StatisticsButton.Click += new System.Windows.RoutedEventHandler(this.StatisticsButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AccountButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\..\GUI\Views\Main.xaml"
            this.AccountButton.Click += new System.Windows.RoutedEventHandler(this.AccountButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NavigationFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

