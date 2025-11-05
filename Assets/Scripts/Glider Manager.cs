using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AJM
{
    public class GliderManager : MonoBehaviour
    {
        public bool goingUp;
        public float speed;

        private GameManager gameManager;

        void Start()
        {
            gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        }

        void Update()
        {
            if (goingUp)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (goingUp == false)
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }

            if (transform.position.y >= gameManager.verticalScreenSize * 1.25f || transform.position.y <= -gameManager.verticalScreenSize * 1.25f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}