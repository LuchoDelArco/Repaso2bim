﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{

	public GameObject brickPrefab;
	public float xOffset;
	int counter;
	public Text userOffset;


    // Start is called before the first frame update
    


	public void cloneBrick()
	{
		if (counter == 0)
		{
			xOffset = float.Parse(userOffset.text);
		}
		if (counter<5) {
			GameObject clon;
			clon = Instantiate(brickPrefab);
			clon.transform.position = new Vector3(xOffset, 0, 0);
			xOffset += 1.1f;
			counter++;
		}


		
	}
}
