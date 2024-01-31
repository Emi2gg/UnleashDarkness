using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float m_speed;
    public Transform spawnPoint;
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
      transform.Translate(new Vector3(Input.GetAxis("Horizontal") * (m_speed * Time.deltaTime), 0, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
        }
        
    }

    private void LateUpdate()
    {
       if (transform.position.x > GameManager.instance.GetRightLimit.x)
        {
            transform.position = new Vector3(GameManager.instance.GetRightLimit.x, transform.position.y, transform.position.z);
        }

        if (transform.position.x < GameManager.instance.GetLeftLimit.x)
        {
            transform.position = new Vector3(GameManager.instance.GetLeftLimit.x, transform.position.y, transform.position.z);
        }


    }

}

