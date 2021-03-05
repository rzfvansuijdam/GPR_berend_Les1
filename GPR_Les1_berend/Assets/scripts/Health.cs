using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Maxhealth = 100;
    public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = Maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }


        if (currenthealth <= 0) // If stats class' health var <= 0, destroy enemy object
           Destroy(this.gameObject);
        
    }

    void TakeDamage(int damage)
    {
        currenthealth -= damage;
    }


}

