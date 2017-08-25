using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(NegativeAttribute))]
public class NegativeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        property.intValue = EditorGUI.IntField(position, label, property.intValue);

        if (property.intValue > -1)
            property.intValue = -1;
    }
}
