using UnityEditor;
using UnityEngine;

namespace MyUtils.Variable {

    [CustomPropertyDrawer(typeof(SerializeRuntimeListAttribute))]
    public class RuntimeSetDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.ObjectField(position, property.objectReferenceValue, typeof(Object), true);

            EditorGUI.EndProperty();
        }
    }
}