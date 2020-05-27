using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject Pltfrm;
    public Vector3 spawnValues;
    public float spawnWait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PltSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PltSpawner()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 0, 0);

            Instantiate(Pltfrm, spawnPosition + transform.TransformPoint(0, 0, 0), Pltfrm.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
