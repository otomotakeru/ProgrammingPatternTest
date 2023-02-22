using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PerfectBool
{
    /// <summary>
    /// �ėp���A�g�������ӎ�����bool�̎���
    /// </summary>
    public class PerfectBool : MonoBehaviour
    {
        private bool m_isBoolTrue;

        public bool IsBoolTrue {
            get {
                m_logText = "�N���ɃA�N�Z�X���ꂽ";
                m_detailsLogText = "";
                if (m_isBoolTrue)
                {
                    m_descriptionLogText = "true��Ԃ���";
                }
                else
                {
                    m_descriptionLogText = "false��Ԃ���";
                }
                return m_isBoolTrue;
            }
            set {
                m_logText = "�N���ɑ�����ꂽ";
                if (value != m_isBoolTrue)
                {
                    m_detailsLogText = "�O��ƈႤ�l�ő�����ꂽ";
                    if (value)
                    {
                        m_descriptionLogText = "true�ɂȂ���";
                    }
                    else
                    {
                        m_descriptionLogText = "false�ɂȂ���";
                    }
                }
                else
                {
                    m_detailsLogText = "�O��Ɠ����l�ő�����ꂽ";
                    if (value)
                    {
                        m_descriptionLogText = "true�̂܂܂�";
                    }
                    else
                    {
                        m_descriptionLogText = "false�̂܂܂�";
                    }
                }
                m_isBoolTrue = value;
            }
        }

        //���ʕ\��
        string m_logText;
        string m_detailsLogText;
        string m_descriptionLogText;

        GUIStyle m_guiStyle;

        private void Start()
        {
            m_guiStyle = new GUIStyle();
            m_guiStyle.fontSize = 30;
            m_guiStyle.normal.textColor = Color.white;
        }

        private void OnGUI()
        {
            GUILayout.Label($"{m_logText}", m_guiStyle);
            GUILayout.Label($"{m_detailsLogText}", m_guiStyle);
            GUILayout.Label($"{m_descriptionLogText}", m_guiStyle);
        }

        public void GetBoolTest()
        {
            _ = IsBoolTrue;
        }
    }
}