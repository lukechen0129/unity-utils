using UnityEngine;
using UnityEditor;

namespace MyUtils.GameEvent {

    [CustomEditor(typeof(GameEvent))]
    public class GameEventRaiseButton : Editor {
        public override void OnInspectorGUI() {
            DrawDefaultInspector();

            GameEvent gameEvent = (GameEvent)target;
            if (GUILayout.Button("Raise")) {
                gameEvent.Raise();
            }
        }
    }
}
