using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AJM
{
    public class CoinManager : MonoBehaviour
    {
        private GameManager gameManager;

        void Start()
        {
            gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        }

        private void OnTriggerEnter2D(Collider2D whatDidIHit)
        {
            if (whatDidIHit.tag == "Player")
            {
                Destroy(whatDidIHit.gameObject);
                gameManager.AddScore(5);
                Destroy(this.gameObject);
            }
        }
    }
}