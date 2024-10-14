using UnityEngine;

public class SkillCaster : MonoBehaviour
{
    public void Cast(string skillName)
    {
        Skill instance = SkillFactory.Instance?.CreateSkill(skillName, transform);
        instance?.Activate();
    }
}
