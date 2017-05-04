using Xamarin.Forms;

namespace ToiDau.Views
{
    public partial class LoginPage2 : ContentPage
    {
        int selectedStage = 0;
        public LoginPage2()
        {
            InitializeComponent();
            entryPin1.Focus();
        }



        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string _text = ((Entry)sender).Text;      //Get Current Text
            if (_text.Length > 1)       //If it is more than your character restriction
            {
                _text = _text.Remove(_text.Length - 1);  // Remove Last character
                ((Entry)sender).Text = _text;        //Set the Old value
            }

            switch (selectedStage)
            {
                case 0:
                    selectedStage++;
                    entryPin2.Focus();
                    break;
                case 1:
                    selectedStage++;
                    entryPin3.Focus();
                    break;
                case 2:
                    selectedStage++;
                    entryPin4.Focus();
                    break;
                case 3:
                    selectedStage++;
                    buttonLogin.Focus();
                    break;
                default:
                    buttonLogin.Focus();
                    break;
            }
        }
    }
}
