using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryDemo
{
    public class MyDictionary<TKeys, TValues>
    {
        TKeys[] _tKeys;
        TValues[] _tValues;
        TKeys[] _tempTKeys;
        TValues[] _tempTValues;
        public MyDictionary()
        {
            _tKeys = new TKeys[0];
            _tValues = new TValues[0];
        }
        public void Add(TKeys key , TValues value)
        {
            _tempTKeys = _tKeys;
            _tempTValues = _tValues;
            _tKeys = new TKeys[_tKeys.Length + 1];
            _tValues = new TValues[_tValues.Length + 1];
            for(int i =0;i<_tempTKeys.Length;i++)
            {
                _tKeys[i] = _tempTKeys[i];
                _tValues[i] = _tempTValues[i];

            }
            _tKeys[_tKeys.Length - 1] = key;
            _tValues[_tValues.Length - 1] = value;
        }

       
        public int Count {
            get
            {
                return _tKeys.Length;
            } 
        
        }
     
        public void GetAll()
        {
            for(int i=0;i<_tKeys.Length;i++)
            {
                Console.WriteLine(_tKeys[i]+" : "+ _tValues[i]);
            }
        }
      


    }
}
