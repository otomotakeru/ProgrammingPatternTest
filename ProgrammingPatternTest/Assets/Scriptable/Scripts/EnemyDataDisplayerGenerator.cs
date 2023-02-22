using Scriptable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptable
{
    public class EnemyDataDisplayerGenerator : MonoBehaviour
    {
        [SerializeField]
        private List<EnemyData> _enemyData = new List<EnemyData>();
        [SerializeField]
        private GameObject _enemyDataDisplayPanel;

        public void GenerateEnemy()
        {
            GameObject panelInstance = Instantiate(_enemyDataDisplayPanel,transform.position + Random.insideUnitSphere * 5, Quaternion.identity, transform.parent);
            int random = Random.Range(0, _enemyData.Count);
            panelInstance.GetComponent<EnemyDataDisplayer>().EnemyData = _enemyData[random];
        }
    }
}