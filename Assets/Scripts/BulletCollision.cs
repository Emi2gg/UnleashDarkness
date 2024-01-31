using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletCollision : MonoBehaviour
{
    public bool redBullet = false;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Floor":
                if (redBullet)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
                else
                {
                    RePosition();
                }
                break;

            case "Player":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;

            case "BulletGreen":
                if (redBullet)
                {
                    RePosition();
                }
                break;
        }
    }

    private void RePosition()
    {
        transform.position = GameManager.instance.GetRandomPosition;
    }



 
}
