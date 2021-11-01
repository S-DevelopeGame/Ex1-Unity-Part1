using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Tooltip("sliding distance left and right")]
    [SerializeField] private float distance;
    [Tooltip("speed of the object")]
    [SerializeField] private float frequency;
    [Tooltip("starting position")]
    [SerializeField] private Vector3 location;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = location;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("deltaTime: " + new Vector3(Mathf.Sin(Time.time), 0, 0));
        transform.position = new Vector3(Mathf.Sin(Time.time * frequency) * distance, 0, 0);
    }
}
