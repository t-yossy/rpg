/// *********************************************************************************************************************
/// 
/// @file       InputManager.cs
/// @desc       入力情報を管理するクラスファイルです
/// @date       2015.07.20
/// @copyright  t.yossy
/// 
/// *********************************************************************************************************************
using System;
using UnityEngine;
using System.Collections;

/// ============================================================================================
/// @namespace RPG
/// @desc      RPG名前空間
/// ============================================================================================
namespace RPG
{

    /// ============================================================================================
    /// @namespace Manager 
    /// @desc      マネージャー名前空間
    /// ============================================================================================
    namespace Manager
    {
        /// <summary>
        /// テクスチャマネージャークラス
        /// </summary>
        public sealed class InputManager
        {
            // --------------------------------------------------------------------------------------- 
            // 定数

            /// <summary>
            /// 入力情報を混合する際に有効化するフラグ列挙体
            /// </summary>
            public enum eInputCompositeFlags
            {
                Mouse       = (1<<0),   //! マウス
                Keyboard    = (1<<1),   //! キーボード
                Touch       = (1<<2),   //! タッチスクリーン
                GamePad     = (1<<3),   //! ゲームパッド
            }

            // --------------------------------------------------------------------------------------- 
            // メンバーメソッド

            /// <summary>
            /// クラスインスタンスを生成します
            /// </summary>
            /// <returns></returns>
            public static bool CreateInstance()
            {
                if( sInstance == null )
                {
                    sInstance = new InputManager();
                    return true;
                }
                else if( sInstance != null )
                {
                    return true;
                }

                return false;
            }

            /// <summary>
            /// このクラスのインスタンス を取得します
            /// </summary>
            public static InputManager Instance
            {
                get { return sInstance; }
            }

            /// <summary>
            /// 入力混合モードにマウスを使用するかどうか を取得します
            /// </summary>
            public bool IsCompositeMouse
            {
                get 
                { 
                    return ((mCompositeFlags & eInputCompositeFlags.Mouse)==eInputCompositeFlags.Mouse) ? true : false; 
                }
            }

            /// <summary>
            /// 入力混合モードにキーボードを使用するかどうか を取得します
            /// </summary>
            public bool IsCompositeTouchScreen
            {
                get
                {
                    return ((mCompositeFlags & eInputCompositeFlags.Keyboard) == eInputCompositeFlags.Keyboard) ? true : false;
                }
            }

            /// <summary>
            /// 入力混合モードにゲームパッドを使用するかどうか を取得します
            /// </summary>
            public bool IsCompositeGamePad
            {
                get
                {
                    return ((mCompositeFlags & eInputCompositeFlags.GamePad) == eInputCompositeFlags.GamePad) ? true : false;
                }
            }

            /// <summary>
            /// 入力混合モードにタッチスクリーンを使用するかどうか を取得します
            /// </summary>
            public bool IsCompositeTouchScreen
            {
                get
                {
                    return ((mCompositeFlags & eInputCompositeFlags.Touch) == eInputCompositeFlags.Touch) ? true : false;
                }
            }

            /// <summary>
            /// 入力情報混合フラグ を取得または設定します
            /// </summary>
            public eInputCompositeFlags CompositeFlags
            {
                get { return mCompositeFlags; }
                set { mCompositeFlags = value; }
            }

            /// <summary>
            /// ドラッグ(またはスワイプ)として認識する距離 を取得または設定します
            /// </summary>
            public float DragRecognizeDistance
            {
                get { return mDragRecognizeDistance; }
                set { mDragRecognizeDistance = value; }
            }

            // --------------------------------------------------------------------------------------- 
            // メンバーフィールド

            /// <summary>
            /// クラスインスタンス
            /// </summary>
            private static InputManager sInstance = null;

            /// <summary>
            /// 入力情報混合フラグ
            /// </summary>
            private eInputCompositeFlags mCompositeFlags;

            /// <summary>
            /// ドラッグ(またはスワイプ)として認識する距離
            /// </summary>
            private float mDragRecognizeDistance;
        }
    }
}

/// *********************************************************************************************************************
/// EOF 

