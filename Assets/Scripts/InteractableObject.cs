using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class InteractableObject : MonoBehaviour
{   
    public bool playerInRange;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && playerInRange && SelectionManager.Instance.OnTarget)
        {
            Destroy(gameObject);
        }
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