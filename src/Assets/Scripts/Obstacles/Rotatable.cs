using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatable : MonoBehaviour
{

    [SerializeField]
    private int maxRotateSpeed;
    [SerializeField]
    private int minRotateSpeed;
    private int rotationSpeed;

    private void Awake()
    {
        rotationSpeed = Random.Range(minRotateSpeed, maxRotateSpeed) * (Random.Range(0,2)*2-1);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed * Time.deltaTime));
    }
}
