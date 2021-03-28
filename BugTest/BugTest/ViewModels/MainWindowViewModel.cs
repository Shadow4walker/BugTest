using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using BugTest.Views;
using ReactiveUI;

namespace BugTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            SomeCommand = ReactiveCommand.Create(OnSomeCommand);
        }

        public ReactiveCommand<Unit, Unit> SomeCommand { get; }

        private protected void OnSomeCommand()
        {
            var desktop = Application.Current.ApplicationLifetime
                as IClassicDesktopStyleApplicationLifetime;
            var mainWindow = desktop?.MainWindow;
            if (mainWindow == null) throw new NullReferenceException("MainWindows is Null!");

            new SomeView().ShowDialog(mainWindow);
        }
    }
}