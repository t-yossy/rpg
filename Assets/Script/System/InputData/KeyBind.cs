/// *********************************************************************************************************************
/// 
/// @file       KeyBind.cs
/// @desc       キーバインドを定義するクラスファイルです
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
        /// キーインデックス 列挙体
        /// </summary>
        public enum eKeyIndex : int
        {
            ///basic buttons
            LeftClick = 0, 
            RightClick, MiddleClick,

            ///extension buttons
            Button00, Button01, Button02, Button03,
            Button04, Button05, Button06, Button07,
        
            
        }

        /// <summary>
        /// マウスキーバインドクラス
        /// </summary>
        public class MouseKeyBind
        {
            public MouseKeyBind()
            {

            }
        }

        /// <summary>
        /// キーボードキーバインドクラス
        /// </summary>
        public class KeyboardKeyBind
        {

        }

        /// <summary>
        /// タッチスクリーンキーバインドクラス
        /// </summary>
        public class TouchKeyBind
        {

        }

        /// <summary>
        /// ゲームパッドキーバインドクラス
        /// </summary>
        public class GamePadKeyBind
        {

        }
    }
}

/// *********************************************************************************************************************
/// EOF 

