using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootable : MonoBehaviour
{

    [SerializeField]
    private GameObject effect;

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Bullet")){
            if (effect != null ){
                Instantiate(effect, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}
