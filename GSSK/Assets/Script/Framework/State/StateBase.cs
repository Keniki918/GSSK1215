using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    /// <summary>
    /// ステート(基底)
    /// </summary>
    public class StateBase : StateMachineBehaviour
    {
        [SerializeField]
        private bool _isInit = false;
        [SerializeField]
        protected string _stateName;

        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (!_isInit)
            {
                _isInit = true;
                Debug.Log("init " + _stateName);
                StateInit(animator, stateInfo, layerIndex);
            }
            StateEnter(animator, stateInfo, layerIndex);
        }

        /// <summary>
        /// ステート初期化
        /// </summary>
        /// <param name="animator"></param>
        /// <param name="stateInfo"></param>
        /// <param name="layerIndex"></param>
        protected virtual void StateInit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }

        /// <summary>
        /// ステート開始
        /// </summary>
        /// <param name="animator"></param>
        /// <param name="stateInfo"></param>
        /// <param name="layerIndex"></param>
        protected virtual void StateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("update " + _stateName);
            StateUpdate(animator, stateInfo, layerIndex);
        }

        /// <summary>
        /// ステート更新
        /// </summary>
        /// <param name="animator"></param>
        /// <param name="stateInfo"></param>
        /// <param name="layerIndex"></param>
        protected virtual void StateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("exit " + _stateName);
            StateExit(animator, stateInfo, layerIndex);
        }

        /// <summary>
        /// ステート終了
        /// </summary>
        /// <param name="animator"></param>
        /// <param name="stateInfo"></param>
        /// <param name="layerIndex"></param>
        protected virtual void StateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

        }
    }
}