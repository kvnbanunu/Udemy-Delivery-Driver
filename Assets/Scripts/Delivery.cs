using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;
    bool hasPackage;
    float destroyDelay = 0.1f;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision");
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        // Debug.Log("Trigger");
        if (other.tag == "Package" && !hasPackage) {
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
            Debug.Log("Package picked up.");
            hasPackage = true;
            
        }

        if (other.tag == "Customer" && hasPackage)
        {
            spriteRenderer.color = noPackageColor;
            Debug.Log("Package delivered");
            hasPackage = false;
        }
    }
}
