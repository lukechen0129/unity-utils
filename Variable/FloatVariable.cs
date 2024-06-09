using UnityEngine;


namespace MyUtils.Variable {
    [CreateAssetMenu(fileName = "NewFloatVariable", menuName = "Variables/Float")]
    public class FloatVariable : ScriptableObject {

#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public float value;

        public void SetValue(float value) {
            this.value = value;
        }

        public void Setvalue(FloatVariable value) {
            this.value = value.value;
        }

        public void ApplyChange(float amount) {
            this.value += amount;
        }

        public void ApplyChange(FloatVariable amount) {
            this.value += amount.value;
        }
    }
}
