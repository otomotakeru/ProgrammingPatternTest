using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scriptable
{
    public class PlayerDataDisplayer : MonoBehaviour
    {
        [SerializeField]
        private List<PlayerData> _playerDatas;
        [SerializeField]
        private Text _playerNameText;
        [SerializeField]
        private Text _playerHPText;
        [SerializeField]
        private PanelSettings _panelSettings;

        private int _playerDatasPointer;

        // Start is called before the first frame update
        void Start()
        {
            _playerNameText.text = $"Name:{_playerDatas[_playerDatasPointer].PlayerName}";
            _playerHPText.text = $"HP:{_playerDatas[_playerDatasPointer].DefaultHP}";
            GetComponent<Image>().color = _panelSettings.PlayerPanelColor;
        }

        public void LevelUP()
        {
            if (_playerDatasPointer < _playerDatas.Count - 1)
            {
                _playerDatasPointer++;
                Start();
            }
        }
    }
}
