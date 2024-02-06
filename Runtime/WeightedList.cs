using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WeightedList
{
    [System.Serializable]
    public class WeightedList<T> : ICollection<WeightedElement<T>>
    {
        [SerializeField] private List<WeightedElement<T>> elements;

        public WeightedList() { elements = new List<WeightedElement<T>>(); }

        public T GetRandomElement()
        {
            int totalWeight = 0;
            foreach (var element in elements)
            {
                totalWeight += element.weight;
            }

            float random = Random.value;

            for (int i = 0; i < elements.Count; i++)
            {
                float ratio = elements[i].weight / (float)totalWeight;

                if (random < ratio)
                {
                    return elements[i].element;
                }

                random -= ratio;
            }

            return elements.Last().element;
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