using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Archer
{
    private void Start()
    {
        CharName();
        Skill();
        SkillDamage();
    }
    public override void CharName()
    {
        charName = "Caitlyn";
        GameManager.instance.nameTxt.text = charName;
    }

    public override void Skill()
    {
        skillName = "Piltover Peacemaker";
        GameManager.instance.skillTxt.text = skillName;
    }

    public override void SkillDamage()
    {
        skillDmg = "Damage = 90";
        GameManager.instance.dmgTxt.text = skillDmg;
    }
}
