using System;
using Today.Models;
using Today.ViewModels;
using Xamarin.Forms;
using SQLite;

namespace Today.Views
{
    public partial class Items : ContentPage
    {

        ItemViewModel Model = new ItemViewModel();

        public Items()
        {
            InitializeComponent();
            BindingContext = Model;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var tarea = new Tarea()
            {
                Nombre = Model.Tarea,
                fInicial=DateTime.Today,
                Status=false
            };

            using(var conexion = new SQLiteConnection(App.RutaDB))
            {

                conexion.CreateTable<Tarea>();

               var result = conexion.Insert(tarea);

                if (result > 0)
                {
                    
                    DisplayAlert("Exito","$ El elemento {tarea.Nombre} a sido creado ", "OK");
                
                }

                else
                {
                    
					DisplayAlert("Error", "Favor de intentarlo de nuevo", "OK");

				}
            }
        }
    }
}
