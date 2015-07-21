using UnityEngine;
using System.Collections;

public class Attackable : MonoBehaviour {

	HandController _handController;

	void Start(){
		_handController = GameObject.FindObjectOfType<HandController>().GetComponent<HandController>();
	}

	void OnMouseOver()
	{
		if(MouseController.GetDoubleClick () && UnitController.idleUnitCount > 0)
		{
			_handController.ThrowUnitToAttack (gameObject);
			UnitController.idleUnitCount --;
		}
	}
}
