using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TipoCambio.ViewModels;

namespace TipoCambio.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }

        
    }
}
