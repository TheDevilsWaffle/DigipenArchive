﻿///////////////////////////////////////////////////////////////////////////////////////////////////
//AUTHOR — Travis Moore
//SCRIPT — FollowerTracker.cs
//COPYRIGHT — © 2016 DigiPen Institute of Technology
///////////////////////////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.UI;

#region ENUMS

#endregion

#region EVENTS
public class EVENT_AllFollowersDead : GameEvent
{
    public EVENT_AllFollowersDead()
    {
    }
}
#endregion

public class FollowerTracker : MonoBehaviour
{
    #region FIELDS
    public int followers = 10;

    #endregion

    #region INITIALIZATION
    ///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Awake()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        Events.instance.AddListener<EVENT_FollowerDied>(EvaluateFollowers);
    }

	///////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// Start()
    /// </summary>
    ///////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
	
	}
    #endregion

    #region METHODS
    void EvaluateFollowers(EVENT_FollowerDied _event)
    {
        --followers;
        if(followers == 0)
        {
            Events.instance.Raise(new EVENT_AllFollowersDead());
        }
    }

    void OnDestroy()
    {
        Events.instance.RemoveListener<EVENT_FollowerDied>(EvaluateFollowers);
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////

    ///////////////////////////////////////////////////////////////////////////////////////////////
    #endregion
}
