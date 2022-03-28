using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExperience : MonoBehaviour
{
    public int exp;
    public int level;
    public int newLvl;
    private int canvases = 0;

    private void Start()
    {
        exp = gameObject.GetComponent<PlayerMovement>().exp;
        level = gameObject.GetComponent<PlayerMovement>().level;
        newLvl = gameObject.GetComponent<PlayerMovement>().newLvl;
    }

    public void GivetExp(int newExp)
    {
        exp += newExp;
        //exp += 205;

        while (exp >= newLvl)
        {
            level += 1;
            exp -= newLvl;
            newLvl *= 2;
            canvases++;
        }
        if (canvases > 0)
        {
            GameObject.FindGameObjectWithTag("Event").GetComponent<SpawnBuffs>().SpawnCanvas(canvases);
        }
        canvases = 0;
    }
}
