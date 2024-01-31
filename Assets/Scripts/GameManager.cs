using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    [SerializeField]
    private Transform m_rightLimit, m_leftLimit;

    public Vector3 GetRightLimit
    {
        get { return m_rightLimit.position; }
    }
    public float GetUpLimit
    {
        get { return  GameManager.instance.GetRightLimit.y; }
    }
    public Vector3 GetLeftLimit
    {
        get { return m_leftLimit.position; }
    }

    public Vector3 GetRandomPosition => new Vector3(UnityEngine.Random.Range(GameManager.instance.GetLeftLimit.x, GameManager.instance.GetRightLimit.x), GameManager.instance.GetRightLimit.y, 0);

    public void Start()
    {
        instance = this;
    }
}
