namespace GasApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // obtendo os valores inseridos 
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                // string para exibir resultado
                string result;

                // esse programa verifica qual combustível compensa mais
                // por regra, o etanol deve ter no máximo 70% do preço da gasolina, caso contrário, a gasolina sempre renderá mais
                if (etanol <= (gasolina*0.7) )
                {
                    result = "O etanol rende mais.";
                }
                else
                {
                    result = "A gasolina rende mais.";
                }

                DisplayAlertAsync("Comparativo", $"Para os valores Etanol: {etanol} e Gasolina: {gasolina}\n{result}", "OK");

            } 
            catch (Exception ex)
            {
                DisplayAlertAsync("Ops", ex.Message, "Fechar");
            }

        }
    }
}
