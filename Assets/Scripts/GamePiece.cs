﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour {

    public int xIndex, yIndex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void setCoordinates (int x, int y) {
        xIndex = x;
        yIndex = y;
	}
}
