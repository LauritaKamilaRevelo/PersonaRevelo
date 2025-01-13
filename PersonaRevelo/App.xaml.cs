namespace PersonaRevelo
{
    public partial class App : Application
    {
        public static KRPersonRepository KRPersonRepo { get; private set; }
        public App(KRPersonRepository repo)
        {
            InitializeComponent();
            KRPersonRepo = repo;

        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            return new Window(new AppShell());
        }
    }
}
