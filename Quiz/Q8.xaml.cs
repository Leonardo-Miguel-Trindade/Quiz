namespace Quiz;

public partial class Q8 : ContentPage
{
    Class1 c = new Class1();
    public Q8()
	{
		InitializeComponent();
	}

    private void OnConfirmarClicked(object sender, EventArgs e)
    {
        int resposta;
        if (rbA.IsChecked) { resposta = 1; }
        else if (rbB.IsChecked) { resposta = 2; }
        else if (rbC.IsChecked) { resposta = 3; }
        else { resposta = 4; }
        bool isCorrect = c.checar(8, resposta);

        c.formatar(isCorrect, new RadioButton[] { rbA, rbB, rbC, rbD }, lblResultado, resposta);
        btnProxima.IsVisible = true;
        btnConfirmar.IsVisible = false;
    }

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Q9());
    }
}