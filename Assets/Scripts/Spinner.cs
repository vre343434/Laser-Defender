using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] private float speedOfSpeed = 180f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, speedOfSpeed * Time.deltaTime);
    }
}
