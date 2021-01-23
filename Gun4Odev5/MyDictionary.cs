using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev5
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TKey[] _tempKeys;
        TValue[] _values;
        TValue[] _tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0]; // sıfır elemanlı boş dizi oluştur
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            _tempKeys = _keys; // ilk oluşan diziyi sakla
            _tempValues = _values;
            // key
            _keys = new TKey[_keys.Length + 1]; // yeni dizi oluştur

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                _keys[i] = _tempKeys[i]; // yeni oluşan dizinin başını doldur
            }
            _keys[_keys.Length - 1] = key;  // yeni oluşan dizinin son elemanı doldur

            // values
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < _tempValues.Length; i++)
            {
                _values[i] = _tempValues[i];
            }
            _values[_values.Length - 1] = value;

        }

        public TKey[] Keys
        {
            get { return _keys; }
        }
        public TValue[] Values
        {
            get { return _values; }
        }
    }
}
