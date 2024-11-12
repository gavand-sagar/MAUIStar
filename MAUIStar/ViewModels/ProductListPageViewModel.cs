using MAUIStar.Models;
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

        public int PageSize { get; set; } = 10;

        private ObservableCollection<Product> _productsList;
        public ObservableCollection<Product> ProductsList
        {
            get { return _productsList; }
            set
            {
                _productsList = value;
                RaiseProperyChanged(nameof(_productsList));
            }
        }

        public ICommand NextCommand { get; set; }
        public ICommand PrevCommand { get; set; }


        public ProductListPageViewModel()
        {
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
            PageNumber++;
            LoadData();
        }

        private void LoadData()
        {
            using (HttpClient client = new HttpClient())
            {
                ProductListResponse response = client.GetFromJsonAsync<ProductListResponse>($"https://dummyjson.com/products?limit={PageSize}&skip={(PageNumber - 1) * PageSize}&select=title,price,id").Result;
                foreach (var item in response.Products)
                {
                    this.ProductsList.Add(item);
                }
            }
        }
    }
}
