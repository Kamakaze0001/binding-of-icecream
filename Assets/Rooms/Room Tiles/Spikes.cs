﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerStay2D(Collider2D collider){
		if (collider.name == "PlayerCollider") {
            //Hurt the player

		}
	}

}