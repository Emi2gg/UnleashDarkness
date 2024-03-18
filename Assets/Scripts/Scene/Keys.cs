using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{

    [SerializeField] private GameObject Key;
    [SerializeField] private GameObject Door;
    public bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Key")
        {
            hasKey = true;
            Key.SetActive(false);

        } else if ((collision.gameObject.tag == "Door") && (hasKey == true))
        {

            Door.SetActive(false);
            hasKey = false;
        
        }
        
        else if(hasKey == false)
        {
            
            Key.SetActive(true);
            Door.SetActive(true);
        }
    }
}
