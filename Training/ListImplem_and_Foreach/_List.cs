using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class _List:IEnumerable
    {
        private int _capacity = 0;
        private const int _defaultCapacity = 4;
        private int[] _items;
        private int[] _temp;
        private int _size;

        public int Count { get => _size; }


        public int this[int i]
        {
            get 
            {
                if(i>= _size)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return _items[i];
                }
                
            }
            set 
            {
                if (i >= _size)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    _items[i] = value;
                    //_size++;
                }
            }
        }
        public _List(int capacity)
        {
            _capacity = capacity;
            _items = new int[capacity]; 
        }
        public _List()
        {

        }
        public void Add(int value)
        {
            EnsureCapacity();
            _items[_size++] = value;
        }
        public override string ToString()
        {
            return $"Count = {Count}";
        }
        private void EnsureCapacity()
        {
            if(_capacity == 0)
            {
                _capacity = _defaultCapacity;
                _items = new int[_capacity];
            }
            if (_size >= _capacity)
            {
                _capacity *= 2;
                _temp = new int[_items.Length];
                for (int i = 0; i < _temp.Length; i++)
                {
                    _temp[i] = _items[i];
                }
                _items = new int[_capacity];
                for (int i = 0; i < _temp.Length; i++)
                {
                    _items[i] = _temp[i];
                }
                _temp = null;
            }
        }

        public _ListEnumerator GetEnumerator()
        {
            return new _ListEnumerator(_items,_size);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class _ListEnumerator
        {
            private int[] _items;
            private int _size;
            private int count = 0;
            public _ListEnumerator(int[] items,int size)
            {
                _items = items;
                _size = size;
            }
            public object Current { get=>_items[count++]; }
            public bool MoveNext() 
            {
                
                return count< _size; 
            }
        }
        


    }
}
