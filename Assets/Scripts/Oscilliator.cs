using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilliator : MonoBehaviour
{
    
    Vector3 startingPosition;
    [SerializeField] Vector3 movingVector;
    float movingFactor;
    [SerializeField] float period = 2f;


    void Start()
    {
        startingPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (period <= Mathf.Epsilon) {return;}
        float cycles = Time.time / period; // continually growing over time
        
        const float tau = Mathf.PI * 2; // constant value of 6.283
        float rawSinWave = Mathf.Sin(cycles * tau); // going from -1 to 1

        movingFactor = (rawSinWave + 1f) / 2f; // recalculated to go from 0 to 1 so it's cleaner

        
        Vector3 offset = movingVector * movingFactor;
        transform.position = startingPosition + offset;
    }
}
