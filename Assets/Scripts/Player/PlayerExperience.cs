using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExperience : MonoBehaviour
{
    public int exp = 0;
    public int level = 0;
    public int newLvl = 5;

    public void GivetExp(int newExp)
    {
        exp += newExp;

        if (exp >= newLvl)
        {
            level += 1;
            exp -= newLvl;
            newLvl *= 2;
            gameObject.GetComponent<Buffs>().RandomBuff();
        }
    }
}
