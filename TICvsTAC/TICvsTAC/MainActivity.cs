using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Telephony;
using Android.Provider;
using Xamarin.Essentials;
using Android.Views;
using Android.Media;
using static Android.Provider.MediaStore.Audio;
using Android.Support.V7.View;

namespace TICvsTAC

{


    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        int count = 0;




        void fnsymbol(View v)
        {
            string buttontxt = ((Button)v).Text;
            if (buttontxt == "")
            {
                if (count % 2 == 0)
                {
                    ((Button)v).Text = "O";
                }
                else
                {
                    ((Button)v).Text = "X";
                }
                count++;
                win();
            }
            else
            {
                Android.App.AlertDialog.Builder
                dialog = new Android.App.AlertDialog.Builder(this);
                Android.App.AlertDialog alert = dialog.Create();
                alert.SetTitle("ALERT");
                alert.SetMessage("INAVLID CLICK");
                alert.SetButton("OK", (c, ev) =>
                {
                    // Ok button click task  
                });
                alert.Show();
                Vibration.Vibrate();

            }
        }
        void reset(View v)
        {
            Button button1 = (Button)FindViewById(Resource.Id.button1);
            Button button2 = (Button)FindViewById(Resource.Id.button2);
            Button button3 = (Button)FindViewById(Resource.Id.button3);
            Button button4 = (Button)FindViewById(Resource.Id.button4);
            Button button5 = (Button)FindViewById(Resource.Id.button5);
            Button button6 = (Button)FindViewById(Resource.Id.button6);
            Button button7 = (Button)FindViewById(Resource.Id.button7);
            Button button8 = (Button)FindViewById(Resource.Id.button8);
            Button button9 = (Button)FindViewById(Resource.Id.button9);
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            count = 0;
        }
        void win()
        {
            int x = 0;
            Button button1 = (Button)FindViewById(Resource.Id.button1);
            Button button2 = (Button)FindViewById(Resource.Id.button2);
            Button button3 = (Button)FindViewById(Resource.Id.button3);
            Button button4 = (Button)FindViewById(Resource.Id.button4);
            Button button5 = (Button)FindViewById(Resource.Id.button5);
            Button button6 = (Button)FindViewById(Resource.Id.button6);
            Button button7 = (Button)FindViewById(Resource.Id.button7);
            Button button8 = (Button)FindViewById(Resource.Id.button8);
            Button button9 = (Button)FindViewById(Resource.Id.button9);
            if (((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")) && x == 0)
            {
                Android.App.AlertDialog.Builder
                dialog = new Android.App.AlertDialog.Builder(this);
                Android.App.AlertDialog alert = dialog.Create();
                alert.SetTitle("GAME OVER");
                alert.SetMessage("PLAYER 1 WINS!!");
                alert.SetButton("OK", (c, ev) =>
                {
                    // Ok button click task  
                });
                alert.Show();
                Vibration.Vibrate();
                x = 1;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                count = 0;

            }
            if (((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") || (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")) && x == 0)
            {
                Android.App.AlertDialog.Builder
                dialog = new Android.App.AlertDialog.Builder(this);
                Android.App.AlertDialog alert = dialog.Create();
                alert.SetTitle("GAME OVER");
                alert.SetMessage("PLAYER 2 WINS!!");
                alert.SetButton("OK", (c, ev) =>
                {
                    // Ok button click task  
                });
                alert.Show();
                Vibration.Vibrate();
                x = 1;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                count = 0;
            }
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" && x == 0)
            {
                Android.App.AlertDialog.Builder
                dialog = new Android.App.AlertDialog.Builder(this);
                Android.App.AlertDialog alert = dialog.Create();
                alert.SetTitle("GAME OVER");
                alert.SetMessage("GAME DRAW !!");
                alert.SetButton("OK", (c, ev) =>
                {
                    // Ok button click task  
                });
                alert.Show();
                Vibration.Vibrate();
                x = 0;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";
                count = 0;
            }
        }

        [Java.Interop.Export("button_OnClick1")]
        public void button_OnClick1(View v)
        {
            reset(v);
        }

        [Java.Interop.Export("button_OnClick")]
        public void button_OnClick(View v)
        {
            fnsymbol(v);

        }
       



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
