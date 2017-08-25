using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(PositiveAttribute))]
public class PositiveDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        property.intValue = EditorGUI.IntField(position, label, property.intValue);

        if (property.intValue < 0)
            property.intValue = 0;
    }
}
