﻿///////////////////////////////////////////////////////////////////////////////////////////////////
//AUTHOR — Travis Moore
//SCRIPT — GameTimer.cs
//COPYRIGHT — © 2016 DigiPen Institute of Technology
///////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
//using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#region ENUMS

#endregion

#region EVENTS

#endregion

public class GameTimer : MonoBehaviour
{
    #region FIELDS
    public int minutes;
    [Range(0f, 59f)]
    public float seconds;
    public Text gameTimer;
    bool reloadScene;
    #endregion

    #region INITIALIZATION
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Awake()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        reloadScene = false;
    }

	///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Start()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
        gameTimer.text = minutes + ":" + (int)seconds;
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
        if (reloadScene == false)
        {
            UpdateTimer();
        }
	}
    #endregion

    #region METHODS
    void UpdateTimer()
    {
        seconds -= Time.deltaTime;
        if (minutes == 0 && seconds <= 0)
        {
            print("reloading scene!");
            reloadScene = true;
            ReloadLevel();
        }
        else if (seconds <= 0)
        {
            seconds = 59f;
            if (minutes > 0)
                --minutes;
        }
        gameTimer.text = minutes + ":" + (int)seconds;
    }
    void ReloadLevel()
    {
        print("reloading scene!");
        int _scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(_scene, LoadSceneMode.Single);
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////
    
    ///////////////////////////////////////////////////////////////////////////////////////////////
    #endregion
}
