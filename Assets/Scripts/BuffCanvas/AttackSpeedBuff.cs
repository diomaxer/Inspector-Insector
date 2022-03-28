using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackSpeedBuff : MonoBehaviour
{
    public Button upAttackSpeed;
    public void UpAttackSpeed()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().cooldown /= 1.2f;
        Destroy(gameObject.transform.parent.root.gameObject);
        GameObject.FindGameObjectWithTag("Event").GetComponent<SpawnBuffs>().UnPauseBuffs();
    }
}
