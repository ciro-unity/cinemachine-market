using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGameObjectOnStart : MonoBehaviour {

	void Start () {
		gameObject.SetActive(false);		
	}

}
