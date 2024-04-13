using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string charName;
    public string skillName;
    public string skillDmg;

    private void Start()
    {
        CharName();
        Skill();
        SkillDamage();     
    }
    public virtual void CharName()
    {
        charName = "Vince";
        GameManager.instance.nameTxt.text = charName;
    }

    public virtual void Skill()
    {
        skillName = "HeadButt";
        GameManager.instance.skillTxt.text = skillName;
    }

    public virtual void SkillDamage() 
    {
        skillDmg = "Damage = 99";
        GameManager.instance.dmgTxt.text = skillDmg;    
    }
}
