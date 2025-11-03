using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AJM
{
    public class BulletManager : MonoBehaviour
    {
        public void Update()
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 8f);
            if (transform.position.y > 6.5f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}