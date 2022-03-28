using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackBuff : MonoBehaviour
{
    public Button upAttack;
    public void UpAttack()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().damage += 5;
        Destroy(gameObject.transform.parent.root.gameObject);
        GameObject.FindGameObjectWithTag("Event").GetComponent<SpawnBuffs>().UnPauseBuffs();
    }
}
