using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public AudioSource audioSourse;
    public AudioClip damageSound;
    public void TakedDamage(int damage)
    {
        health -= damage;
        if(health >0)
        {
            audioSourse.PlayOneShot(damageSound);
            print("Здоровье игрока: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
    public void CollectCoins()
    {
        coins++;
        print("Собранные монетки" + coins);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
