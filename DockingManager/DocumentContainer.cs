using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace DockingManager
{
   [ContentProperty("LayoutDocuments")]
   public class DocumentContainer : ContentControl
   {
      //public static readonly DependencyProperty ContentProperty =
      //      DependencyProperty.Register("Content", typeof(Object), typeof(LayoutItem),
      //          new PropertyMetadata(false));

      ///// <summary>
      ///// Get/sets whether whole range will be moved when press on right/left/central part of control
      ///// </summary>
      //[Bindable(true), Category("Behavior")]
      //public Object Content
      //{
      //   get { return (Boolean)GetValue(ContentProperty); }
      //   set { SetValue(ContentProperty, value); }
      //}

     
      public List<LayoutItem> LayoutDocuments { get; set; }
      static DocumentContainer() 
      {
         DefaultStyleKeyProperty.OverrideMetadata(typeof(DocumentContainer),
             new FrameworkPropertyMetadata(typeof(DocumentContainer)));
      }

      public DocumentContainer()
      {
         LayoutDocuments = new List<LayoutItem>();
      }
   }
}
