﻿#pragma checksum "..\..\..\Windows\GenerateSqlScriptWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EA22633C13564B27FC7AA3F3C4D65E616A89C2B4E50FDFFB148F6A8D4CE7ED31"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
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


namespace HigLabo.DbSharpApplication {
    
    
    /// <summary>
    /// GenerateSqlScriptWindow
    /// </summary>
    public partial class GenerateSqlScriptWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Windows\GenerateSqlScriptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OutputDirectoryPathTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\GenerateSqlScriptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\GenerateSqlScriptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExecuteButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Windows\GenerateSqlScriptWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/DbSharpApplication;component/windows/generatesqlscriptwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\GenerateSqlScriptWindow.xaml"
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
            this.OutputDirectoryPathTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ResultLabel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ExecuteButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Windows\GenerateSqlScriptWindow.xaml"
            this.ExecuteButton.Click += new System.Windows.RoutedEventHandler(this.ExecuteButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.QuitButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Windows\GenerateSqlScriptWindow.xaml"
            this.QuitButton.Click += new System.Windows.RoutedEventHandler(this.QuitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
