using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler {
	#region IDropHandler implementation
	public void OnDrop (PointerEventData eventData)
	{
		//throw new System.NotImplementedException ();

		if (gameObject.transform.childCount == 0) {
			DragHandler.tileBeingDragged.transform.parent = gameObject.transform;
		}
	}
	#endregion

}
