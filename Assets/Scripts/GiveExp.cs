using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveExp : MonoBehaviour
{
    public int expPoints = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerExperience experience = collision.gameObject.GetComponent<PlayerExperience>();
            experience.GivetExp(expPoints);

            ExpBar expBar = GameObject.FindGameObjectWithTag("ExpBar").GetComponent<ExpBar>();

            expBar.SetExp(experience.exp, experience.newLvl);
        }
        Destroy(gameObject);
    }
}
