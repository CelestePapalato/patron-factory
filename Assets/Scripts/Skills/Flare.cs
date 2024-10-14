using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flare : Skill
{
    public override string Name { get => "flare"; }

    public override void Activate()
    {
        Debug.Log("Flare casteado");
    }
}
