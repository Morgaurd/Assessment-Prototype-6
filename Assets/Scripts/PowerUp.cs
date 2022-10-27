using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Rigidbody powerRb;
    public GameObject player;
    public GameObject enemy;

    public int powerUpDuration = 7;
    public bool hasPowerup = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Ball");
        powerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            Destroy(gameObject);
            hasPowerup = true;
            if (hasPowerup == true)
            {
                enemy.SetActive(false);              
            }
            StartCoroutine(PowerupCooldown());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hasPowerup = true;
            StartCoroutine(PowerupCooldown());
            enemy.SetActive(true);
        }
    }

    IEnumerator PowerupCooldown()
    {
        yield return new WaitForSeconds(powerUpDuration);
        hasPowerup = false;
        enemy.SetActive(true);

    }
}
