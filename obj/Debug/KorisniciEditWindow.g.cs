﻿#pragma checksum "..\..\KorisniciEditWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "00F74F13CE50146C8EF2DCEC7EB1AA92"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace SkolaJezikaWPF {
    
    
    /// <summary>
    /// KorisniciEditWindow
    /// </summary>
    public partial class KorisniciEditWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbIme;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPrzime;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbJmbg;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbKime;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbLozinka;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bSacuvaj;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bOdustani;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\KorisniciEditWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTip;
        
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
            System.Uri resourceLocater = new System.Uri("/SkolaJezikaWPF;component/korisnicieditwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KorisniciEditWindow.xaml"
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
            this.tbIme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbPrzime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbJmbg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbKime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbLozinka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.bSacuvaj = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\KorisniciEditWindow.xaml"
            this.bSacuvaj.Click += new System.Windows.RoutedEventHandler(this.bSacuvaj_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bOdustani = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\KorisniciEditWindow.xaml"
            this.bOdustani.Click += new System.Windows.RoutedEventHandler(this.bOdustani_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbTip = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

