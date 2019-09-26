using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dectect_friends : MonoBehaviour
{

    public List<GameObject> Friends;
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
        if (other.gameObject.GetComponent<Group>() != null)
        {
            if (Friends != null) Friends.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Group>() != null)
        {
            Friends.Remove(other.gameObject);
        }
         
    }
}
