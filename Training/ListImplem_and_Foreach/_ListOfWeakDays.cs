using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class _ListOfWeakDays : IEnumerable
    {
        
        private string[] _items = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public int this[string val]
        {
            get
            {
                for (int i = 0; i < _items.Length; i++)
                {
                    if (val == _items[i])
                    {
                        return i;
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public _Listenumerator GetEnumerator()
        {
            return new _Listenumerator(_items);
        }


        /************************* The standart shuld be ************************************/
        //public class _Listenumerator
        //{
        //    private int count = 0;
        //    private string[] _items;

        //    public _Listenumerator(string[] items)
        //    {
        //        _items = items;
        //    }

        //    public object Current { get => _items[count++]; }
        //    public bool MoveNext()
        //    {
        //        return count < _items.Length;
        //    }
        //}
        /************************* Another Type ************************************/
        public class _Listenumerator
        {
            private int count = 0;
            private string[] _items;

            public _Listenumerator(string[] items)
            {
                _items = items;
            }

            public object Current { get =>$"{1 + count}) {_items[count++]}"; }
            public bool MoveNext()
            {
                return count < _items.Length;
            }
        }
    }
}
