using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;

namespace ThemeAndroid2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;

        ImageView ivCoccinelle;
        ImageView ivAir;
        ImageView ivEau;
        ImageView ivEnvironnement;

        TextView tvEnvironement;
        TextView tvAir;
        TextView tvEau;
        TextView tvDechet;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textMessage = FindViewById<TextView>(Resource.Id.message);

            ivCoccinelle = FindViewById<ImageView>(Resource.Id.ivCoccinelle);
            ivAir = FindViewById<ImageView>(Resource.Id.ivAir);
            ivEau = FindViewById<ImageView>(Resource.Id.ivEau);
            ivEnvironnement = FindViewById<ImageView>(Resource.Id.ivEnvironnement);

            tvEnvironement = FindViewById<TextView>(Resource.Id.tvEnvironnement);
            tvAir = FindViewById<TextView>(Resource.Id.tvAir);
            tvEau = FindViewById<TextView>(Resource.Id.tvEau);
            tvDechet = FindViewById<TextView>(Resource.Id.tvDéchet);



            ivCoccinelle.SetImageResource(Resource.Drawable.coccinelle);
            ivAir.SetImageResource(Resource.Drawable.eoliennes);
            ivEau.SetImageResource(Resource.Drawable.goutte_eau);
            ivEnvironnement.SetImageResource(Resource.Drawable.poubelle);



            tvEnvironement.Click += (sender, e) =>
            {
                //Appel page thème Envirronement
                
            };

            tvAir.Click += (sender, e) =>
            {
                //Appel page thème Air
               
            };

            tvEau.Click += (sender, e) =>
            {
                //Appel page thème Eau

            };

            tvDechet.Click += (sender, e) =>
            {
                //Appel page thème Déchet
                
            };






            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    // Appel Menu Médail
                    return true;

                case Resource.Id.navigation_dashboard:
                    // Appel Menu Statistique
                    return true;

                case Resource.Id.navigation_notifications:
                    // Appel Menu Parametre
                    return true;

            }
            return false;
        }
    }
}

