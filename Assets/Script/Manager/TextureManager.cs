/// *********************************************************************************************************************
/// 
/// @file       TextureManager.cs
/// @desc       �e�N�X�`�����Ǘ�����N���X�t�@�C���ł�
/// @date       2015.07.20
/// @copyright  t.yossy
/// 
/// *********************************************************************************************************************
using System;
using UnityEngine;
using System.Collections;

/// ============================================================================================
/// @namespace RPG
/// @desc      RPG���O���
/// ============================================================================================
namespace RPG
{

    /// ============================================================================================
    /// @namespace Manager 
    /// @desc      �}�l�[�W���[���O���
    /// ============================================================================================
    namespace Manager
    {
        /// <summary>
        /// �e�N�X�`���}�l�[�W���[�N���X
        /// </summary>
        public sealed class TextureManager
        {
            /// <summary>
            /// ���̃N���X�̃C���X�^���X���擾���܂�
            /// </summary>
            public static TextureManager Instance
            {
                get { return sInstance; }
            }

            private static TextureManager sInstance = null;
        }
    }
}

/// *********************************************************************************************************************
/// EOF 
