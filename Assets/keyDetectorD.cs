using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyDetectorD : MonoBehaviour
{

    public GameObject door;
    public string keyTag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag(keyTag))
        {
            Destroy(door);
        }
    }
}
