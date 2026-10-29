namespace KatalogMobilny;

public partial class NewProductPage : ContentPage
{
	public NewProductPage()
	{
		InitializeComponent();
	}

    private int licznik = 0;
    public NewProductPage()
    {

    }

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        licznik++;
        EtykietaWyniku.Text = $"kliknięto {licznik} razy";
    }
    // TODO ogarnij drugi guzik ktory resetuje licznik i wyswietla "kliknieto 0 razy"
}