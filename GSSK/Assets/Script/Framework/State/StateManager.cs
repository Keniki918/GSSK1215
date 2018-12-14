using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    /// <summary>
    /// ステートマネージャー
    /// </summary>
    public class StateManager : SingletonMonoBehaviour<StateManager>
    {

        [SerializeField]
        Animator _animator; // animator
        [SerializeField]
        string _current;

        protected override void Awake()
        {
            // animator取得
            _animator = this.GetComponent<Animator>();
        }

        /// <summary>
        /// ステート変更
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(string state)
        {
            _current = state;
            _animator.Play(state);
        }

    }
}