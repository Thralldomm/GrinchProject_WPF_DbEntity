#pragma checksum "..\..\..\..\frames\CharacterPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FC047B44E4259DDE6C27C262543464453B60425C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GrinchProject.frames;
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


namespace GrinchProject.frames {
    
    
    /// <summary>
    /// CharacterPage
    /// </summary>
    public partial class CharacterPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Main_Character_Grid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Button;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_Button;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SFF_Grid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Sort;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sort_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Filter;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filter_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Search;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search_TextBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\frames\CharacterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Character_ListView;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GrinchProject;component/frames/characterpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\frames\CharacterPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Main_Character_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Add_Button = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\frames\CharacterPage.xaml"
            this.Add_Button.Click += new System.Windows.RoutedEventHandler(this.Add_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Delete_Button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\frames\CharacterPage.xaml"
            this.Delete_Button.Click += new System.Windows.RoutedEventHandler(this.Delete_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SFF_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.Sort = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Sort_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 84 "..\..\..\..\frames\CharacterPage.xaml"
            this.Sort_ComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sort_ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Filter = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Filter_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 89 "..\..\..\..\frames\CharacterPage.xaml"
            this.Filter_ComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Filter_ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Search = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Search_TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 94 "..\..\..\..\frames\CharacterPage.xaml"
            this.Search_TextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Character_ListView = ((System.Windows.Controls.ListView)(target));
            
            #line 102 "..\..\..\..\frames\CharacterPage.xaml"
            this.Character_ListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Character_ListView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 12:
            
            #line 154 "..\..\..\..\frames\CharacterPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.character_button_Click);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 162 "..\..\..\..\frames\CharacterPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Button_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

