/// *********************************************************************************************************************
/// 
/// @file       InputMouse.cs
/// @desc       マウスによる入力情報を管理するクラスファイルです
/// @date       2015.07.20
/// @copyright  t.yossy
/// 
/// *********************************************************************************************************************
using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// ============================================================================================
/// @namespace RPG
/// @desc      RPG名前空間
/// ============================================================================================
namespace RPG
{
    /// ============================================================================================
    /// @namespace InputData
    /// @desc      InputData名前空間
    /// ============================================================================================
    namespace InputData
    {
        /// <summary>
        /// マウスによる入力情報を管理するクラス
        /// </summary>
        public sealed class InputMouse
        {
            /// <summary>
            /// コンストラクタ
            /// </summary>
            public InputMouse()
            {
            }

            /// <summary>
            /// 引数付きコンストラクタ
            /// </summary>
            /// <param name="pos"></param>
            /// <param name="rotate"></param>
            /// <param name="buttons"></param>
            /// <param name="stats"></param>
            public InputMouse(Vector2 pos, float rotate, int[] buttons, int[] stats)
            {
            }

            /// <summary>
            /// 指定したマウスのボタンの状態を取得します
            /// </summary>
            /// <param name="button"></param>
            /// <returns></returns>
            public int GetButtonStatus(int button)
            {
                return mButtonStatus[button];
            }

            /// <summary>
            /// マウスの位置を取得します
            /// </summary>
            public Vector2 Position
            {
                get { return mPosition; }
                internal set { mPosition = value; }
            }

            /// <summary>
            /// マウス中ボタンのホイールスクロール量を取得します
            /// </summary>
            public float WheelScroll
            {
                get { return mWheelRotate; }
                internal set { mWheelRotate = value; }
            }

            private Vector2                     mPosition;

            private float                       mWheelRotate;

            private Dictionary<int,int>         mButtonStatus;
        }
    }
}

/// *********************************************************************************************************************
/// EOF 

