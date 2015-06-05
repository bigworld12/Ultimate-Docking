using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DockingManager
{
   /// <summary>
   /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
   ///
   /// Step 1a) Using this custom control in a XAML file that exists in the current project.
   /// Add this XmlNamespace attribute to the root element of the markup file where it is 
   /// to be used:
   ///
   ///     xmlns:MyNamespace="clr-namespace:DockingManager"
   ///
   ///
   /// Step 1b) Using this custom control in a XAML file that exists in a different project.
   /// Add this XmlNamespace attribute to the root element of the markup file where it is 
   /// to be used:
   ///
   ///     xmlns:MyNamespace="clr-namespace:DockingManager;assembly=DockingManager"
   ///
   /// You will also need to add a project reference from the project where the XAML file lives
   /// to this project and Rebuild to avoid compilation errors:
   ///
   ///     Right click on the target project in the Solution Explorer and
   ///     "Add Reference"->"Projects"->[Select this project]
   ///
   ///
   /// Step 2)
   /// Go ahead and use your control in the XAML file.
   ///
   ///     <MyNamespace:CustomControl1/>
   ///
   /// </summary>
   [ContentProperty("LayoutRoot")]
   public class DockingManager : ContentControl
   {
      public LayoutRoot LayoutRoot { get; set; }
      static DockingManager()
      {
         DefaultStyleKeyProperty.OverrideMetadata(typeof (DockingManager),
            new FrameworkPropertyMetadata(typeof (DockingManager)));

         ContentProperty.OverrideMetadata(typeof(DockingManager), new FrameworkPropertyMetadata(new PropertyChangedCallback(RootLayoutChanged)));
      }

      private static void RootLayoutChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
      {
         
      }

      public void AddDocument(LayoutItem document)
      {
         Button btn = new Button();
         btn.Content = document.Header;
         //DocumentContainer.Items.Add(document.Content);
         //DocumentContainer.LayoutDocuments.Add(document);
      }
   }
}
