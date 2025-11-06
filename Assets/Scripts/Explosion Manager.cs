using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AJM
{
    public class Explosion : MonoBehaviour
    {
        void Start()
        {
            Destroy(this.gameObject, 1f);
        }
    }
}