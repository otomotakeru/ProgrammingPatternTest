using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using static NamingConventions.PlayerConstant;

// 別のシーンで同じ名前のクラスを使えるように
// ネームスペースはパスカルケース ("PascalCasing") を使用
namespace NamingConventions
{
    // クラス名はパスカルケース ("PascalCasing") を使用
    public class Player : MonoBehaviour, ITalkable
    {
        // privateなフィールド変数では、キャメル ケース ("camelCasing") を使用
        // また先頭に _ を付ける
        private string _playerName;

        // Unityではpublicなプロパティにキャメル ケース ("camelCasing") を使用するが、
        // C#ではパスカルケース ("PascalCasing") を使用するため名前付けルール違反が出る
        // キャメルケースを使用した場合、下のコンストラクタで引数とプロパティが同じ名前になる
        // その他にもローカル関数で名前が被る可能性も出てくる
        // Unityと合わせることで読み方を統一するか、thisや同じ名前を気にしないかで話し合って決めるべき
        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                if (value.Length > MaxPlayerNameLength)
                {
                    _playerName = value.Substring(0, MaxPlayerNameLength);
                }
                else
                {
                    _playerName = value;
                }
            }
        }

        // インスペクターで使用したい場合はシリアライズ属性を付ける
        [SerializeField]
        private SettingData _settingData;

        // 列挙型はパスカルケース ("PascalCasing") を使用
        enum PlayerState
        {
            // 中身もパスカルケース ("PascalCasing") を使用
            Wait,
            Run
        }

        private PlayerState _playerState;

        // デリゲートはパスカルケース ("PascalCasing") を使用
        public delegate void SampleDelegate();

        // 引数はキャメル ケース ("camelCasing") を使用
        public Player(string playername)
        {
            //playername = playername;
            PlayerName = playername;
        }

        // メソッド名はパスカルケース ("PascalCasing") を使用
        void Start()
        {
            _playerState = PlayerState.Wait;
        }

        // Update is called once per frame
        void Update()
        {
            // 関数内変数は _ を付けないキャメル ケース ("camelCasing") を使用
            bool isMove = false;
            if (Input.GetKey(KeyCode.A))
            {
                isMove = true;
            }
            if (Input.GetKey(KeyCode.D))
            {
                isMove = true;
            }

            if (isMove == true)
            {
                _playerState = PlayerState.Run;
            }
            else
            {
                _playerState = PlayerState.Wait;
            }

            Talk();
        }

        public void Talk()
        {
            switch (_playerState)
            {
                case PlayerState.Wait:
                    Debug.Log("動いていない");
                    break;
                case PlayerState.Run:
                    Debug.Log("走っている");
                    break;
            }
        }
    }
}
