using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefreshTimer : MonoBehaviour {

	Image timer;

	float timeToRefresh;

	// Use this for initialization
	void Start () {
		timer = GetComponent<Image> ();
		timeToRefresh = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeToRefresh -= Time.deltaTime;
		timer.fillAmount = timeToRefresh / 2f;

		if (timeToRefresh < 0) {
			timeToRefresh = 2.0f;
			timer.fillAmount = 1.0f;
			UIManager.instance.RefreshValues ();
		}
	}
}
