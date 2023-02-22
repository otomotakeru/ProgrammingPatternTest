using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Scriptable
{
    [Serializable]
    public class GameFlag
    {
        [SerializeField]
        private string _flagName;

        public string FlagName { get => _flagName; }

        [SerializeField]
        private bool _isComplete;

        public bool IsComplete { get => _isComplete; set => _isComplete = value; }
    }

    [CreateAssetMenu(fileName = "MissionFlag", menuName = "ScriptableObjects/Scriptable/MissionFlag", order = 1)]
    public class MissionFlag : ScriptableObject
    {
        [SerializeField]
        private GameFlag _mainMissionFlag;

        public GameFlag MainMissionFlag { get => _mainMissionFlag; }

        [SerializeField]
        private List<GameFlag> _subMissionFlags = new List<GameFlag>();

        public List<GameFlag> SubMissionFlags { get => _subMissionFlags; }

        private void OnEnable()
        {
            _mainMissionFlag.IsComplete = false;
            for (int i = 0; i < _subMissionFlags.Count; i++)
            {
                _subMissionFlags[i].IsComplete = false;
            }
        }
    }
}