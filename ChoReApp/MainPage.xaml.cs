using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ChoReApp.Resources;

namespace ChoReApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            formlogin.clickSignUp+=formlogin_clickSignUp;
            formlogin.ClickForgetPassword += formlogin_ClickForgetPassword;
            listgoods.ItemsSource = App.listgoods.item;
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        void formlogin_ClickForgetPassword()
        {
            PivotMain.SelectedIndex=7;
        }

        private void formlogin_clickSignUp()
        {
            PivotMain.SelectedIndex = 2;
        }

        private void submitforgetpassword_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("quên thì sao?");
        }

        

        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}