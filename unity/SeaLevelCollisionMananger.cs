using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaLevelCollisionMananger : MonoBehaviour
{

    [SerializeField] private string _seaLeveltTag = "SeaLevel";
    [SerializeField] private string _buildingTag = "Building";
    [SerializeField] private string _poiTag = "POI";

    [SerializeField] private Material _floodedMaterial;


    private Material[] _storedMaterials;
    private int _numberOfMaterials = 0;

    Collider thisCollider;
    private Material _originalMaterial;
    private Renderer _thisRender;

    private void Start()
    {
        _thisRender = GetComponent<Renderer>(); // grab the renderer component on our cube
        _thisRender.enabled = true; // in case not enabled
        Material[] materials = _thisRender.materials; //make array of all material
        _storedMaterials = materials;


        _floodedMaterial = new Material(Shader.Find("Standard"));

        Debug.Log("Number of materials" + _numberOfMaterials);

        thisCollider = GetComponent<Collider>();
    }

    //private void OnCollisionEnter(Collision other)
    //{
    //    print("In OnCollisionEnter()");

    //    if (other.gameObject.CompareTag(_seaLeveltTag)) {
    //        FloodBuilding(other.gameObject);
    //        HandleSeaLevelFlooding();
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("In OnTriggerEnter()");

        if (other.gameObject.CompareTag(_seaLeveltTag))
        {
            ChangeColor(other, _floodedMaterial, Color.grey);
            HandleSeaLevelFlooding();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("In OnTriggerStay()");

        if (other.gameObject.CompareTag(_seaLeveltTag))
        {

            //ChangeColor(other, _floodedMaterial);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("In OnTriggerExit()");

        if (other.gameObject.CompareTag(_seaLeveltTag))
        {

            if (IsFlooded(other))
            {
                ChangeColor(other, _floodedMaterial, Color.red);

                Debug.Log("Submerged!");

            }
            else
            {
                RestoreMaterials();
                Debug.Log("Safe!");
            }
        }
    }

    private void HandleSeaLevelFlooding()
    {
        if (gameObject.CompareTag(_buildingTag))
        {
            Debug.Log("Building Flooded");
            GameManager.Instance.BuildingIsFlooded();
        }

        //else if (gameObject.CompareTag(_buildingTag))
        //{
        //GameManager.Instance.poiFlooded();
        //}
    }

    public void ChangeColor(Collider sealevel, Material mat, Color col)
    {

        Material[] mats = new Material[_thisRender.materials.Length];
        for (int i = 0; i < _thisRender.materials.Length; i++)
        {
            mats[i] = mat;
            mats[i].color = col;
        }

        _thisRender.materials = mats;

        if (sealevel.transform.position.y == 0.0f)
        {
            print("Do nothing - at sea level");
            return;
        }
    }


    public bool IsFlooded(Collider seaLevelCollider)
    {
        bool isFlooded = false;

        if (seaLevelCollider.bounds.max.y <= thisCollider.bounds.min.y)
        {
            isFlooded = false;
            Debug.Log("Sea level at current levels or below current levels");
        }
        else if (seaLevelCollider.bounds.max.y <= thisCollider.bounds.max.y)
        {
            isFlooded = true;
            Debug.Log("House is flooded");
        }
        else
        {
            isFlooded = true;
            Debug.Log("Sea level above House. House is fully submerged");
        }

        return (isFlooded);
    }



    private void RestoreMaterials()
    {
        _thisRender.materials = _storedMaterials;
    }
}





