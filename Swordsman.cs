using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Player
{
    private void Start()
    {
        CharName();
        Skill();
        SkillDamage();
    }
    public override void CharName()
    {
        charName = "Master Yi";
        GameManager.instance.nameTxt.text = charName;
    }

    public override void Skill()
    {
        skillName = "Alpha Strike";
        GameManager.instance.skillTxt.text = skillName;
    }

    public override void SkillDamage()
    {
        skillDmg = "Damage = 60";
        GameManager.instance.dmgTxt.text = skillDmg;
    }
}
