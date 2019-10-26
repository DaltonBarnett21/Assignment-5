using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f;
    public Text scoreText;
    private int count = 0;
    private static int highscore = 0;
    

  

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float m = BallUpdate.BallSpeed;

        Vector3 movement = new Vector3(m * moveHorizontal, m * 0.0f, m * moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
     
        PlayerPrefs.SetInt("Score", count);
        if (count > highscore)
        {
            highscore = count;
        }
        scoreText.text = "Score: " + count;
        PlayerPrefs.SetInt("HighScore", highscore);
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "PickUp")
        {
            Other.gameObject.SetActive(false);
            count += 1;
            scoreText.text = "Score: " + count;
            
        }
    }
}
