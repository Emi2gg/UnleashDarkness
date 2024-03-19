using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Light : MonoBehaviour
{
    [SerializeField] private bool _isOn = false;
    [SerializeField] MeshRenderer _floorBulb = null;

    [SerializeField] private Material _onMaterial, _offMaterial;

    public void Start()
    {
        _isOn = false;
        _floorBulb.material = _offMaterial;
    }
    public void Update()
    {
        if (_isOn)
        {
            _floorBulb.material = _onMaterial;
            



        }
        
        


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            _isOn = true;
        }
    }

}
