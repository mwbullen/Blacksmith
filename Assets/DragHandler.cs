﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
	public static GameObject tileBeingDragged;

	Vector3 startPosition;	
	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		tileBeingDragged = gameObject;
		startPosition = transform.position;
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		transform.position = Input.mousePosition;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		tileBeingDragged = null;
		transform.position = startPosition;
	}

	#endregion



}
