using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scriptable
{
    public class MissionDisplayer : MonoBehaviour
    {
        [SerializeField]
        private MissionFlag _missionFlag;
        [SerializeField]
        private Text _mainMissionText;
        [SerializeField]
        private PanelSettings _panelSettings;

        // Start is called before the first frame update
        void Start()
        {
            GetComponent<Image>().color = _panelSettings.MissionPanelColor;
            TextUpDate();
        }

        public void TextUpDate()
        {
            bool isMainMissionComplete = _missionFlag.MainMissionFlag.IsComplete;
            if (isMainMissionComplete)
            {
                _mainMissionText.text = "MainMission:Complete";
            }
            else
            {
                _mainMissionText.text = "MainMission:Press the button";
            }
        }

        public void MainMissionComplete()
        {
            _missionFlag.MainMissionFlag.IsComplete = true;
            TextUpDate();
        }
    }
}
