using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiVoss : MonoBehaviour
{ //hp bar
    public Image hpBar;
    public float currentHp;
    public float maxHp = 10000f;

    void Update()
    {
        currentHp = FinalBossHp.bossHP;
        hpBar.fillAmount = currentHp / maxHp;
    }
}
