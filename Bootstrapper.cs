using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using ApplicationFramework.ViewModels;
using Caliburn.Micro;
namespace ApplicationFramework
{
    /// <summary>
    /// Starting Point for Application
    /// https://www.youtube.com/watch?v=laPFq3Fhs8k
    /// </summary>
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
