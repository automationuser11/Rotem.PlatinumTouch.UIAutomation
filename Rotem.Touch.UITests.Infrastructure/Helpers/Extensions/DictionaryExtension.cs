using System;
using System.Collections.Generic;
using Rotem.Touch.UITests.Infrastructure.Helpers.Interfaces;

namespace Rotem.Touch.UITests.Infrastructure.Helpers.Extensions
{
    public static class DictionaryExtension
    {
        public static List<ITableColumn> Get<T>(this IDictionary<Type, List<ITableColumn>> dictionary, T key)
            where T : IPageObject
        {
            return dictionary[key.GetType()];
        }

        public static bool TryGet<T>(this IDictionary<string, object> dictionary, string key, out T value)
        {
            object result;
            if (dictionary.TryGetValue(key, out result) && result is T)
            {
                value = (T)result;
                return true;
            }
            value = default(T);
            return false;
        }

        public static void Set(this IDictionary<string, object> dictionary, string key, object value)
        {
            dictionary[key] = value;
        }

    }

    public class TypeSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private readonly object _syncRoot = new object();
        private Dictionary<TKey, TValue> d = new Dictionary<TKey, TValue>();

        #region IDictionary<TKey,TValueMembers>

        public void Add(TKey key, TValue value)
        {
            lock (this._syncRoot)
            {
                d.Add(key, value);
            }
        }

        public bool ContainsKey(TKey key)
        {
            return d.ContainsKey(key);
        }

        public ICollection<TKey> Keys
        {
            get
            {
                lock (this._syncRoot)
                {
                    return d.Keys;
                }
            }
        }
        public bool Remove(TKey key)
        {
            lock (this._syncRoot)
            {
                return d.Remove(key);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            lock (this._syncRoot)
            {
                return d.TryGetValue(key, out value);
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                lock (this._syncRoot)
                {
                    return d.Values;
                }
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                return d[key];
            }
            set
            {
                lock (this._syncRoot)
                {
                    d[key] = value;
                }
            }
        }

        #endregion

        #region ICollection<KeyValuePair<TKey,TValue>Members

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            lock (this._syncRoot)
            {
                ((ICollection<KeyValuePair<TKey, TValue>>)d).Add(item);
            }
        }

        public void Clear()
        {
            lock (this._syncRoot)
            {
                d.Clear();
            }
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)d).Contains(item);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            lock (this._syncRoot)
            {
                ((ICollection<KeyValuePair<TKey, TValue>>)d).CopyTo(array, arrayIndex);
            }
        }

        public int Count
        {
            get
            {
                return d.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            lock (this._syncRoot)
            {
                return ((ICollection<KeyValuePair<TKey, TValue>>)d).Remove(item);
            }
        }

        #endregion

        #region IEnumerable<KeyValuePair<TKey,TValue>Members

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)d).GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((System.Collections.IEnumerable)d).GetEnumerator();
        }

        #endregion
    }
}
