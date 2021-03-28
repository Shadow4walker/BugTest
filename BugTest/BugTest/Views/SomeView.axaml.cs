using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BugTest.Views
{
    public class SomeView : Window
    {
        public SomeView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
