namespace WanderEjerRepaso.Views;

public partial class WF_Conteo : ContentPage
{
	public WF_Conteo()
	{
		InitializeComponent();
        BindingContext = new Models.Conteo();
    }

    private void TextEditor_TextChanged(object sender, TextChangedEventArgs e)
    {
        Models.Conteo viewModel = (Models.Conteo)BindingContext;

        // Actualizar estadísticas aquí
        string text = e.NewTextValue;

        viewModel.Numeros = text.Count(char.IsDigit);
        viewModel.Letras = text.Count(char.IsLetter);
        viewModel.Vocales = text.Count(c => "AEIOUaeiou".Contains(c));
        viewModel.Mayusculas = text.Count(char.IsUpper);
        viewModel.Minusculas = text.Count(char.IsLower);
        viewModel.Total = text.Length;
    }


}
