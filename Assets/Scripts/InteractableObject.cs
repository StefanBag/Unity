using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class InteractableObject : MonoBehaviour
{   
    public bool playerInRange;

    protected virtual void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0) && playerInRange && SelectionManager.Instance.OnTarget)
        {
            Debug.Log("am i here?");
            onHit();
        }
    }

    public virtual void onHit()
    {
        //add functionality

    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

}