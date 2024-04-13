using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Script References")]
    public Player player;
    public Swordsman swordsman;
    public Barbarian barbarian;
    public Gladiator gladiator;
    public Archer archer;
    public Sniper sniper;
    public Artillery artillery;

    [Header("Char Info")]
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI skillTxt;
    public TextMeshProUGUI dmgTxt;
    public GameObject startTxt;
    public GameObject infosText;

    [Header("Buttons GameObs")]
    public GameObject secondLayerButtons;
    public GameObject thirdLayerLeftButtons;
    public GameObject thirdLayerRightButtons;
    public GameObject RestartButton;

    [Header("Buttons Properties")]
    public Button playerButt;
    public Button swordButt;
    public Button archButt;
    public Button barbButt;
    public Button gladButt;
    public Button artButt;
    public Button sniperButt;

    [Header("Lines")]
    public GameObject playerToNext;
    public GameObject nextToEnd;
    public GameObject nextToEndRight;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scene");
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    public void PlayerClick()
    {
        player.CharName();
        player.Skill();
        player.SkillDamage();

        startTxt.SetActive(false);
        infosText.SetActive(true);
        playerToNext.SetActive(true);
        secondLayerButtons.SetActive(true); 
    }

    public void SwordsmanClick()
    {
        swordsman.CharName();
        swordsman.Skill();
        swordsman.SkillDamage();

        playerButt.interactable = false;
        archButt.interactable = false;
        thirdLayerLeftButtons.SetActive(true);   
        nextToEnd.SetActive(true);
    }

    public void ArcherClick()
    {
        archer.CharName();
        archer.Skill();
        archer.SkillDamage();

        playerButt.interactable = false;
        swordButt.interactable = false;
        thirdLayerRightButtons.SetActive(true);
        nextToEndRight.SetActive(true);
    }

    public void BarbarianClick()
    {
        barbarian.CharName();
        barbarian.Skill();
        barbarian.SkillDamage();

        swordButt.interactable = false;
        gladButt.interactable = false;
        RestartButton.SetActive(true);
    }

    public void GladiatorClick()
    {
        gladiator.CharName();
        gladiator.Skill();
        gladiator.SkillDamage();

        swordButt.interactable = false;
        barbButt.interactable = false;
        RestartButton.SetActive(true);
    }

    public void SniperClick()
    {
        sniper.CharName();
        sniper.Skill();
        sniper.SkillDamage();

        archButt.interactable = false;
        artButt.interactable = false;
        RestartButton.SetActive(true);
    }

    public void ArtilleryClick()
    {
        artillery.CharName();
        artillery.Skill();
        artillery.SkillDamage();

        archButt.interactable = false;
        sniperButt.interactable = false;
        RestartButton.SetActive(true);
    }

}
