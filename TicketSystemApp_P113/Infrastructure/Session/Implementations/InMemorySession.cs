using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemApp_P113.Models;

namespace TicketSystemApp_P113.Core
{
    public class InMemorySession : ISession
    {
        public Dictionary<string, string> _sessionKeyValues;
        public InMemorySession()
        {
            _sessionKeyValues = new Dictionary<string, string>();
        }
        public void Set<T>( string key, T value)
        {
            _sessionKeyValues[key] = JsonConvert.SerializeObject(value);
        }

        public T Get<T>(string key)
        {
            var value = _sessionKeyValues[key];

            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);
        }

        public bool Clear<T>(string key)
        {
           return _sessionKeyValues.Remove(key);
        }


    }
}
