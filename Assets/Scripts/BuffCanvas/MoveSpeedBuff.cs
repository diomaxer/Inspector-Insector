using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSpeedBuff : MonoBehaviour
{
    public Button upMoveSpeed;
    public void UpMoveSpeed()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().moveSpeed *= 1.1f;
        Destroy(gameObject.transform.parent.root.gameObject);
        GameObject.FindGameObjectWithTag("Event").GetComponent<SpawnBuffs>().UnPauseBuffs();
    }
}
