using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smasher : MonoBehaviour
{
    BoxCollider collider;
    void Awake()
    {
        collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTriggerCol()
    {
        collider.isTrigger = true;
    }

    public void DesTriggerCol()
    {
        collider.isTrigger = false;
    }
}
