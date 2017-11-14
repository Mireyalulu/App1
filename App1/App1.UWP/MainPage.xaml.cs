﻿using System;
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

using Microsoft.WindowsAzure.MobileServices; 
using System.Threading.Tasks; 
using Windows.UI.Popups;

namespace App1.UWP
{
    public sealed partial class MainPage : ISQLAzure
    {
        private MobileServiceUser usuario;

        public async Task<MobileServiceUser> Authenticate()
        {
            try
            {
                usuario = await App1.DataPage.cliente.LoginAsync(MobileServiceAuthenticationProvider.MicrosoftAccount,"tesh.azurewebsites.net");
                    if (usuario !=null)
                {
                    await new MessageDialog(usuario.UserId, "Bienevenido").ShowAsync();
                }
            }
            catch (Exception ex)
            {
                await new MessageDialog(ex.Message, "Error message").ShowAsync();
            }
            return usuario;
        }
        public MainPage()
        {
            this.InitializeComponent();
            App1.App.Init((ISQLAzure)this);
            LoadApplication(new App1.App());
        }
    }
}
