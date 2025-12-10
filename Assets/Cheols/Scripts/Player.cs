using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheols
{
    public class Player : MonoBehaviour
    {
        // 총알 딜레이
        public float bulletTIme = 0.1f;
        // 총알 딜레이만크 시간이 지나갔는지 체크
        public float relodTIme = 0f;
        Rigidbody thisRigi;
        // 플레이어의 이동속도
        public float speed = 2.0f;
        // 총알 프리펩
        public GameObject objBullet;
        // 총알이 생성될 위치
        public GameObject BulletPoint;
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
