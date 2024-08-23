using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(255, 0, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32(0, 255, 0, 255);
    [SerializeField] float timeToDetroy = 1;
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)       
    {        
        Debug.Log("Collision with player");       
    }

    void OnTriggerEnter2D(Collider2D aaaa) 
    {
        if(aaaa.tag == "Package" && hasPackage == false) //cach viet khac !hasPackage
        {
            Debug.Log("Package collected");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(aaaa.gameObject, timeToDetroy);
        }
        if(aaaa.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package delivered");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
