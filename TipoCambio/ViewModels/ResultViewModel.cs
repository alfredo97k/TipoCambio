using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using TipoCambio.Models;
using TipoCambio.Services;
using Xamarin.Forms;

namespace TipoCambio.ViewModels
{
    public class ResultViewModel : BaseViewModel
    {

        private ApiService apiService;
        
        private ObservableCollection<DataSerie> _dataList; 

        public ObservableCollection<DataSerie> DataList {
            get { return _dataList; } 
            set { this.SetValue(ref _dataList, value); }
        }

        private DateTime _initDate;

        public DateTime InitDate
        {
            get { return _initDate; }
            set { this.SetValue(ref _initDate, value); }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { this.SetValue(ref _endDate, value); }
        }




        public ResultViewModel()
        {
            this.apiService = new ApiService();

            SubmitCommand = new Command(() => LoadData());

            _initDate = new DateTime(2019, 11, 20);
            _endDate = DateTime.Today;
            _dataList = new ObservableCollection<DataSerie>();
        }

        private async void LoadData()
        {
            if (_initDate > _endDate)
            {
                await Application.Current.MainPage.DisplayAlert("Aviso", "La fecha de inicio no puede ser mayor que la final", "OK");
                return;
            }
            _dataList.Clear();
            var Response = await apiService.ReadSerie(_initDate.ToString("yyyy-MM-dd"), _endDate.ToString("yyyy-MM-dd"));
            var listData = new ObservableCollection<DataSerie>( Response.seriesResponse.series[0].Data);
            foreach (var item in listData)
            {
                _dataList.Add(new DataSerie { Data = item.Data, Date = item.Date });
            }
            
        }

        public ICommand SubmitCommand { get; }
    }
}
