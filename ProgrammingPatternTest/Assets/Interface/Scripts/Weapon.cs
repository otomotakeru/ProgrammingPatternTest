using Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface
{
    public class Weapon : MonoBehaviour, IDethable
    {
        [SerializeField]
        private int _attackPower;

        private int _characterAttackPower;

        public int CharacterAttackPower { set => _characterAttackPower = value; }

        void Start()
        {
            Invoke(nameof(Dead), 1);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IDamageable damageable))
            {
                damageable.TakeDamage(_attackPower + _characterAttackPower);
            }
        }

        public void Dead()
        {
            Destroy(gameObject);
        }
    }
}