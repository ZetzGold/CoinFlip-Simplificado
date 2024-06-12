namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void GirarButton_Clicked(object sender, EventArgs e)
        {
            //0 = cara e 1 = coroa
            string resultado;
            string ladoSelecionado = SelecaoPicker.SelectedItem.ToString();
            string ladoSorteado = new Random().Next(2).ToString();
            if(ladoSorteado == "0")
            {
                ladoSorteado = "cara";
            }
            else
            {
                ladoSorteado = "coroa";
            }

            if(ladoSelecionado == ladoSorteado)
            {
                resultado = "Parabéns! Você venceu!";
            }
            else
            {
                resultado = "Que Pena! Você perdeu!";
            }
            ResultadoLabel.Text = resultado;
            MoedaImage.Source = ladoSorteado + ".png";
        }
    }

}
