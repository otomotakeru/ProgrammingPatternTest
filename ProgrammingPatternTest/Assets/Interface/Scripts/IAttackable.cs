using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface
{
    public interface IAttackable
    {
        public int AttackPower { get; set; }

        public void Attack();
    }
}