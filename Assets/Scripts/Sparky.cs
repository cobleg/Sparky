using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparky : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isCooked", 1, true);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("atComputer", 1, true);
        goals.Add(s2, 3);

    }

    
}
