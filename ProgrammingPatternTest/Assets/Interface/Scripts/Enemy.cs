using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface
{
    public class Enemy : MonoBehaviour, IAttackable, IDamageable, IDethable, IKnockBackable, IStanable
    {
        private int _attackPower;

        public int AttackPower { get => _attackPower; set => _attackPower = value; }

        private int _hp;

        public int HP { get => _hp; set => _hp = value; }

        private int _defense;

        public int Defense { get => _defense; set => _defense = value; }

        private float _stanTime;

        public float StanTime { get => _stanTime; set => _stanTime = value; }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Attack()
        {
            //攻撃処理
        }

        public void TakeDamage(int damageValue)
        {
            int result = damageValue - Defense;
            if (result > 0)
            {
                HP -= result;
            }
            else
            {
                //ブロック
            }
        }

        public void Dead()
        {
            //Scriptableのイベントシステムとかで得点追加処理とか
            Destroy(gameObject);
        }

        public void KnockBack()
        {
            //ノックバック処理
        }

        public void Stan()
        {
            //スタン処理
        }
    }
}