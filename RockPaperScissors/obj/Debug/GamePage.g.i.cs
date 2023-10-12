﻿#pragma checksum "..\..\GamePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3467BFE52BC96BA505DB26D935F1AE415C3202F539A2BFE893A38349D0DF1462"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RockPaperScissors;
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


namespace RockPaperScissors {
    
    
    /// <summary>
    /// GamePage
    /// </summary>
    public partial class GamePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPlayerName;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlayerPreviousResults;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxShapes;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OKButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ResultsBlock;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResultsButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\GamePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame GameFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/RockPaperScissors;component/gamepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GamePage.xaml"
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
            this.LabelPlayerName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.PlayerPreviousResults = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ListBoxShapes = ((System.Windows.Controls.ListBox)(target));
            
            #line 16 "..\..\GamePage.xaml"
            this.ListBoxShapes.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ListBoxShapes_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OKButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\GamePage.xaml"
            this.OKButton.Click += new System.Windows.RoutedEventHandler(this.ShapeOK);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ResultsBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ResultsButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\GamePage.xaml"
            this.ResultsButton.Click += new System.Windows.RoutedEventHandler(this.NavigationToResultPage);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GameFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

