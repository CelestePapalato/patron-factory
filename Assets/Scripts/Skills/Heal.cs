using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Skill
{
    public override string Name { get => "heal"; }

    public override void Activate()
    {
        Debug.Log("Heal casteado");
    }
}
