// Updated by XamlIntelliSenseFileGenerator 10/4/2020 2:03:45 AM
#pragma checksum "..\..\..\..\XmlFolder\Book.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A54C7BA0D1F134AD7853CCDBE02B18C5796EF047"
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
using VstaabnerWpf.XmlFolder;


namespace VstaabnerWpf.XmlFolder
{


    /// <summary>
    /// Book
    /// </summary>
    public partial class Book : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 14 "..\..\..\..\XmlFolder\Book.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtid;

#line default
#line hidden


#line 15 "..\..\..\..\XmlFolder\Book.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtName;

#line default
#line hidden


#line 25 "..\..\..\..\XmlFolder\Book.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtseroyal;

#line default
#line hidden


#line 35 "..\..\..\..\XmlFolder\Book.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtittel;

#line default
#line hidden


#line 45 "..\..\..\..\XmlFolder\Book.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPublisher;

#line default
#line hidden


#line 55 "..\..\..\..\XmlFolder\Book.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MyLabel;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VstaabnerWpf;component/xmlfolder/book.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\XmlFolder\Book.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 10 "..\..\..\..\XmlFolder\Book.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 2:

#line 13 "..\..\..\..\XmlFolder\Book.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);

#line default
#line hidden
                    return;
                case 3:
                    this.txtid = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.txtName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.txtseroyal = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.txtittel = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.txtPublisher = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.MyLabel = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DataGrid datagrid;
    }
}
