using System.Collections.Generic;
using UnityEngine;

namespace MyUtils.GameEvent {

    [CreateAssetMenu(fileName = "NewGameEvent", menuName = "Game Event")]
    public class GameEvent : ScriptableObject {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        /// <summary>
        /// The list of listeners that this event will notify if it is raised.
        /// </summary>
        private readonly List<GameEventListener> _eventListenerList = new List<GameEventListener>();

        public void Raise() {
            for (int i = _eventListenerList.Count - 1; i >= 0; i--) {
                _eventListenerList[i].OnEventRaised();
            }
        }

        public void RegisterListener(GameEventListener listener) {
            if (!_eventListenerList.Contains(listener)) {
                _eventListenerList.Add(listener);
            }

        }

        public void UnregisterListener(GameEventListener listener) {
            if (_eventListenerList.Contains(listener)) {
                _eventListenerList.Remove(listener);
            }
        }
    }
}
