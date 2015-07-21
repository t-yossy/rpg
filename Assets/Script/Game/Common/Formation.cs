/// *********************************************************************************************************************
/// 
/// @file       KeyBind.cs
/// @desc       �L�[�o�C���h���`����N���X�t�@�C���ł�
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
/// @desc      RPG���O���
/// ============================================================================================
namespace RPG
{
    /// ============================================================================================
    /// @namespace Game
    /// @desc      Game���O���
    /// ============================================================================================
    namespace Game
    {
        /// ============================================================================================
        /// @namespace Common
        /// @desc      Common���O���
        /// ============================================================================================
        namespace Common
        {
            /// <summary>
            /// �w�`���W�p �񋓑�
            /// </summary>
            public enum eFormationCoord
            {
                Row_00=0,Row_01,Row_02,Row_03,Row_04,Row_05,
                Column_00=0,Column_01,Column_02,Column_03,Column04,Column_05,
            }

            /// <summary>
            /// �w�`�s��N���X
            /// </summary>
            public class FormationMatrix
            {
                public FormationMatrix()
                {

                }

                /// <summary>
                /// �w�`�Ŏg�p�\�ȑS�̂̕��ƑS�̂̍������w�肵�āA1�L����������̍��W���v�Z���܂�
                /// </summary>
                /// <param name="w"></param>
                /// <param name="h"></param>
                public void Calculate(int w, int h)
                {

                }

                /// <summary>
                /// �s����w�肵�āA���W���擾���܂�
                /// </summary>
                /// <param name="row"></param>
                /// <param name="column"></param>
                /// <returns></returns>
                public Vector2 GetCoord(eFormationCoord row,eFormationCoord column)
                {
                    return GetCoord((int)row, (int)column);
                }

                /// <summary>
                /// �s��C���f�b�N�X���w�肵�āA���W���擾���܂�
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
            /// �w�`���N���X
            /// </summary>
            public class FormationBase
            {
                public FormationBase()
                {

                }
            }


            /// <summary>
            /// ��l�w�`
            /// </summary>
            public class Only
            {

            }
        }
    }
}