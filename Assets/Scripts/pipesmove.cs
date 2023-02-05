using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pipesmove : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed;
    void Start()
    {
        speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }
}
