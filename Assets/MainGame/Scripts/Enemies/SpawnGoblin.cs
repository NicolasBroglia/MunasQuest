using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoblin : MonoBehaviour
{
    public GameObject GoblinPrefab;
    public GameObject GoblinPrefab2;
    public GameObject GoblinPrefab3;
    public GameObject GoblinPrefab4;

    //spawn Goblins
    private void Update()
    {
        if (FinalBossHp.bossHP >= 5000f)
        {
            GoblinPrefab.SetActive(false);
            GoblinPrefab2.SetActive(false);
            GoblinPrefab3.SetActive(false);
            GoblinPrefab4.SetActive(false);
        }
        if (FinalBossHp.bossHP <= 5000f)
        {
            GoblinPrefab.SetActive(true);
            GoblinPrefab2.SetActive(true);
            GoblinPrefab3.SetActive(true);
            GoblinPrefab4.SetActive(true);
        }
    }

}
