using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : Swordsman
{
    private void Start()
    {
        CharName();
        Skill();
        SkillDamage();
    }
    public override void CharName()
    {
        charName = "Garen";
        GameManager.instance.nameTxt.text = charName;
    }

    public override void Skill()
    {
        skillName = "Decisive Strike";
        GameManager.instance.skillTxt.text = skillName;
    }

    public override void SkillDamage()
    {
        skillDmg = "Damage = 60";
        GameManager.instance.dmgTxt.text = skillDmg;
    }
}
