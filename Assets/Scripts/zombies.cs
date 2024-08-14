using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombies : InteractableObject { 
    int health;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        
    }



    public override void onHit()
    {
        health = health - 20;
        Debug.Log("not here");
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
        
        if (health == 0)
        {
            Destroy(gameObject);
            
        }
    }

  
}
