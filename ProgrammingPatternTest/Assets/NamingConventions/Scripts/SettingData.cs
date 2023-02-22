using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NamingConventions
{
    // ファイル名にはクラス名を、メニュー名にはネームスペース/クラス名(グローバルスペースならネームスペースを省略)
    [CreateAssetMenu(fileName = "SettingData", menuName = "ScriptableObjects/NamingConventions/SettingData", order = 1)]
    public class SettingData : ScriptableObject
    {
        // public変数は _ を付けないキャメル ケース ("camelCasing") を使用
        public float soundVolume;
    }
}