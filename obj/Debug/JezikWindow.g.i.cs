﻿#pragma checksum "..\..\JezikWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E1B0C69483D392497F07FEE579979F38"
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
    /// JezikWindow
    /// </summary>
    public partial class JezikWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\JezikWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgJezik;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\JezikWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bDodaj;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\JezikWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bIzmeni;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\JezikWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bObrisi;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\JezikWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bZatvori;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\JezikWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPretragaJezika;
        
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
            System.Uri resourceLocater = new System.Uri("/SkolaJezikaWPF;component/jezikwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\JezikWindow.xaml"
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
            this.dgJezik = ((System.Windows.Controls.DataGrid)(target));
            
            #line 6 "..\..\JezikWindow.xaml"
            this.dgJezik.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgJezik_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bDodaj = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\JezikWindow.xaml"
            this.bDodaj.Click += new System.Windows.RoutedEventHandler(this.bDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bIzmeni = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\JezikWindow.xaml"
            this.bIzmeni.Click += new System.Windows.RoutedEventHandler(this.bIzmeni_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bObrisi = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\JezikWindow.xaml"
            this.bObrisi.Click += new System.Windows.RoutedEventHandler(this.bObrisi_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bZatvori = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\JezikWindow.xaml"
            this.bZatvori.Click += new System.Windows.RoutedEventHandler(this.bZatvori_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbPretragaJezika = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\JezikWindow.xaml"
            this.tbPretragaJezika.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbPretragaJezika_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

