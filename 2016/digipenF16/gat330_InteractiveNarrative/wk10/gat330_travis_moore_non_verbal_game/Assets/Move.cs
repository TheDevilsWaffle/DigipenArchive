﻿///////////////////////////////////////////////////////////////////////////////////////////////////
//SCRIPT: Move.cs
//AUTHOR: Travis Moore
///////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{

    #region REFERENCES/PROPERTIES

    [HideInInspector]
    public PlayerInput currentPlayerInput;
    Rigidbody2D rBody;
    Transform tForm;

    public float maxSpeed;
    public float minSpeed;
    private float currentSpeed;

    #endregion

    #region INITIALIZATION

    /////////////////////////////////////////////////////////////////////////////////////////////// 
    /// <summary>
    /// Awake()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        //get refs
        currentPlayerInput = GetComponent<KeyboardController>().currentPlayerInput;
        rBody = GetComponent<Rigidbody2D>();
    }

    /////////////////////////////////////////////////////////////////////////////////////////////// 
    /// <summary>
    /// Start()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
        //set currentSpeed equal to Start
        currentSpeed = minSpeed;
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
        //update currentPlayerInput
        currentPlayerInput = GetComponent<KeyboardController>().currentPlayerInput;

        //move the player based on current direction
        ApplyMovement(currentPlayerInput.direction);
    }

    /////////////////////////////////////////////////////////////////////////////////////////////// 
    /// <summary>
    /// ApplyMovement()
    /// </summary>
    /// <param name="_direction">current direction the player is moving in</param>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void ApplyMovement(Vector2 _direction)
    {
        rBody.velocity = _direction * currentSpeed;
    }

    #endregion
}
