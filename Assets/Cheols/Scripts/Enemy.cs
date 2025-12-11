using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheols
{
    public class Enemy : MonoBehaviour
    {
        public float speed;
        public float ThrowPower = 50.0f;
        private GameObject Player;
        public GameObject objBullet;
        public Transform BulletPoint;
        public float delay = 0.5f;
        public float fireRate = 1.0f;
        public float hp = 1.0f;
        public float maxHp = 1.0f;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
