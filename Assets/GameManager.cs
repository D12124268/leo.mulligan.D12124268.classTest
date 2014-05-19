using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{

		//GameObject new Bot = Instantiate(bot,transform.position,bot.transform.rotation) as GameObject;
        GameObject bot = GameObject.FindGameObjectWithTag("bot");
		GameObject bot7 = GameObject.FindGameObjectWithTag("bot");
		GameObject bot3 = GameObject.FindGameObjectWithTag("bot");
		bot.renderer.material.color = Color.blue;
		bot7.renderer.material.color = Color.blue;

		GameObject ammo = GameObject.FindGameObjectWithTag("ammo");
		ammo.renderer.material.color = Color.red;


		//GameObject newAmmo = Instantiate(ammo,transform.position,ammo.transform.rotation) as GameObject;

		bot.GetComponent<StateMachine>().SwitchState(new IdleState(bot, bot7));

		ammo.renderer.material.color = Color.red;
		bot3.renderer.material.color = Color.blue;

        
	}	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
