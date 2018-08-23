using System;
using System.Collections;

namespace Exercise {
    public class Stack {
        private ArrayList Objects;

        public Stack() {
            Objects = new ArrayList();
        }

        ~Stack() {
            Objects = null;
        }

        public void Push(object obj) {
            if (obj == null) {
                throw new InvalidOperationException("Cannot add a null to the stack");
            }
            Objects.Add(obj);
        }

        public object Pop() {
            if (Objects.Count == 0) {
                throw new InvalidOperationException("Stack is empty");
            }
            object obj = Objects[Objects.Count-1] as object;
            Objects.Remove(obj);
            return obj;
        }

        public void Clear() {
            Objects.Clear();
        }
    }
}