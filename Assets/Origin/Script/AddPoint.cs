﻿using UnityEngine;
using System.Collections;

public class AddPoint : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {

        int x = 0;
        while (true)
        {
            GetComponent<UIMeshLine>().points.Add(new LinePoint(new Vector2(x++*10,0)));

            yield return new WaitForSeconds(1);
        }
	}
	
	
}
