using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxHealthBuff : MonoBehaviour
{
    public Button upMaxHealth;
    public void UpMaxHealth()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().maxHealth += 20f;
        Destroy(gameObject.transform.parent.root.gameObject);
        GameObject.FindGameObjectWithTag("Event").GetComponent<SpawnBuffs>().UnPauseBuffs();
    }
}
