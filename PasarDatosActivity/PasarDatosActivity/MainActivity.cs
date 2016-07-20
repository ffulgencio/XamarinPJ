using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace PasarDatosActivity
{
	[Activity(Label = "PasarDatosActivity", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);
			EditText mensaje = FindViewById<EditText>(Resource.Id.edMensaje);

			button.Click += delegate 
			{
				//button.Text = string.Format("{0} clicks!", count++); 
				var activity2 = new Intent(this, typeof(Activity2));
			

				activity2.PutExtra("Mensaje", mensaje.Text);

				StartActivity(activity2);

				Finish();

			};
		}
	}
}


