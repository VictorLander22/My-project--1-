using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hazardPrefab;
    public int maxHazardsToSpamw;

    void Start()
    {
        StartCoroutine(SpawnHazards());
    }

    private IEnumerator SpawnHazards()
    {
        var hazardToSpamw = Random.Range(0, maxHazardsToSpamw);

        for (int i = 0; i < hazardToSpamw; i++)
        {
            var x = Random.Range(-4, 9);
            var drag = Random.Range(0f, 3f);
            var hazard = Instantiate(hazardPrefab, new Vector3(x, 23, 0), Quaternion.identity);
            hazard.GetComponent<Rigidbody>().drag = drag;
        }


        yield return new WaitForSeconds(1f);
        yield return SpawnHazards();
    }
}
