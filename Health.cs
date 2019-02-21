using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	public const int maxHealf = 100;
	public  int currentHealth= maxHealf;
	public RectTransform healfbar;

	public void TakeDamage(int amount){
		currentHealth-=amount;
		if (currentHealth<=0)
		{
			currentHealth=0;
			Debug.Log("dead");
		}
		healfbar.sizeDelta = new Vector2 (currentHealth*2,healfbar.sizeDelta.y);//padaro ilgi kad jis mazetu;

	}
	

}
