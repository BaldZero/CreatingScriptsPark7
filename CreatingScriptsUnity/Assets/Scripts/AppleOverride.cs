using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleOverride : FruitOverride
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public AppleOverride()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple");
    }

}
