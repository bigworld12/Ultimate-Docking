using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DockingManager
{
   public class LayoutRoot:ItemsControl
   {
      public DocumentContainer DocumentContainer { get; set; }
      public AnchorableContainer AnchorableContainer { get; set; }
      static LayoutRoot()
      {
         DefaultStyleKeyProperty.OverrideMetadata(typeof(LayoutRoot),
            new FrameworkPropertyMetadata(typeof(LayoutRoot)));
      }

      public LayoutRoot()
      {
         DocumentContainer = new DocumentContainer();
         AnchorableContainer = new AnchorableContainer();
      }
   }
}
