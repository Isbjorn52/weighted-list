using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeightedList
{
    [System.Serializable]
    public class WeightedList<T> : ICollection<WeightedElement<T>>
    {
        private List<WeightedElement<T>> elements;

        public WeightedList() { }

        public T GetRandomElement()
        {
            List<int> temp = new List<int>();

            for (int i = 0; i < elements.Count; i++)
            {
                for (int j = 0; j < elements[i].weight; j++)
                {
                    temp.Add(i);
                }
            }

            int index = temp[Random.Range(0, temp.Count)];

            return elements[index].element;
        }

        public int Count => elements.Count;

        public bool IsReadOnly => false;

        public WeightedElement<T> this[int index] { get => elements[index]; set => elements[index] = value; }

        public void Add(WeightedElement<T> item)
        {
            elements.Add(item);
        }

        public void Clear()
        {
            elements.Clear();
        }

        public bool Contains(WeightedElement<T> item)
        {
            return elements.Contains(item);
        }

        public void CopyTo(WeightedElement<T>[] array, int arrayIndex)
        {
            elements.CopyTo(array, arrayIndex);
        }

        public IEnumerator<WeightedElement<T>> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        public bool Remove(WeightedElement<T> item)
        {
            return elements.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }
    }
}