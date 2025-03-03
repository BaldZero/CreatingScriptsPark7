using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHumanoid : Humanoid
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
