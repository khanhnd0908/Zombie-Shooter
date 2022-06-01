using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> items;
    [SerializeField] List<Vector3> positions;
    float timeToSpawn;
    void Update() {
        timeToSpawn += Time.deltaTime;
        if (timeToSpawn > 10)
        {
            timeToSpawn = 0;
            int rndItm = Random.Range(0, 3);
            int rndPos = Random.Range(0, 5);
            GameObject itm = Instantiate(items[rndItm]);
            itm.GetComponent<Transform>().position = positions[rndPos];
        }
    }
}
