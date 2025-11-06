using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AJM
{
    public class enemyJuanPrefab : MonoBehaviour
    {
        public GameObject explosionPrefab;
        private GameManager gameManager;
        float speed = 5f;
        int direction = 1;
        
        
        void Start()
        {
            gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        }

        public void Update()
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
            transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

            if (transform.position.x >= 2.5)
            {
                direction = -1;
                Vector3 pos = transform.position;
                pos.y -= .5f;
                transform.position = pos;
            }

            if (transform.position.y < -6.5f)
            {
                Destroy(this.gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D whatDidIHit)
        {
            if (whatDidIHit.tag == "Player")
            {
                whatDidIHit.GetComponent<PlayerManager>().LoseALife();
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
            else if (whatDidIHit.tag == "Weapons")
            {
                Destroy(whatDidIHit.gameObject);
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                gameManager.AddScore(5);
                Destroy(this.gameObject);
            }
        }
    }
}








