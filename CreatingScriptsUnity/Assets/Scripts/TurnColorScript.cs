using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        EventManager.OnClicked += TurnColor;
    }

    void OnDiable()
    {
        EventManager.OnClicked -= TurnColor;
    }

    void TurnColor()
    {
        Color col = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = col;
    }
}
