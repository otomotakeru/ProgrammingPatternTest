using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface
{
    public class Mob : MonoBehaviour, IDamageable, ITalkable
    {
        public int HP { get; set; }

        public int Defense { get; set; }

        private bool _firstTalk;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void TakeDamage(int damageValue)
        {
            //「いてて」Text表示
        }

        public void Talk()
        {
            if (_firstTalk)
            {
                //初回用セリフ
            }
            else
            {
                //セリフ
            }
        }
    }
}