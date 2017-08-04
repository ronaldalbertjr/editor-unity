using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Transform lookAtTarget;
    [HideInInspector]
    public float volume;
    [HideInInspector]
    public int propriedade;
    [HideInInspector]
    public string texto;
    [HideInInspector]
    public string textao;
    [HideInInspector] public int[] oi;


    public void DoSomething()
    {
        Debug.Log("eai");
        transform.localPosition = Vector3.zero;
        transform.LookAt(lookAtTarget);
    }
}
