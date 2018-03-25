namespace KitchenSink
{

    using Autofac;
    using Prism;
    using Prism.Autofac;
    using Prism.Ioc;
    using ViewModels;
    using ViewModels.Layouts;
    using ViewModels.Components;
    using Views;
    using Views.Layouts;
    using Views.Components;
    using Xamarin.Forms;


    public partial class App : PrismApplication
    {
        public static IContainerRegistry ContainerRegistry { get; set; }

        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }


        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(MainPage)}");
            // await NavigationService.NavigateAsync(NavigationPage/"MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ContainerRegistry = containerRegistry;
            var containerBuilder = containerRegistry.GetBuilder();
            containerBuilder.RegisterAssemblyModules(typeof(App).Assembly);
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<LayoutsPageMain, LayoutsPageMainViewModel>();
            containerRegistry.RegisterForNavigation<Views.Layouts.StackLayout, StackLayoutViewModel>();

            containerRegistry.RegisterForNavigation<ComponentsMain, ComponentsMainViewModel>();
            containerRegistry.RegisterForNavigation<Modal, ModalViewModal>();
            containerRegistry.RegisterForNavigation<ModalDetails, ModalDetailsViewModal>();

        }
    }
}