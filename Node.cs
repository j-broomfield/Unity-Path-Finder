﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

	public bool walkable;
	public Vector3 worldPosition;

    public int gCost;
    public int hCost;
    public int gridX;
    public int gridY;
    public Node parent;
    public int movementPenalty;

    public Node(bool _walkable, Vector3 _worldPos, int _gridX, int _gridY, int _penalty){
		
	    walkable = _walkable;
	    worldPosition = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
        movementPenalty = _penalty;

	}

    public int fCost
    {
        get
        {
            return gCost + hCost;
        }

    }
}
