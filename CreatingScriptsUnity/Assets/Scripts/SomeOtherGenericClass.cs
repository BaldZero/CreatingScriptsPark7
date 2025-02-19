using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherGenericClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClassGeneric myclass = new SomeClassGeneric();
        myclass.GenericMethod<int>(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
