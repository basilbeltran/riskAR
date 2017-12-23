using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int maxHealth;
    public int currentHeath;
    public Text HealthScore;


	// Use this for initialization
	void Start () {
        HealthScore.text = currentHeath.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Update is called once per frame
    public void TakeDamage(int howMuch)
    {
        var newHealth = currentHeath - howMuch;
        if(currentHeath <= 0){
            
        }
        else{
            currentHeath = newHealth;
            HealthScore.text = currentHeath.ToString();
        }
    }

}
