namespace KitchenSink.ViewModels.Components
{
    using System;
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Navigation;

    public class ModalDetailsViewModal : BindableBase
    {
        private readonly INavigationService _navigationService; 

        public DelegateCommand DismissModalCommand { get; set; }

        public ModalDetailsViewModal(INavigationService navigationService)
        {
            _navigationService = navigationService;

            DismissModalCommand = new DelegateCommand(ExecuteDismissModalCommand);

        }

        private void ExecuteDismissModalCommand()
        {
            _navigationService.GoBackAsync();
        }
    }
}
