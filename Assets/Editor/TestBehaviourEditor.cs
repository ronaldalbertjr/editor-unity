using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(TestBehaviour))]
public class TestBehaviourEditor : Editor
{
    int arraySize;
    int[] tempArray;
    bool showPosition = true;
    public override void OnInspectorGUI()
    {
       // base.OnInspectorGUI();
        TestBehaviour testBehaviour = target as TestBehaviour;
        showPosition = EditorGUILayout.Foldout(showPosition, "Array");
        if (showPosition)
        {
            arraySize = EditorGUILayout.IntField("Array Size", arraySize);
            if (arraySize != 0)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    testBehaviour.oi[i] = EditorGUILayout.IntField("Array Element " + i.ToString(), testBehaviour.oi[i]);
                }
            }
        }
        /*
        EditorGUILayout.LabelField("eu odeio minha vida e eu sou um lixo", EditorStyles.boldLabel);
        testBehaviour.propriedade = EditorGUILayout.IntField("quanto eu me odeio", testBehaviour.propriedade);
        testBehaviour.texto = EditorGUILayout.TextField("o ronald é um ", testBehaviour.texto);
        testBehaviour.volume = EditorGUILayout.Slider("quantidade de merda", testBehaviour.volume, 0.0f, 1.0f);
        testBehaviour.textao = EditorGUILayout.TextArea(testBehaviour.textao);
        testBehaviour.lookAtTarget = EditorGUILayout.ObjectField("target", testBehaviour.lookAtTarget, typeof(Transform), true) as Transform;
        if(GUILayout.Button("aperta ou não sei lá eu tb não me importo"))
        {
            testBehaviour.DoSomething();
        }*/
    }
}