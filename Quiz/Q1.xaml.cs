using Microsoft.Maui.Graphics.Text;

namespace Quiz;

public partial class Q1 : ContentPage
{
    Class1 c = new Class1();
	public Q1()
	{
		InitializeComponent();
	}

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Q2());
    }

    private async void OnConfirmarClicked(object sender, EventArgs e)
    {
        if (!rbA.IsChecked && !rbB.IsChecked && !rbC.IsChecked && !rbD.IsChecked)
        {
            await DisplayAlert("Erro!", "Selecione uma resposta antes de confirmar.", "OK");
        } 
        else {
            int resposta;
            if (rbA.IsChecked) { resposta = 1; }
            else if (rbB.IsChecked) { resposta = 2; }
            else if (rbC.IsChecked) { resposta = 3; }
            else { resposta = 4; }
            bool isCorrect = c.checar(1, resposta);

            c.formatar(isCorrect, new RadioButton[] { rbA, rbB, rbC, rbD }, lblResultado, resposta);
            btnProxima.IsVisible = true;
            btnConfirmar.IsVisible = false;
        }
        
    }
}