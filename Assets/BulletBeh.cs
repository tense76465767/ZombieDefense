using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBeh : MonoBehaviour
{
    Rigidbody rigidbody;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = transform.forward * (10f);
        time += Time.deltaTime;
        if (time >= 10f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Zombie")
        {
            Destroy(this.gameObject);
            other.transform.gameObject.GetComponent<HealthBehavior>().currentHp -= 10;
        }
        if (other.transform.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
