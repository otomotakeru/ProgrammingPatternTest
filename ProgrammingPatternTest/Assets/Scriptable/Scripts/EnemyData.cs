using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptable
{
    [CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/Scriptable/EnemyData", order = 1)]
    public class EnemyData : ScriptableObject
    {
        [SerializeField]
        private int _defaultHP;

        public int DefaultHP { get => _defaultHP; }
    }
}
