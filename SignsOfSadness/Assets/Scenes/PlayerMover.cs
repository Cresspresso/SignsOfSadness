using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMover : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
	public Player player;
	private bool dragging = false;

	public static bool IsDown(TouchPhase phase)
	{
		switch (phase)
		{
			case TouchPhase.Canceled:
			case TouchPhase.Ended:
				return false;
			case TouchPhase.Began:
			case TouchPhase.Moved:
			case TouchPhase.Stationary:
				return true;
			default:
				throw new System.NotImplementedException();
		}
	}

	public static Vector2 GetPointerPos()
	{
		Vector3 v;
		var touches = Input.touches.Where(t => IsDown(t.phase));
		if (touches.Any())
		{
			v = touches.First().position;
		}
		else
		{
			v = Input.mousePosition;
		}
		v.z = 10;
		return Camera.main.ScreenToWorldPoint(v);
	}

	private void Update()
	{
		if (dragging)
		{
			player.desiredPos = GetPointerPos();
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		dragging = true;
		player.desiredPos = GetPointerPos();
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		dragging = false;
		player.desiredPos = GetPointerPos();
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		OnPointerUp(eventData);
	}
}
