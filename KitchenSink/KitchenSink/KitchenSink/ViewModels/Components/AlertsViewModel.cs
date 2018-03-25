namespace KitchenSink.ViewModels.Components
{
    using System.Threading.Tasks;
    using Prism.Commands;
    using Prism.Mvvm;
    using Prism.Services;

    public class AlertsViewModel : BindableBase
    {
        private readonly IPageDialogService _dialogService;

        public DelegateCommand DisplaySimpleAlertCommand { get; set; }
        public DelegateCommand DisplayActionSheetCommand { get; set; }
        public DelegateCommand DisplayDeleteActionSheetCommand { get; set; }


        public AlertsViewModel(IPageDialogService dialogService)
        {
            _dialogService = dialogService;

            DisplaySimpleAlertCommand = new DelegateCommand(async () => {
                await ExecuteDisplaySimpleAlert();
            });

            DisplayActionSheetCommand = new DelegateCommand(async () => {
                await ExecuteDisplayActionSheetCommand();
            });

            DisplayDeleteActionSheetCommand = new DelegateCommand(async () => {
                await ExecuteDisplayDeleteActionSheetCommand();
            });
        }

        private async Task ExecuteDisplaySimpleAlert() {
            await _dialogService.DisplayAlertAsync("Title", "Message", "Accept", "Cancel");
        }


        private async Task ExecuteDisplayActionSheetCommand() {
            await _dialogService.DisplayActionSheetAsync("Action Sheet: Send to?", "Cancel", null, "Option 1", "Option 2", "Option 3");     
        }

        private async Task ExecuteDisplayDeleteActionSheetCommand() {
            await _dialogService.DisplayActionSheetAsync(null, "Cancel", "Delete", "Other Option");
        }
    }
}