using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public TMP_Text healthText;
    private float health = 100;
    public float damage = 20;
    
    public void Start()
    {
        healthText.text = "Health: " + health.ToString(); 
    }
    public void takeDamage()
    {
        health -= damage;
        Debug.Log(health);
        if (health <= 0)
        {
           Debug.Log("dead");
        }
        healthText.text = "Health: " + health.ToString();
    }
    
}