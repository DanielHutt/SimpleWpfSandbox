namespace SimpleWpfSandbox.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            //            OneViewModels = new ObservableCollection<OneViewModel>
            //            {
            //                new OneViewModel(),
            //                new OneViewModel(),
            //                new OneViewModel(),
            //                new OneViewModel()
            //            };

            OneViewModel = new OneViewModel();
            TwoViewModel = new TwoViewModel();
            ThreeViewModel = new ThreeViewModel();
        }

        //        public ObservableCollection<OneViewModel> OneViewModels { get; }

        public ThreeViewModel ThreeViewModel { get; }

        public TwoViewModel TwoViewModel { get; }

        public OneViewModel OneViewModel { get; }

        public void DoButtonStuff()
        {
        }
    }
}
