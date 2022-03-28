using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffsDescription : MonoBehaviour
{
    public GameObject parenCanvas;
    public GameObject[] buffPrefubs;
    private GameObject[] buffs;

    void Start()
    {
        int y = 3;
        buffs = RandomElem(buffPrefubs);
        for (int i = 0; i < 3; i++)
        {
            GameObject button = Instantiate(buffs[i], new Vector2(transform.position.x, transform.position.y + y), Quaternion.identity);
            button.transform.SetParent(parenCanvas.transform, true);
            y -= 3;
        }
    }

    private GameObject[] RandomElem(GameObject[] array)
    {
        for (int i = 0; i < 3; i++)
        {
            int rand = Random.Range(i, array.Length);
            GameObject change = array[i];
            array[i] = array[rand];
            array[rand] = change;
        }
        return array;
    }
}
 