using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{
    [Tooltip("let the item show up")]
    [SerializeField] private bool isValid;
    [Tooltip("the Renderer object")]
    [SerializeField] public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !rend.enabled)
            rend.enabled = true;
        else if(Input.GetKeyDown(KeyCode.Space) && rend.enabled)
            rend.enabled = false;



    }
}
