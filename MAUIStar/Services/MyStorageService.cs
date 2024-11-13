using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Services
{
    public class MyStorageService : IMyStorageService
    {
        public bool DeleteAuthToken()
        {
            return DeleteValue("AUTH_TOKEN");
        }

        public bool DeleteValue(string key)
        {
            return SecureStorage.Remove(key);
        }

        public Task<string> GetAuthToken()
        {
            return GetValue("AUTH_TOKEN");
        }

        public Task<string> GetValue(string key)
        {
            return SecureStorage.GetAsync(key);
        }

        public Task SetAuthToken(string value)
        {
            return SetValue("AUTH_TOKEN", value);
        }

        public Task SetValue(string key, string value)
        {
            return SecureStorage.SetAsync(key, value);
        }
    }
}
