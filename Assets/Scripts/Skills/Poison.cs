using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Skill
{
    public override string Name { get => "poison"; }

    public override void Activate()
    {
        Debug.Log("Poison casteado");
    }
}
