using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace PasarDatosActivity
{
	[Activity(Label = "Activity2")]
	public class Activity2 : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			String texto = Intent.GetStringExtra("Mensaje") ?? "No se encontro el texto";



			// Create your application here
			SetContentView(Resource.Layout.Activity2);

			TextView mensajeRecib = FindViewById<TextView>(Resource.Id.tvMensaje);
			mensajeRecib.Text=texto;

			Button btnVolver = FindViewById<Button>(Resource.Id.btnVolver);

			btnVolver.Click += delegate 
			{
				var intento = new Intent(this, typeof(MainActivity));
				StartActivity(intento);
				Finish();
			};
			                     
		}
	}
}

