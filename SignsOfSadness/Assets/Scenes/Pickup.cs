using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
	//private void Start()
	//{
	//	GetComponent<Button>().onClick.AddListener(PickUp);
	//}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			PickUp();
		}
	}

	public void PickUp()
	{
		FindObjectOfType<GameController>().OnPickingUp(this);
	}
}
