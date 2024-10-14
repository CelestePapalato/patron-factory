using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    public abstract string Name { get; }
    public abstract void Activate();

}
