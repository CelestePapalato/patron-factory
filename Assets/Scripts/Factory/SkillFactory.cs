using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    [SerializeField] Skill[] skills;

    Dictionary<string, Skill> skillsKey;

    private void Awake()
    {
        InitializeDictionary();
    }

    private void InitializeDictionary()
    {
        skillsKey = new Dictionary<string, Skill>();
        foreach (Skill skill in skills)
        {
            skillsKey.Add(skill.Name, skill);
        }
    }

    public Skill CreateSkill(string skillName, Transform position)
    {
        Skill skill;
        Skill instance = null;
        if(skillsKey.TryGetValue(skillName, out skill))
        {
            instance = Instantiate(skill, position.position, position.rotation);
        }
        return instance;
    }
}
