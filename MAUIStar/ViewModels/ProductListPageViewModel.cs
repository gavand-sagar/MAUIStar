using MAUIStar.Models;
using MAUIStar.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIStar.ViewModels
{
    public class ProductListPageViewModel : BaseViewModel
    {
        private int _pageNumber;
        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                _pageNumber = value;
                RaiseProperyChanged(nameof(PageNumber));
            }
        }

        public bool PrevButtonVisible
        {
            get
            {
                return PageNumber > 1;
            }
        }

#if WINDOWS
        public int PageSize { get; set; } = 20;
#else
        public int PageSize { get; set; } = 10;
#endif
        public int TotalItems { get; set; } = 0;

        private ObservableCollection<Product> _productsList;
        public ObservableCollection<Product> ProductsList
        {
            get { return _productsList; }
            set
            {
                _productsList = value;
                RaiseProperyChanged(nameof(ProductsList));
            }
        }

        private string token;
        public string Token { get { return token; } set { token = value; RaiseProperyChanged(nameof(Token)); } }

        IMyStorageService _storageService;
        public ICommand NextCommand { get; set; }
        public ICommand PrevCommand { get; set; }

        IDialogService _dialogService;

        public ProductListPageViewModel(IDialogService dialogService, IMyStorageService storageService)
        {
            _storageService = storageService;
            Token = storageService.GetAuthToken().Result;
            _dialogService = dialogService;
            PageNumber = 1;
            ProductsList = new ObservableCollection<Product>();
            NextCommand = new CommonCommand(NextClicked);
            PrevCommand = new CommonCommand(PrevClicked);
            LoadData();
        }

        private void PrevClicked(object obj)
        {
            if (PageNumber > 1)
            {
                PageNumber--;
                LoadData();
            }
        }

        private void NextClicked(object obj)
        {
#if ANDROID
            if (ProductsList.Count() < TotalItems)
            {
#else
            if (ProductsList.Count() < TotalItems)
            {
#endif
                PageNumber++;
                LoadData();
            }
        }

        private void LoadData()
        {
            //using (HttpClient client = new HttpClient())
            //{
            //    ProductListResponse response = client.GetFromJsonAsync<ProductListResponse>($"https://dummyjson.com/products?limit={PageSize}&skip={(PageNumber - 1) * PageSize}&select=title,price,id").Result;
            //    TotalItems = response.Total;
            //    foreach (var item in response.Products)
            //    {
            //        this.ProductsList.Add(item);
            //    }
            //}
        }
    }
}
