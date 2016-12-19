﻿///////////////////////////////////////////////////////////////////////////////////////////////////
//AUTHOR — Travis Moore
//SCRIPT — SpawnGameObject.cs
//COPYRIGHT — © 2016 DigiPen Institute of Technology
///////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.UI;

#region ENUMS

#endregion

#region EVENTS

#endregion

public class SpawnGameObject : MonoBehaviour
{
    #region FIELDS
    public GameObject objectToSpawn;
    public float minDelay;
    public float maxDelay;
    float delay = 1f;
    float timer = 0f;
    Transform tr;
    #endregion

    #region INITIALIZATION
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Awake()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        tr = transform;
    }

	///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Start()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
        timer = 0f;
        delay = GetRandomFloat(minDelay, maxDelay);
	}
    #endregion

    #region UPDATE
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Update()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Update()
    {
        timer += Time.deltaTime;
	    if(timer > delay)
        {
            timer = 0f;
            delay = GetRandomFloat(minDelay, maxDelay);
            SpawnObject();
        }
	}
    #endregion

    #region METHODS
    float GetRandomFloat(float _min, float _max)
    {
        return Random.Range(_min, _max);
    }
    void SpawnObject()
    {
        GameObject _go = (GameObject)GameObject.Instantiate(objectToSpawn, tr.position, Quaternion.identity, tr);
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////
    
    ///////////////////////////////////////////////////////////////////////////////////////////////
    #endregion
}
