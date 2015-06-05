using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DockingManager
{
   public class LayoutAnchorable:LayoutItem
   {
      static LayoutAnchorable()
      {
         DefaultStyleKeyProperty.OverrideMetadata(typeof(LayoutAnchorable),
             new FrameworkPropertyMetadata(typeof(LayoutAnchorable)));
      }
   }
}
