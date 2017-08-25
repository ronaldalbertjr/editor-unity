using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(AnotherTestBehaviour.Item))]
public class ItemDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var canUseProp = property.FindPropertyRelative("canUse");
        var nameProp = property.FindPropertyRelative("name");
        var damageProp = property.FindPropertyRelative("damage");

        EditorGUIUtility.labelWidth = 48;
        Rect nameRect = new Rect(position.x, position.y, position.width - 200, position.height);
        EditorGUI.PropertyField(nameRect, nameProp, label);

        EditorGUI.LabelField(new Rect(nameRect.xMax, position.y, 75, position.height),"Pode Usar:");
        Rect canUseRect = new Rect(nameRect.xMax + 75 , position.y, 25, position.height);
        EditorGUI.PropertyField(canUseRect, canUseProp, GUIContent.none);

        EditorGUI.LabelField(new Rect(canUseRect.position.x + canUseRect.width, position.y, 50, position.height), "Dano:");
        Rect damageRect = new Rect(canUseRect.position.x + canUseRect.width + 50, position.y, 50, position.height);
        EditorGUI.PropertyField(damageRect, damageProp, GUIContent.none);


    }
}
