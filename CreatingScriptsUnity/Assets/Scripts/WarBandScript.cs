using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new EnemyHumanoid();
        Humanoid orc = new OrcScript();

        //each Humanoid calls a different class but each call the Humanoid class version of Yell()

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
