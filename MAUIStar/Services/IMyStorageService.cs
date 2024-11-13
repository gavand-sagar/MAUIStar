using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Services
{
    public interface IMyStorageService
    {
        Task SetAuthToken(string value);
        Task<string> GetAuthToken();
        bool DeleteAuthToken();
        Task<string> GetValue(string key);
        Task SetValue(string key, string value);
        bool DeleteValue(string key);
    }
}
