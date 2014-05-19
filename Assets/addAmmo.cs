using UnityEngine;
using System.Collections;

public class addAmmo : MonoBehaviour 
{
	public static int ammo = 0;


	void Start ()
	{
		collider.isTrigger = true;
	}

	void OnTriggerEnter( Collider WhatEnteredTheTrigger )
	{
		if( WhatEnteredTheTrigger.tag == "bot" )
		{
			int ammo = 10;
		}
	}


		void OnGUI()
		{
			string ammoText = "Ammo: " + ammo;
			GUI.Box (new Rect(Screen.width - 150,40,120,40),ammoText);

		}

}
