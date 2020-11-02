using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
    public Image healthBar;
    public float startHealth = 100;
	private float health;
    private bool isDead = false;
    public int worth = 50;

    void Start ()
	{
		health = startHealth;
	}

    public void TakeDamage (float amount)
	{
		health -= amount;

		healthBar.fillAmount = health / startHealth;

		if (health <= 0 && !isDead)
		{
			Die();
		}
	}

    void Die ()
	{
		isDead = true;

		//PlayerStats.Money += worth;

		//GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
		//Destroy(effect, 5f);

		Destroy(gameObject);
	}



}
