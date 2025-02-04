using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingProperties : MonoBehaviour
{
    // Start is called before the first frame update
    private int experience;

    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
