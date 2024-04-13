using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artillery : Archer
{
    private void Start()
    {
        CharName();
        Skill();
        SkillDamage();
    }
    public override void CharName()
    {
        charName = "Xerath";
        GameManager.instance.nameTxt.text = charName;
    }

    public override void Skill()
    {
        skillName = "Arcanopulse";
        GameManager.instance.skillTxt.text = skillName;
    }

    public override void SkillDamage()
    {
        skillDmg = "Damage = 110";
        GameManager.instance.dmgTxt.text = skillDmg;
    }
}
