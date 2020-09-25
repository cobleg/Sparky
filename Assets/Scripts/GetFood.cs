using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFood : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        //GWorld.Instance.GetWorld().ModifyState("Waiting", 1);
        //GWorld.Instance.GetQueue("sparky").AddResource(this.gameObject);
       // beliefs.ModifyState("atFridge", 1);
        return true;
    }
}
