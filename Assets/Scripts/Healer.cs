using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : Adventurer
{

    public override void Attack()
    {
        Debug.Log("healer");
        base.Attack();
    }
}
