using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class SelectionManager : MonoBehaviour
{
    public bool OnTarget;

    public static SelectionManager Instance {get; set;}

    private void Start()
    {
        OnTarget=false;
    }
    
    private void Awake()
    {
        if(Instance != null && Instance != this){
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selectionTransform = hit.transform;
 
            if (selectionTransform.GetComponent<InteractableObject>()&&selectionTransform.GetComponent<InteractableObject>().playerInRange)
            {
                OnTarget = true;
            }
            else{
                OnTarget = false;
            }
            
 
        }
        else{
            OnTarget = false;

        }

    }
}