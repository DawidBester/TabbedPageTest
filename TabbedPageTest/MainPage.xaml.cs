namespace TabbedPageTest
{
    public partial class MainPage : TabbedPage
    {
      
        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                OnPropertyChanged();
          
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_OnClicked(object? sender, EventArgs e)
        {
            Counter++;
        }
        
    }

}
