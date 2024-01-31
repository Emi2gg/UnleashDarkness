using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Floor":
                RePosition();
                break;

            case "Player":
                RePosition();
                break;
        }
    }

    private void RePosition()
    {
        transform.position = GameManager.instance.GetRandomPosition;
    }

}
