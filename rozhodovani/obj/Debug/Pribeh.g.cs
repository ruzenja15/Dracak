﻿#pragma checksum "..\..\Pribeh.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C99D63095EF9283E462AE206242EBA26"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using rozhodovani;


namespace rozhodovani {
    
    
    /// <summary>
    /// Pribeh
    /// </summary>
    public partial class Pribeh : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Pribeh.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox question;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Pribeh.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttn1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Pribeh.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttn2;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Pribeh.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttn3;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Pribeh.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bttn4;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Pribeh.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Combat_okno;
        
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
            System.Uri resourceLocater = new System.Uri("/rozhodovani;component/pribeh.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Pribeh.xaml"
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
            this.question = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.bttn1 = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Pribeh.xaml"
            this.bttn1.Click += new System.Windows.RoutedEventHandler(this.Next_Dialog);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bttn2 = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Pribeh.xaml"
            this.bttn2.Click += new System.Windows.RoutedEventHandler(this.Next_Dialog);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bttn3 = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\Pribeh.xaml"
            this.bttn3.Click += new System.Windows.RoutedEventHandler(this.Next_Text);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bttn4 = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Pribeh.xaml"
            this.bttn4.Click += new System.Windows.RoutedEventHandler(this.End_Game);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Combat_okno = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

