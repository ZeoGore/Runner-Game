using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveScript : MonoBehaviour
{
        public Transform PlayerPosition;
        private Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = PlayerPosition.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
