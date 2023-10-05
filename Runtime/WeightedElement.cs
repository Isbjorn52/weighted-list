namespace WeightedList
{
    [System.Serializable]
    public struct WeightedElement<T>
    {
        public T element;
        public int weight;

        public WeightedElement(T element)
        {
            this.element = element;
            this.weight = 1;
        }

        public WeightedElement(T element, int weight)
        {
            this.element = element;
            this.weight = weight;
        }
    }
}