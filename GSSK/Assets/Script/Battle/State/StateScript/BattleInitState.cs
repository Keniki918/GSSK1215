using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Framework;

namespace Battle
{
    /// <summary>
    /// バトル初期化ステート
    /// </summary>
    public class BattleInitState : StateBase
    {

        override protected void StateInit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleInitState.StateInit");
            //TODO GameObjectを継承していない所でもコルーチン実行できるようにする
            BattleStateManager.Instance.StartCoroutine(WaitCoroutine());
        }

        protected override void StateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleInitState.StateEnter");
        }

        protected override void StateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleInitState.StateUpdate");
        }

        protected override void StateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("テスト_BattleInitState.StateExit");
        }

        /// <summary>
        /// 待機コルーチン
        /// </summary>
        /// <returns></returns>
        private IEnumerator WaitCoroutine()
        {
            yield return new WaitForSeconds(5f);
            BattleStateManager.Instance.ChangeState("Battle");
        }


    }
}