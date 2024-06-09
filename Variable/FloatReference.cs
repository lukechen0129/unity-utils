using System;

namespace MyUtils.Variable {

    [Serializable]
    public class FloatReference {
        public bool useConstant = true;
        public float constantValue;
        public FloatVariable variable;

        public FloatReference() { }

        public FloatReference(float value) {
            useConstant = true;
            constantValue = value;
        }

        public float value {
            get { return useConstant ? constantValue : variable.value; }
            set {
                if (useConstant) return;
                variable.value = value;
            }
        }

        public static implicit operator float(FloatReference reference) {
            return reference.value;
        }
    }
}
