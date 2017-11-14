using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Microsoft.WindowsAzure.MobileServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<_13090390> Items { get; set; }
        //SQLiteConnection database;
        public static MobileServiceClient cliente;
        public static IMobileServiceTable<_13090390> Tabla;
        public static MobileServiceUser usuario;
        public DataPage()
        {
            InitializeComponent();
            //string db;
            //db = DependencyService.Get<SQLite>().GetLocalFilePath("TESHDB.db");
            //database = new SQLiteConnection(db);
            //database.CreateTable<TESHDatos>();
            cliente = new MobileServiceClient(AzureConnection.AzureURL);
            //Items = new ObservableCollection<TESHDatos> { database.Table<TESHDatos>() };
            //BindingContext = this;
            Tabla = cliente.GetTable<_13090390>();
            if (usuario != null) { LeerTabla(); };
            // Tabla.IncludeDeleted();
            // Tabla.UndeleteAsync(Id);
        }
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new SelectPage(e.SelectedItem as _13090390));
        }
        private async void LeerTabla()
        {
            IEnumerable<_13090390> elementos = await Tabla.ToEnumerableAsync();
            Items = new ObservableCollection<_13090390>(elementos);
            BindingContext = this;
            Lista.ItemsSource = Items;
        }

        private void Button_Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void Button_elimina_Clicked(object sender, EventArgs e)
        {
            LeerEliminados();

        }

        private async void LeerEliminados()
        {
            IEnumerable<_13090390> elementos = await Tabla.IncludeDeleted().ToEnumerableAsync();
            Items = new ObservableCollection<_13090390>(elementos);
            BindingContext = this;
            InitializeComponent();
        }

        private async void Button_Login_Clicked(object sender, EventArgs e)
        {
            usuario = await App.Authenticator.Authenticate();
            if (App.Authenticator != null)
            {
                if (usuario != null)
                {
                    await DisplayAlert("Usuario Autenticado", usuario.UserId, "ok");
                    LeerTabla();
                }
                if (usuario == null)
                {
                    Button_Insertar.IsVisible = false;
                    Button_Insertar.IsEnabled = false;
                }
            }
        }
                    protected override void OnAppearing()
        {
            base.OnAppearing();
            if (usuario !=null)
            {
                LeerTabla();
            }
        }
    }

}
