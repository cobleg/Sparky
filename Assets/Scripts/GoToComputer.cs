using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToComputer : GAction
{
    public override bool PrePerform()
    {
        //target = inventory.FindItemWithTag("stove");
        //if (target != null) return true;
        //return false;
        return true;
    }

    public override bool PostPerform()
    {
       // GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
       // GWorld.Instance.GetQueue("stove").AddResource(this.gameObject);
        //beliefs.ModifyState("atStove", 1);

        
        return true;
    }
}
