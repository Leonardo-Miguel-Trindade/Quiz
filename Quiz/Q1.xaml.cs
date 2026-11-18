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

    private void OnConfirmarClicked(object sender, EventArgs e)
    {
        bool isCorrect = c.checar(1, 2);
        c.formatar(isCorrect, new RadioButton[] { rbA, rbB, rbC, rbD }, lblResultado);  

        if (rbC.IsChecked)
        {
            c.adicionar();
            

            lblResultado.Text = "Correta!";
            lblResultado.TextColor = Colors.Green;

            rbA.IsEnabled = false;
            rbB.IsEnabled = false;
            rbC.IsEnabled = false;
            rbD.IsEnabled = false;

            btnProxima.IsVisible = true;
        }
        else
        {
            rbA.TextColor = Colors.Red;
            rbB.TextColor = Colors.Red;
            rbC.TextColor = Colors.Green;
            rbD.TextColor = Colors.Red;

            lblResultado.Text = "Errada!";
            lblResultado.TextColor = Colors.Red;
            rbA.IsEnabled = false;
            rbB.IsEnabled = false;
            rbC.IsEnabled = false;
            rbD.IsEnabled = false;
            btnProxima.IsVisible = true;
        }
    }
}