using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NamingConventions
{
    // �t�@�C�����ɂ̓N���X�����A���j���[���ɂ̓l�[���X�y�[�X/�N���X��(�O���[�o���X�y�[�X�Ȃ�l�[���X�y�[�X���ȗ�)
    [CreateAssetMenu(fileName = "SettingData", menuName = "ScriptableObjects/NamingConventions/SettingData", order = 1)]
    public class SettingData : ScriptableObject
    {
        // public�ϐ��� _ ��t���Ȃ��L������ �P�[�X ("camelCasing") ���g�p
        public float soundVolume;
    }
}