using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanManager : MonoBehaviour
{
    public GameObject prefabbox;
    public Vector3 spawnPos;
    public float xPos;
    public float yPos = 10;
    public float startintervel = 0.1f;
    public float delay = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnmanager", startintervel, delay);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void spawnmanager()
    {
        spawnPos = new Vector3(Random.Range(1, 30), yPos, 0);
        Instantiate(prefabbox, spawnPos, prefabbox.transform.rotation);
    }
}
