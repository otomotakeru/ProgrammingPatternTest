using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface
{
    public class Player : MonoBehaviour, IAttackable, IDamageable, IDethable, ITalkable
    {
        private int _attackPower;

        public int AttackPower { get => _attackPower; set => _attackPower = value; }

        private int _hp;

        public int HP { get => _hp; set => _hp = value; }

        private int _defense;

        public int Defense { get => _defense; set => _defense = value; }

        [SerializeField]
        private GameObject _weapon;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Attack();
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Talk();
            }
        }

        public void Attack()
        {
            GameObject weapon = Instantiate(_weapon);
            weapon.GetComponent<Weapon>().CharacterAttackPower = AttackPower;
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
            Destroy(gameObject);
        }

        public void Talk()
        {
            //会話開始
        }
    }
}