using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
   public Text nameText;
   public Text LevelText;
   public Slider hpSliders;
   public void SetHUD(Unit unit) 
   {
    nameText.text = unit.unitName;
    LevelText.text = "Lvl" + unit.unitLevel;
    hpSliders.maxValue = unit.maxHP;
    hpSliders.value = unit.currentHP;
   }
   public void SetHP(int hp)
   {
    hpSliders.value = hp;
   }

}
