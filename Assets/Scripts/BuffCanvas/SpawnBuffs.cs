using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBuffs : MonoBehaviour
{
    public GameObject buffCanvas;
    public Transform player;

    public void SpawnCanvas(int canvases)
    {
        Time.timeScale = 0;
        for (int i=0; i < canvases; i++)
        {
            GameObject clone = Instantiate(buffCanvas, new Vector2(player.position.x, player.position.y), Quaternion.identity);
            clone.GetComponent<Canvas>().sortingOrder = i;
        }


    }
    public void UnPauseBuffs()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("BuffCanvas");

        if (go.Length == 1)
        {
            Time.timeScale = 1;
        }
    }
}
