using MAUIStar.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MAUIStar.ViewModels
{
    public class PhotosListViewModel : INotifyPropertyChanged
    {
        private HttpClient _httpClient;
        private string _myName;

        public string MyName
        {
            get { return _myName; }
            set
            {
                _myName = value;
                RaiseProperyChanged(nameof(MyName));
            }
        }


        private ObservableCollection<MyFile> _images;

        public event PropertyChangedEventHandler PropertyChanged;

        void RaiseProperyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public ObservableCollection<MyFile> Images
        {
            get { return _images; }
            set
            {
                _images = value;
                RaiseProperyChanged(nameof(Images));
            }
        }


        public PhotosListViewModel()
        {
            _httpClient = new HttpClient();
            DeleteCommond = new CommonCommand(DeleteImage);
            UploadFromFiles = new CommonCommand(OnUploadFromFiles);

            // call an api "https://dummyjson.com/products";
            var result = _httpClient.GetFromJsonAsync<List<MyFile>>("https://tempfileserver.onrender.com/files").Result;
            if (result != null)
            {
                this.Images = new ObservableCollection<MyFile>(result.Take(5).ToList());
            }
        }

        private async void OnUploadFromFiles(object obj)
        {
            var file = await MediaPicker.CapturePhotoAsync();
            if (file != null)
            {
                var fromDataObj = new MultipartFormDataContent();
                var stream = await file.OpenReadAsync();
                fromDataObj.Add(new StreamContent(stream), "file", file.FileName);
                var response = await this._httpClient.PostAsync("https://tempfileserver.onrender.com/upload", fromDataObj);
                if (response != null)
                {
                    string responseContent = response.Content.ReadAsStringAsync().Result;
                    MyFile newFile = JsonSerializer.Deserialize<MyFile>(responseContent);
                    Images.Add(newFile);                   
                }
            }
        }

        private async void DeleteImage(object obj)
        {
            MyFile myFile = (MyFile)obj;
            await _httpClient.DeleteAsync($"https://tempfileserver.onrender.com/files/{myFile._id}");
            this._images.Remove(myFile);
        }

        public CommonCommand DeleteCommond { get; set; }
        public CommonCommand UploadFromFiles { get; set; }



    }
}
