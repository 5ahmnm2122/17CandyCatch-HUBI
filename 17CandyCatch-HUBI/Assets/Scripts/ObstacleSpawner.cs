using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] candy;
    private BoxCollider2D col;
    float x1, x2;

    void Awake ()
    {
        col = GetComponent<BoxCollider2D> ();

        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
    }
    void Start ()
    {
        StartCoroutine(SpawnObstacles(2f));
    }
    IEnumerator SpawnObstacles(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);

        Instantiate(candy[Random.Range(0, candy.Length)], temp, Quaternion.identity);
        StartCoroutine(SpawnObstacles(Random.Range(1f, 2f)));
    }
}
