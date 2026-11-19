namespace Quiz;

public partial class Resultado : ContentPage
{
    Class1 c = new Class1();
    public Resultado()
	{
		InitializeComponent();

        
        lblPontuacao.Text = c.getpont().ToString();

        if(c.getpont() == 10)
        {
            lblMensagem.Text = "Perfeito! Você acertou todas!";
        }
        else if (c.getpont() >= 8)
        {
            lblMensagem.Text = "Parabéns!! Você foi muito bem!";
        } 
        else if (c.getpont() >= 5)
        {
            lblMensagem.Text = "Bom trabalho";
        }
        else
        {
            lblMensagem.Text = "Precisa estudar mais";
        }
    }

    private async void OnJogarNovamenteClicked(object sender, EventArgs e)
    {
        c.zerarpont();
        await Navigation.PopToRootAsync();
        await Navigation.PushAsync(new Q1());
    }

    private async void OnVoltarInicioClicked(object sender, EventArgs e)
    {
        c.zerarpont();
        await Navigation.PopToRootAsync();
    }
}