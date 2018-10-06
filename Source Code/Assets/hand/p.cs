using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p : MonoBehaviour {

	public GameObject Model_One;
    private bool isClicked = false;
	void Start () {
        Model_One.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void toggele(){
                if(isClicked){
                    isClicked=false;
                    Model_One.SetActive(true);
                }
                else
                {
                    isClicked=true;
                    Model_One.SetActive(false);
                }
}
}