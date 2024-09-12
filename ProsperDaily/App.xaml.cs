using ProsperDaily.MVVM.Model;
using ProsperDaily.MVVM.View;
using ProsperDaily.Repositories;

namespace ProsperDaily
{
    public partial class App : Application
    {
        public static BaseRepository<Transactions> TransactionRepo { get;private set; }

        public App(BaseRepository<Transactions> _transactionsRepo)
        {
            TransactionRepo = _transactionsRepo;
            InitializeComponent();

            MainPage = new NavigationPage(new DashboardPage());
        }
    }
}
