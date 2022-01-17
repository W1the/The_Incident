using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampONOFF : MonoBehaviour
{
    [SerializeField] GameObject Cube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ww");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}