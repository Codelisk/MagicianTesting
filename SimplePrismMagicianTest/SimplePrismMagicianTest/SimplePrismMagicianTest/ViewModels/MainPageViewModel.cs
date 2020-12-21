using Prism.Commands;
using Prism.Magician;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrismMagicianTest.ViewModels
{
    public partial class MainPageViewModel : VmBaseReactive
    {
        [Reactive]
        public string Test { get; set; }
        public MainPageViewModel(INavigationService navigationService)
            : base()
        {
            Title = "Main Page";
            Task.Run(async() =>
            {
                while (true)
                {
                    await Task.Delay(2000);
                    Test = RandomString(10);
                }
            });
        }
        private  Random random = new Random();
        public  string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
