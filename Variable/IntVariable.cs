using UnityEngine;


namespace MyUtils.Variable {
    [CreateAssetMenu(fileName = "NewIntVariable", menuName = "Variables/Int")]
    public class IntVariable : ScriptableObject {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif
        public int value;

        public void SetValue(int value) {
            this.value = value;
        }

        public void SetValue(IntVariable value) {
            this.value = value.value;
        }

        public void ApplyChange(int amount) {
            this.value += amount;
        }

        public void ApplyChange(IntVariable amount) {
            this.value += amount.value;
        }
    }
}