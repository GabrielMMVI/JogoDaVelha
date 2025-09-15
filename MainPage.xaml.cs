namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string jogadorAtual = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (jogadorAtual == "X")
            {
                btn.Text = "X";
                jogadorAtual = "O";
            }
            else
            {
                btn.Text = "O";
                jogadorAtual = "X";
            }

        }

    }

}
