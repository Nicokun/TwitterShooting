﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter : MonoBehaviour
{
    [SerializeField]
    private PlayerMove player;
    private Vector3 offset = Vector3.zero;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.transform.position.x + offset.x;
        newPosition.y = player.transform.position.y + offset.y;
        newPosition.z = player.transform.position.z + offset.z;
        transform.position = newPosition;

        //transform.position = Vector3.Lerp(
        //    transform.position, newPosition, 7f * Time.deltaTime);
    }
}
