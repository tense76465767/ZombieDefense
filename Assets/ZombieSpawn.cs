using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public GameObject Zombie;
    float interval;

    // Start is called before the first frame update
    void Start()
    {
        interval = 0;
    }

    // Update is called once per frame
    void Update()
    {
        interval += Time.deltaTime;
        if (interval >= 5f)
        {
            interval = 0;
            Instantiate(Zombie, new Vector3(transform.position.x, 1, transform.position.z), transform.rotation);
        }
    }
}
