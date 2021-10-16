using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : MonoBehaviour
{
    public GameObject bullet;
    float interval = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.gameObject.tag == "Zombie")
        {
            var rotation = Quaternion.LookRotation(other.transform.gameObject.transform.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5f);
            Shoot();
        }
        this.transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
    }

    private void Shoot()
    {
        interval += Time.deltaTime;
        if (interval >= 1f)
        {
            interval = 0;
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
