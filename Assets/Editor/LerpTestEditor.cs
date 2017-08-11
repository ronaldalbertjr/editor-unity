using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LerpTest))]
public class LerpTestEditor :  Editor
{
    public override void OnInspectorGUI()
    {
        LerpTest test = target as LerpTest;

        test.min = EditorGUILayout.FloatField("Minimun Value:", test.min);
        if (test.min > test.max) test.min = test.max;
        test.max = EditorGUILayout.FloatField("Maximun Value:", test.max);
        test.t = EditorGUILayout.Slider("T value:", test.t, 0f, 1f);
        EditorGUI.BeginDisabledGroup(true);
        EditorGUILayout.FloatField("Resultado:", Mathf.Lerp(test.min, test.max, test.t));
        EditorGUI.EndDisabledGroup();
    }
}
