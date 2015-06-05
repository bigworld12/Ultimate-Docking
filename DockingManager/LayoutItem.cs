using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DockingManager
{
   public class LayoutItem : HeaderedContentControl
   {
      public static readonly DependencyProperty CanCloseProperty =
            DependencyProperty.Register("CanClose", typeof(Boolean), typeof(LayoutItem),
                new PropertyMetadata(false));

      public static readonly DependencyProperty CanHideProperty =
            DependencyProperty.Register("CanHide", typeof(Boolean), typeof(LayoutItem),
                new PropertyMetadata(false));

      public static readonly DependencyProperty CanFloatProperty =
            DependencyProperty.Register("CanFloat", typeof(Boolean), typeof(LayoutItem),
                new PropertyMetadata(false));

      /// <summary>
      /// Get/sets whether item can be closed
      /// </summary>
      [Bindable(true), Category("Behavior")]
      public Boolean CanClose
      {
         get { return (Boolean)GetValue(ContentProperty); }
         set { SetValue(ContentProperty, value); }
      }

      /// <summary>
      /// Get/sets whether item can be hided
      /// </summary>
      [Bindable(true), Category("Behavior")]
      public Boolean CanHide
      {
         get { return (Boolean)GetValue(ContentProperty); }
         set { SetValue(ContentProperty, value); }
      }

      /// <summary>
      /// Get/sets whether item can be detached and use as float window
      /// </summary>
      [Bindable(true), Category("Behavior")]
      public Boolean CanFloat
      {
         get { return (Boolean)GetValue(ContentProperty); }
         set { SetValue(ContentProperty, value); }
      }

      static LayoutItem()
      {
         DefaultStyleKeyProperty.OverrideMetadata(typeof(LayoutItem),
            new FrameworkPropertyMetadata(typeof(LayoutItem)));

         ContentTemplateSelectorProperty.OverrideMetadata(typeof(LayoutItem), new FrameworkPropertyMetadata(new PropertyChangedCallback(TemplateSelectorChanged)));
      }

      private static void TemplateSelectorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
      {
         
      }

      public LayoutItem()
      {

      }

   }
}
