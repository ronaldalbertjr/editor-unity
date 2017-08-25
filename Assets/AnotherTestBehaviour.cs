using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherTestBehaviour : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public bool canUse;
        public string name;
        public int damage;
    }
    
    [Positive]
    public int baseDamage;

    [Negative]
    public int sadness;

    public Item item1;
    public Item item2;

    private void Update()
    {
        Debug.Log(item1.name + " " + item1.damage);
        Debug.Log(item2.name + " " + item2.damage);
    }

}
