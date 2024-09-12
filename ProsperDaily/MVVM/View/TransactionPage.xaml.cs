using ProsperDaily.MVVM.ViewModel;

namespace ProsperDaily.MVVM.View;

public partial class TransactionPage : ContentPage
{
	public TransactionPage()
	{
		InitializeComponent();

		BindingContext = new TransactionViewModel();
	}

    private async void Save_Clicked(object sender, EventArgs e)
    {
        var currentVM = (TransactionViewModel)BindingContext;
        var message = currentVM.SaveTransactions();
        await DisplayAlert("Info", message, "OK");

        await Navigation.PopToRootAsync();
    }

    private async void Cancel_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}