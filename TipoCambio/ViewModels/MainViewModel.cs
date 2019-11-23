using System;
using System.Collections.Generic;
using System.Text;

namespace TipoCambio.ViewModels
{
    public class MainViewModel
    {
        public ResultViewModel ResultViewModel { get; set; }

        public MainViewModel()
        {
            this.ResultViewModel = new ResultViewModel();
        }
    }
}
