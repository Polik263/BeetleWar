using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] cloudReference;

    private GameObject spawnedClouds;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {

        while (true)
        {

            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, cloudReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedClouds = Instantiate(cloudReference[randomIndex]);

            // left side
            if (randomSide == 0)
            {

                spawnedClouds.transform.position = leftPos.position;
                spawnedClouds.GetComponent<Clouds>().speed = Random.Range(2, 4);

            }
            else
            {
                // right side
                spawnedClouds.transform.position = rightPos.position;
                spawnedClouds.GetComponent<Clouds>().speed = -Random.Range(2, 4);
                spawnedClouds.transform.localScale = new Vector3(-1f, 1f, 1f);

            }

        } // while loop

    }


} // class
