using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitOverride : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public FruitOverride()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit");
    }

}
