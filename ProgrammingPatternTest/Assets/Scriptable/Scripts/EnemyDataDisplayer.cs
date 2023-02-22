using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scriptable
{
    public class EnemyDataDisplayer : MonoBehaviour
    {
        private EnemyData _enemyData;

        public EnemyData EnemyData { set => _enemyData = value; }

        [SerializeField]
        private Text _enemyHPText;
        [SerializeField]
        private GameEvent _gameEvent;
        [SerializeField]
        private PanelSettings _panelSettings;

        private void Start()
        {
            _enemyHPText.text = $"HP:{_enemyData.DefaultHP}";
            GetComponent<Image>().color = _panelSettings.EnemyPanelColor;
        }

        public void Destroy()
        {
            Destroy(gameObject);
        }
    }
}
