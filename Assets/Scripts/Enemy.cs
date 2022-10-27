using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRb;
    private GameObject player;
    private GameObject gameWall;
    public float speed = 40f;
    public float speedFight = 80f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Ball");
        gameWall = GameObject.Find("GameWall");

        Vector3 moveDirection = new Vector3(0, 0, 2);
        enemyRb.AddForce(speedFight * Time.deltaTime * moveDirection, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        //enemyRb.AddForce(gameObject.transform.position * speed * Time.deltaTime); 
    }
    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "GameWall (4)")
        {
            Vector3 moveDirection = new Vector3(0, 0, -6);
            enemyRb.AddForce(speedFight * Time.deltaTime * moveDirection, ForceMode.Impulse);
        }
        else if (other.gameObject.name == "Ball")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (other.gameObject.name == "GameWall (3)")
        {
            Vector3 moveDirection = new Vector3(0, 0, 4);
            enemyRb.AddForce(speedFight * Time.deltaTime * moveDirection, ForceMode.Impulse);
        }
        else if (other.gameObject.name == "GameWall (14)")
        {
            Vector3 moveDirection = new Vector3(0, 0, -6);
            enemyRb.AddForce(speedFight * Time.deltaTime * moveDirection, ForceMode.Impulse);
        }
        else if (other.gameObject.name == "GameWall (9)")
        {
            Vector3 moveDirection = new Vector3(0, 0, 4);
            enemyRb.AddForce(speedFight * Time.deltaTime * moveDirection, ForceMode.Impulse);
        }else if (other.gameObject.name == "GameWall (19)")
        {
            Vector3 moveDirection = new Vector3(0, 0, 4);
            enemyRb.AddForce(speedFight * Time.deltaTime * moveDirection, ForceMode.Impulse);
        }

    }
}
