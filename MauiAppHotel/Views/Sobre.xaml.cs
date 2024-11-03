namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }
    async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
  }
