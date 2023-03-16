using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hazardPrefab;

    void Start()
    {
        StartCoroutine(SpawnHazards());
    }

    private IEnumerator SpawnHazards()
    {
        
        var x =Random.Range(-4,9);
        Instantiate(hazardPrefab, new Vector3(x, 23, 0), Quaternion.identity);
        yield return null;
    }
}
