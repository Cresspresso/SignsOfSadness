using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Rect limits = new Rect(-3, -1, 6, 1);
	public Vector2 desiredPos = Vector2.zero;

	// Use this for initialization
	void Start()
	{
		desiredPos = transform.position;
	}

	private void FixedUpdate()
	{
		desiredPos.x = Mathf.Clamp(desiredPos.x, limits.xMin, limits.xMax);
		desiredPos.y = Mathf.Clamp(desiredPos.y, limits.yMin, limits.yMax);
		var rb = GetComponent<Rigidbody2D>();
		rb.MovePosition(desiredPos);
	}
}
