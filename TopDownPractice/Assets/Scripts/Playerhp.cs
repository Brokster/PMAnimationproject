using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Playerhp : MonoBehaviour
{
    public int health = 5;
    public Text healthText;
    public Slider healthSlider;
    public int lives = 10;
    private void Start()
    {
        healthText.text = "Health: " + health;
        healthSlider.maxValue = health;
        healthSlider.value = health;
        //PlayerPrefs.SetInt("lives," lives);
        lives = PlayerPrefs.GetInt("lives");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Health: " + health;
            healthSlider.value = health;
            if (health < 1)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            {
                if (lives > 0)
                {

                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    //SceneManager.LoadScene("Lose");
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
        
        

        
    }

}
