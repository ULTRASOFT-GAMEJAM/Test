﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Shape
{
    sphere,
    box
};

public class PlayerPolyhedron : MonoBehaviour
{
    public Shape playerShape;
    private Camera playerCamera;
    public LayerMask boxMask;
    public LayerMask sphereMask;

    private void Start()
    {
        playerCamera = GetComponentInChildren<Camera>();
        PlayerShape = playerShape;
    }

    public Shape PlayerShape
    {
        set
        {
            playerShape = value;
            if (playerShape == Shape.box)
            {
                playerCamera.cullingMask = boxMask;
            }
            else if (playerShape == Shape.sphere)
            {
                playerCamera.cullingMask = sphereMask;
            }
        }
        get
        {
            return playerShape;
        }
    }

}

