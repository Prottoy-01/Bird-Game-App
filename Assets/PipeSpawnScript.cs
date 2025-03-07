using System.Threading;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnrate;
    private float timer = 0;
    public float heightOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }

    void spawnpipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,heighestPoint),0), transform.rotation);

    }
}
