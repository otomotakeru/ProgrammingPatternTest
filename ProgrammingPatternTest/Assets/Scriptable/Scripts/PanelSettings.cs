using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptable
{
    [CreateAssetMenu(fileName = "PanelSettings", menuName = "ScriptableObjects/Scriptable/PanelSettings", order = 1)]
    public class PanelSettings : ScriptableObject
    {
        [SerializeField]
        private Color _missionPanelColor;

        public Color MissionPanelColor { get => _missionPanelColor; }

        [SerializeField]
        private Color _playerPanelColor;

        public Color PlayerPanelColor { get => _playerPanelColor; }

        [SerializeField]
        private Color _enemyPanelColor;

        public Color EnemyPanelColor { get => _enemyPanelColor; }
    }
}