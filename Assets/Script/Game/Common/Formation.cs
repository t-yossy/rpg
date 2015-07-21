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
    /// @namespace Game
    /// @desc      Game名前空間
    /// ============================================================================================
    namespace Game
    {
        /// ============================================================================================
        /// @namespace Common
        /// @desc      Common名前空間
        /// ============================================================================================
        namespace Common
        {
            /// <summary>
            /// 陣形座標用 列挙体
            /// </summary>
            public enum eFormationCoord
            {
                Row_00=0,Row_01,Row_02,Row_03,Row_04,Row_05,
                Column_00=0,Column_01,Column_02,Column_03,Column04,Column_05,
            }

            /// <summary>
            /// 陣形行列クラス
            /// </summary>
            public class FormationMatrix
            {
                public FormationMatrix()
                {

                }

                /// <summary>
                /// 陣形で使用可能な全体の幅と全体の高さを指定して、1キャラあたりの座標を計算します
                /// </summary>
                /// <param name="w"></param>
                /// <param name="h"></param>
                public void Calculate(int w, int h)
                {

                }

                /// <summary>
                /// 行列を指定して、座標を取得します
                /// </summary>
                /// <param name="row"></param>
                /// <param name="column"></param>
                /// <returns></returns>
                public Vector2 GetCoord(eFormationCoord row,eFormationCoord column)
                {
                    return GetCoord((int)row, (int)column);
                }

                /// <summary>
                /// 行列インデックスを指定して、座標を取得します
                /// </summary>
                /// <param name="rowIndex"></param>
                /// <param name="columnIndex"></param>
                /// <returns></returns>
                public Vector2 GetCoord(int rowIndex,int columnIndex)
                {
                    if (rowIndex >= mRows.Length || columnIndex >= mColumns.Length) return Vector2.zero;
                    if (rowIndex < 0 || columnIndex < 0) return Vector2.zero;

                    return new Vector2(mRows[rowIndex], mColumns[columnIndex]);
                }

                private float[] mRows;
                private float[] mColumns;
            }

            /// <summary>
            /// 陣形基底クラス
            /// </summary>
            public class FormationBase
            {
                public FormationBase()
                {

                }
            }


            /// <summary>
            /// 一人陣形
            /// </summary>
            public class Only
            {

            }
        }
    }
}