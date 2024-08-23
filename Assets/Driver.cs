using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float speed = 0.01f;
    [SerializeField]float rotationSpeed = 0.1f;
    [SerializeField]float slowSpeed = 15f;
    [SerializeField]float boostSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotationAmount);
        transform.Translate(0, moveAmount, 0);  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Slow")
        {
            speed = slowSpeed;
        }
        if(other.tag == "Boost")
        {
            speed = boostSpeed;
        }
    }
}
