using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CustomListBoxSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
      
            public MainPage()
            {
                Employees = new List<Employee>();
                this.InitializeComponent();

            }

        private List<Employee> employees;

        public List<Employee> Employees

        {

            get { return employees; }

            set { employees = value; }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = !popup.IsOpen;
        }

        private void popup_Opened(object sender, object e)
        {
            List<object> max1 = new List<object>();


            max1.Add(new Employee { Name = "Lucas", Email = "lucas@syncfusion.com" });

            max1.Add(new Employee { Name = "James", Email = "james@syncfusion.com" });

            max1.Add(new Employee { Name = "Jacob", Email = "jacob@syncfusion.com" });

            CustomBox.ItemsSource = max1;
        }
    }

    public class Employee

    {

        public string Name { get; set; }



        public string Email { get; set; }

    }
}
