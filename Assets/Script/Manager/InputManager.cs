/// *********************************************************************************************************************
/// 
/// @file       InputManager.cs
/// @desc       ���͏����Ǘ�����N���X�t�@�C���ł�
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
        public sealed class InputManager
        {
            // --------------------------------------------------------------------------------------- 
            // �萔

            /// <summary>
            /// ���͏�����������ۂɗL��������t���O�񋓑�
            /// </summary>
            public enum eInputCompositeFlags
            {
                Mouse       = (1<<0),   //! �}�E�X
                Keyboard    = (1<<1),   //! �L�[�{�[�h
                Touch       = (1<<2),   //! �^�b�`�X�N���[��
                GamePad     = (1<<3),   //! �Q�[���p�b�h
            }

            // --------------------------------------------------------------------------------------- 
            // �����o�[���\�b�h

            /// <summary>
            /// �N���X�C���X�^���X�𐶐����܂�
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
            /// ���̃N���X�̃C���X�^���X ���擾���܂�
            /// </summary>
            public static InputManager Instance
            {
                get { return sInstance; }
            }

            /// <summary>
            /// ���͍������[�h�Ƀ}�E�X���g�p���邩�ǂ��� ���擾���܂�
            /// </summary>
            public bool IsCompositeMouse
            {
                get 
                { 
                    return ((mCompositeFlags & eInputCompositeFlags.Mouse)==eInputCompositeFlags.Mouse) ? true : false; 
                }
            }

            /// <summary>
            /// ���͍������[�h�ɃL�[�{�[�h���g�p���邩�ǂ��� ���擾���܂�
            /// </summary>
            public bool IsCompositeTouchScreen
            {
                get
                {
                    return ((mCompositeFlags & eInputCompositeFlags.Keyboard) == eInputCompositeFlags.Keyboard) ? true : false;
                }
            }

            /// <summary>
            /// ���͍������[�h�ɃQ�[���p�b�h���g�p���邩�ǂ��� ���擾���܂�
            /// </summary>
            public bool IsCompositeGamePad
            {
                get
                {
                    return ((mCompositeFlags & eInputCompositeFlags.GamePad) == eInputCompositeFlags.GamePad) ? true : false;
                }
            }

            /// <summary>
            /// ���͍������[�h�Ƀ^�b�`�X�N���[�����g�p���邩�ǂ��� ���擾���܂�
            /// </summary>
            public bool IsCompositeTouchScreen
            {
                get
                {
                    return ((mCompositeFlags & eInputCompositeFlags.Touch) == eInputCompositeFlags.Touch) ? true : false;
                }
            }

            /// <summary>
            /// ���͏�񍬍��t���O ���擾�܂��͐ݒ肵�܂�
            /// </summary>
            public eInputCompositeFlags CompositeFlags
            {
                get { return mCompositeFlags; }
                set { mCompositeFlags = value; }
            }

            /// <summary>
            /// �h���b�O(�܂��̓X���C�v)�Ƃ��ĔF�����鋗�� ���擾�܂��͐ݒ肵�܂�
            /// </summary>
            public float DragRecognizeDistance
            {
                get { return mDragRecognizeDistance; }
                set { mDragRecognizeDistance = value; }
            }

            // --------------------------------------------------------------------------------------- 
            // �����o�[�t�B�[���h

            /// <summary>
            /// �N���X�C���X�^���X
            /// </summary>
            private static InputManager sInstance = null;

            /// <summary>
            /// ���͏�񍬍��t���O
            /// </summary>
            private eInputCompositeFlags mCompositeFlags;

            /// <summary>
            /// �h���b�O(�܂��̓X���C�v)�Ƃ��ĔF�����鋗��
            /// </summary>
            private float mDragRecognizeDistance;
        }
    }
}

/// *********************************************************************************************************************
/// EOF 
