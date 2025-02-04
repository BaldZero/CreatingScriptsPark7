using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreatingProperties myProps = new CreatingProperties();

        myProps.Experience = 5;
        int x = myProps.Experience;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
