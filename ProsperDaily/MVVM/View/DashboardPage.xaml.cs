using ProsperDaily.MVVM.ViewModel;

namespace ProsperDaily.MVVM.View;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
		BindingContext = new DashboardViewModel();
	}

    private async void AddTransaction_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new TransactionPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (DashboardViewModel)BindingContext;
        vm.FillData();
    }
}