using Scriptable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scriptable
{
    public class MissionButton : MonoBehaviour
    {
        [SerializeField]
        private GameEvent _missionEvent;

        public void OnMissionComplete()
        {
            _missionEvent.Raise();
        }
    }
}