using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health_helper : Health
{

  [SerializeField]
   public Text DisplayHealth;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth.text = "Health: " + gameObject.GetComponent<Health>().currenthealth;
    }
}
