using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptable
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/Scriptable/PlayerData", order = 1)]
    public class PlayerData : ScriptableObject
    {
        [SerializeField]
        private string _playerName;

        public string PlayerName { get => _playerName; }

        [SerializeField]
        private int _defaultHP;

        public int DefaultHP { get => _defaultHP; }

        //HP‚ÆHpA‚Ç‚Á‚¿‚ª‚¢‚¢‚Ì‚¾‚ë‚¤‚©...
    }
}
