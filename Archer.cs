using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Player
{
    private void Start()
    {
        CharName();
        Skill();
        SkillDamage();
    }
    public override void CharName()
    {
        charName = "Ashe";
        GameManager.instance.nameTxt.text = charName;
    }

    public override void Skill()
    {
        skillName = "Volley";
        GameManager.instance.skillTxt.text = skillName;
    }

    public override void SkillDamage()
    {
        skillDmg = "Damage = 50";
        GameManager.instance.dmgTxt.text = skillDmg;
    }
}
