namespace DynamicBlazorForm.Core.Layout
{
    public class DataConnection
    {
        private Dictionary<string, object> results = new Dictionary<string, object>();

        public event EventHandler Changed;

        public object this[string index]
        {
            get
            {
                return results[index];
            }
            set
            {
                results[index] = value;
            }
        }

        public void Clear()
        {
            results.Clear();
            RaiseChangedEvent();
        }

        private void RaiseChangedEvent()
        {
                Changed?.Invoke(this, EventArgs.Empty);
          
        }

        public bool ContainsKey(string key)
        {
            return results.ContainsKey(key);
        }

        public void Upsert(string key, object data)
        {
            if (results.ContainsKey(key))
            {
                results[key] = data;
            }
            else
            {
                results.Add(key, data);
            }
            RaiseChangedEvent();
        }


        public List<KeyValuePair<string, object>>  ToList()
        {
            return results.ToList();
         }
    }
}
