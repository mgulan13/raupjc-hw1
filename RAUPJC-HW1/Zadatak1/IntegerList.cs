using System;

namespace Zadatak1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        private int _size;

        public IntegerList() : this(4)
        {
        }

        public IntegerList(int initialSize)
        {
            Count = 0;
            _size = initialSize;
            _internalStorage = new int[initialSize];
        }

        public int Count { get; private set; }

        public void Add(int item)
        {
            if (Count == _size)
            {
                _size *= 2;

                int[] tempArray = new int[_size];
                _internalStorage.CopyTo(tempArray, 0);
                _internalStorage = tempArray;
            }

            _internalStorage[Count++] = item;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return RemoveAt(i);
                }
            }

            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index > _internalStorage.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index > Count)
            {
                return false;
            }

            for (int i = index; i < Count - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            Count--;
            return true;
        }
    }
}