using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace WeightedList
{
    [CustomPropertyDrawer(typeof(WeightedList<>))]
    public class WeightedListPropertyDrawer : PropertyDrawer
    {
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            VisualElement container = new VisualElement();

            PropertyField elements = new PropertyField(property.FindPropertyRelative("elements"), property.displayName);

            container.Add(elements);

            return container;
        }
    }
}