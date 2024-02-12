using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml;

namespace CustomListBoxSample
{
    public class CustomSuggestionBox : ListBox, IDisposable
    {

        private ListBoxItem listboxitem;
      
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSuggestionBox" /> class.
        /// </summary>
        public CustomSuggestionBox()
        {
            this.SelectionChanged += this.SuggestionBox_SelectionChanged;
            this.Tapped += SuggestionBox_Tapped;
        }

        /// <summary>
        /// Prepare container for item override
        /// </summary>
        /// <param name="element">Dependency object</param>
        /// <param name="item">object type</param>
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            System.Diagnostics.Debug.WriteLine("CustomSuggesionBox-------PrepareContainerForItemOverride");
            this.listboxitem = element as ListBoxItem;

            listboxitem.Loaded -= Listboxitem_Loaded;
            listboxitem.Loaded += Listboxitem_Loaded;
            listboxitem.Unloaded -= Listboxitem_Unloaded;
            listboxitem.Unloaded += Listboxitem_Unloaded;
         
            base.PrepareContainerForItemOverride(element, item);
        }

        private void Listboxitem_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
     
        private void Listboxitem_Unloaded(object sender, RoutedEventArgs e)
        {
            ListBoxItem listBoxItem = sender as ListBoxItem;
            if (listBoxItem != null)
            {
                System.Diagnostics.Debug.WriteLine("CustomSuggesionBox-------Unsubscribe the events");
                listBoxItem.Loaded -= Listboxitem_Loaded;
                listBoxItem.Unloaded -= Listboxitem_Unloaded;
            }
        }
     
        private void SuggestionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SuggestionBox_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }

        protected virtual void Dispose(bool disposing)
        {
            GC.SuppressFinalize(this);
            if (this.listboxitem != null)
            {
                this.listboxitem = null;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            this.Tapped -= SuggestionBox_Tapped;
            if (this.listboxitem != null)
            {
               // this.listboxitem.DataContextChanged -= this.Listboxitem_DataContextChanged;
                this.listboxitem = null;
            }
            this.SelectionChanged -= this.SuggestionBox_SelectionChanged;
            this.ItemsSource = null;

            this.Items.Clear();
        }
    }

}
