using System;


namespace MyUtils.Variable {
    [Serializable]
    public class IntReference {
        public bool useConstant = true;
        public int constantValue;
        public IntVariable variable;

        public IntReference() { }

        public IntReference(int value) {
            useConstant = true;
            constantValue = value;
        }

        public int value {
            get { return useConstant ? constantValue : variable.value; }
            set {
                if (useConstant) return;
                variable.value = value;
            }
        }

        public static implicit operator int(IntReference reference) {
            return reference.value;
        }
    }
}