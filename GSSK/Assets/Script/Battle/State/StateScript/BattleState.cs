using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Framework;

namespace Battle
{
    /// <summary>
    /// バトルステート
    /// </summary>
    public class BattleState : StateBase
    {

        override protected void StateInit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleState.StateInit");
        }

        protected override void StateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleState.StateEnter");
        }

        protected override void StateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleState.StateUpdate");
        }

        protected override void StateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleState.StateExit");
        }
    }
}