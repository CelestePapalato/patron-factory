using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    public static SkillFactory Instance;

    [SerializeField] Skill[] skills;

    Dictionary<string, Skill> skillsKey;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
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
        if (skillsKey.TryGetValue(skillName, out skill))
        {
            instance = Instantiate(skill, position.position, position.rotation);
        }
        else
        {
            Debug.LogWarning($"La habilidad {skillName} no existe en la base de datos.");
        }
        return instance;
    }
}
