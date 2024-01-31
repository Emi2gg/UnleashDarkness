using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorCollision : MonoBehaviour
{
    public int m_currentCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Mushroom":
                if(m_currentCounter >= 2)
                {
                    ReLoad();
                }
                else
                {
                    m_currentCounter++;
                }
                break;
        }
    }

    private void ReLoad()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
