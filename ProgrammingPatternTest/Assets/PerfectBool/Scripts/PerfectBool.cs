using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PerfectBool
{
    /// <summary>
    /// 汎用性、拡張性を意識したboolの実装
    /// </summary>
    public class PerfectBool : MonoBehaviour
    {
        private bool m_isBoolTrue;

        public bool IsBoolTrue {
            get {
                m_logText = "誰かにアクセスされた";
                m_detailsLogText = "";
                if (m_isBoolTrue)
                {
                    m_descriptionLogText = "trueを返した";
                }
                else
                {
                    m_descriptionLogText = "falseを返した";
                }
                return m_isBoolTrue;
            }
            set {
                m_logText = "誰かに代入された";
                if (value != m_isBoolTrue)
                {
                    m_detailsLogText = "前回と違う値で代入された";
                    if (value)
                    {
                        m_descriptionLogText = "trueになった";
                    }
                    else
                    {
                        m_descriptionLogText = "falseになった";
                    }
                }
                else
                {
                    m_detailsLogText = "前回と同じ値で代入された";
                    if (value)
                    {
                        m_descriptionLogText = "trueのままだ";
                    }
                    else
                    {
                        m_descriptionLogText = "falseのままだ";
                    }
                }
                m_isBoolTrue = value;
            }
        }

        //結果表示
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