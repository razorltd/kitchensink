namespace KitchenSink.ViewModels.Components
{
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Navigation;

    public class ModalViewModal : BindableBase
    {

        private readonly INavigationService _navigationService; 

        public DelegateCommand DisplayModelCommand { get; set; }

        public ModalViewModal(INavigationService navigationService)
        {
            _navigationService = navigationService;

            DisplayModelCommand = new DelegateCommand(ExecuteDisplayModelCommand);
        }

        void ExecuteDisplayModelCommand()
        {
            _navigationService.NavigateAsync("ModalDetails", useModalNavigation:true, animated:true  );

        }
 
    }
}
