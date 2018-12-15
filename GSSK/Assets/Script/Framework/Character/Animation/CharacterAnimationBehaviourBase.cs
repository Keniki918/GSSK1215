using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Framework
{
    /// <summary>
    /// キャラクター単位アニメーション管理クラス
    /// </summary>
    public class CharacterAnimationBehaviourBase : MonoBehaviour
    {
        protected Animator _animator;
        // Use this for initialization
        void Awake()
        {
            // Animator取得
            this._animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            // テストコード
            if (Input.GetKey("up"))
            {
                _animator.SetBool("walk", true);
            }
            else
            {
                _animator.SetBool("walk", false);
            }

            _animator.SetBool("attack", Input.GetKey("a"));
        }

        public void Hit()        // ヒット時のアニメーションイベント（今のところからっぽ。ないとエラーが出る）
        {

        }
    }
}