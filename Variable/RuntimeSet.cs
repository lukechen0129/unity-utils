using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyUtils.Variable {
    public abstract class RuntimeSet<T> : ScriptableObject {

        [SerializeRuntimeList]
        [SerializeField]
        private List<T> _itemList = new List<T>();

        public List<T> itemList => _itemList;

        public void Add(T t) {
            if (!_itemList.Contains(t)) {
                _itemList.Add(t);
            }
        }

        public void Remove(T t) {
            if (_itemList.Contains(t)) {
                _itemList.Remove(t);
            }
        }
    }
}