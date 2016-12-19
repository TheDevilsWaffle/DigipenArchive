﻿///////////////////////////////////////////////////////////////////////////////////////////////////
//AUTHOR — Travis Moore
//SCRIPT — ConstantVelocity.cs
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

public class ConstantVelocity : MonoBehaviour
{
    #region FIELDS
    public float speed;
    Rigidbody rb;
    Transform tr;
    public bool goLeft = false;
    #endregion

    #region INITIALIZATION
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Awake()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        tr = transform;
    }

	///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Update()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void FixedUpdate()
    {
        if (!goLeft)
        {
            rb.AddForce(tr.forward * speed, ForceMode.Acceleration);
            //rb.velocity = speed * tr.forward;
        }
        else
        {
            rb.AddForce(tr.forward * -speed, ForceMode.Acceleration);
            //rb.velocity = -speed * tr.forward;
        }
    }
    #endregion


    #region METHODS
    ///////////////////////////////////////////////////////////////////////////////////////////////
    
    ///////////////////////////////////////////////////////////////////////////////////////////////
    #endregion
}
