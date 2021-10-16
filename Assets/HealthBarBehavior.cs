using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    bool zombie;
    Image image;
    float maxHp;
    HealthBehavior health;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        health = transform.parent.parent.parent.GetComponent<HealthBehavior>();
        
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = ((100 * health.currentHp) / health.maxHp) / 100;
    }
}
