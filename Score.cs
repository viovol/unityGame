using System.Net.Mime;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {
 public Transform player; 
 public Text scoreText;
 public  int currentScore=0;
	
public void AddScore(int amount){
		currentScore+=amount;
		scoreText.text = currentScore.ToString();

	}
	
	
}