using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{

    public GameObject collectibleEffect;

    public AudioClip collectedClip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                collectibleEffect = Instantiate(collectibleEffect, transform.position, Quaternion.Euler(-90, 0, 0));
                controller.PlaySound(collectedClip);

                Destroy(gameObject);
            }
            
        }
    }

}
