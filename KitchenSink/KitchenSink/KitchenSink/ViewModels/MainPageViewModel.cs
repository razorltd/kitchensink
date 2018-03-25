namespace KitchenSink.ViewModels
{
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Navigation;

    public class MainPageViewModel : BindableBase {
      
        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateLayoutCommand { get; set;  }
        public DelegateCommand NavigateComponentCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService) 
        {
            _navigationService = navigationService;

            NavigateLayoutCommand = new DelegateCommand(ExecuteNavigateLayout);
            NavigateComponentCommand = new DelegateCommand(ExecuteNavigateComponenets);    
        }

        void ExecuteNavigateLayout()
        {
            _navigationService.NavigateAsync("LayoutsPageMain");

        }
 

        void ExecuteNavigateComponenets()
        {
            _navigationService.NavigateAsync("ComponentsMain");
        }

    } 

}

