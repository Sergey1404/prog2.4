﻿#pragma checksum "..\..\..\Pages\Lab3_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC19B05A5783B161BBA129284FF1156AFE0A0A2BBD99D5D2EE8FDFFAB2BDAF37"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Programing_Labs.Pages;
using ScottPlot;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Programing_Labs.Pages {
    
    
    /// <summary>
    /// Lab3_Page
    /// </summary>
    public partial class Lab3_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Pages\Lab3_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxA;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Lab3_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxB;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\Lab3_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxE;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Pages\Lab3_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxFx;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\Pages\Lab3_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Back;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\Pages\Lab3_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Forward;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Pages\Lab3_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ScottPlot.WpfPlot WpfPlot1;
        
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
            System.Uri resourceLocater = new System.Uri("/Programing Labs;component/pages/lab3_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Lab3_Page.xaml"
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
            
            #line 11 "..\..\..\Pages\Lab3_Page.xaml"
            ((Programing_Labs.Pages.Lab3_Page)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBoxE = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextBoxFx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 124 "..\..\..\Pages\Lab3_Page.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemSolve_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 131 "..\..\..\Pages\Lab3_Page.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemClear_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Button_Back = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\..\Pages\Lab3_Page.xaml"
            this.Button_Back.Click += new System.Windows.RoutedEventHandler(this.Button_Back_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Button_Forward = ((System.Windows.Controls.Button)(target));
            
            #line 155 "..\..\..\Pages\Lab3_Page.xaml"
            this.Button_Forward.Click += new System.Windows.RoutedEventHandler(this.Button_Forward_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.WpfPlot1 = ((ScottPlot.WpfPlot)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

