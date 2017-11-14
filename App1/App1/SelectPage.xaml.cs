using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectPage : ContentPage
    {
        public SelectPage(object selectedItem)
        {
            var dato = selectedItem as _13090390;
            BindingContext = dato;
            InitializeComponent();
            if (DataPage.usuario == null)
            {
                Entry_Nombre.IsEnabled = false;
                Entry_Apellido.IsEnabled = false;
                Entry_Direccion.IsEnabled = false;
                Entry_Telefono.IsEnabled = false;
                Entry_Carrera.IsEnabled = false;
                Entry_Semestre.IsEnabled = false;
                Entry_Correo.IsEnabled = false;
                Entry_Github.IsEnabled = false;
                Button_Actualizar.IsVisible = false;
                Button_Eliminar.IsVisible = false;
                Button_Actualizar.IsEnabled = false;
                Button_Eliminar.IsEnabled = false;


            }
        

        }
        private async void Button_Actualizar_Clicked_1(object sender, EventArgs e)
        {
            var datos = new _13090390
            {
                Id = Entry_Id.Text,
                Nombre = Entry_Nombre.Text,
                Apellido = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Entry_Telefono.Text,
                Carrera = Entry_Carrera.Text,
                Semestre = Entry_Semestre.Text,
                Correo = Entry_Correo.Text,
                Github = Entry_Github.Text
            };
            await DataPage.Tabla.UpdateAsync(datos);
            await Navigation.PopAsync();
        }



        private async void Button_Eliminar_Clicked_1(object sender, EventArgs e)
        {
            var datos = new _13090390
            {
                Id = Entry_Id.Text,
                Nombre = Entry_Nombre.Text,
                Apellido = Entry_Apellido.Text,
                Direccion = Entry_Direccion.Text,
                Telefono = Entry_Telefono.Text,
                Carrera = Entry_Carrera.Text,
                Semestre = Entry_Semestre.Text,
                Correo = Entry_Correo.Text,
                Github = Entry_Github.Text
            };
            await DataPage.Tabla.DeleteAsync(datos);
            await Navigation.PopAsync();
        }

        private async void Button_Recuperar_Clicked(object sender, EventArgs e)
        {

            var datos = new _13090390
            {
                Id = Entry_Id.Text,
            };
            await DataPage.Tabla.UndeleteAsync(datos);
            await Navigation.PopAsync();

        }

    }
}
