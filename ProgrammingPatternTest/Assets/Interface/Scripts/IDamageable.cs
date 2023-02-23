using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface
{
    public interface IDamageable
    {
        public int HP { get; set; }

        public int Defense { get; set; }

        public void TakeDamage(int damage);
    }
}