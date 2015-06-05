using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace DockingManager
{
   public class AnchorableContainer: ContentControl
   {
      public LayoutAnchorable LayoutAnchorable { get; set; }
      static AnchorableContainer()
      {
         DefaultStyleKeyProperty.OverrideMetadata(typeof(AnchorableContainer),
            new FrameworkPropertyMetadata(typeof(AnchorableContainer)));
      }

      public AnchorableContainer()
      {
         
      }
   }
}
