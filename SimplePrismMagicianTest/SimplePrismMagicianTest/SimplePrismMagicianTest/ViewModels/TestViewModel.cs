using Prism.Magician;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrismMagicianTest.ViewModels
{
    public partial class TestViewModel : VmBaseReactive
    {
        [Reactive]
        public string Text { get; set; }
        [Reactive]
        public string Test { get; set; }
        public TestViewModel()
        {

        }
        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
