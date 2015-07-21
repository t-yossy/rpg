/// *********************************************************************************************************************
/// 
/// @file       InputMouse.cs
/// @desc       �}�E�X�ɂ����͏����Ǘ�����N���X�t�@�C���ł�
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
    /// @namespace InputData
    /// @desc      InputData���O���
    /// ============================================================================================
    namespace InputData
    {
        /// <summary>
        /// �}�E�X�ɂ����͏����Ǘ�����N���X
        /// </summary>
        public sealed class InputMouse
        {
            /// <summary>
            /// �R���X�g���N�^
            /// </summary>
            public InputMouse()
            {
            }

            /// <summary>
            /// �����t���R���X�g���N�^
            /// </summary>
            /// <param name="pos"></param>
            /// <param name="rotate"></param>
            /// <param name="buttons"></param>
            /// <param name="stats"></param>
            public InputMouse(Vector2 pos, float rotate, int[] buttons, int[] stats)
            {
            }

            /// <summary>
            /// �w�肵���}�E�X�̃{�^���̏�Ԃ��擾���܂�
            /// </summary>
            /// <param name="button"></param>
            /// <returns></returns>
            public int GetButtonStatus(int button)
            {
                return mButtonStatus[button];
            }

            /// <summary>
            /// �}�E�X�̈ʒu���擾���܂�
            /// </summary>
            public Vector2 Position
            {
                get { return mPosition; }
                internal set { mPosition = value; }
            }

            /// <summary>
            /// �}�E�X���{�^���̃z�C�[���X�N���[���ʂ��擾���܂�
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
