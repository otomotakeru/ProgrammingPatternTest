using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using static NamingConventions.PlayerConstant;

// �ʂ̃V�[���œ������O�̃N���X���g����悤��
// �l�[���X�y�[�X�̓p�X�J���P�[�X ("PascalCasing") ���g�p
namespace NamingConventions
{
    // �N���X���̓p�X�J���P�[�X ("PascalCasing") ���g�p
    public class Player : MonoBehaviour, ITalkable
    {
        // private�ȃt�B�[���h�ϐ��ł́A�L������ �P�[�X ("camelCasing") ���g�p
        // �܂��擪�� _ ��t����
        private string _playerName;

        // Unity�ł�public�ȃv���p�e�B�ɃL������ �P�[�X ("camelCasing") ���g�p���邪�A
        // C#�ł̓p�X�J���P�[�X ("PascalCasing") ���g�p���邽�ߖ��O�t�����[���ᔽ���o��
        // �L�������P�[�X���g�p�����ꍇ�A���̃R���X�g���N�^�ň����ƃv���p�e�B���������O�ɂȂ�
        // ���̑��ɂ����[�J���֐��Ŗ��O�����\�����o�Ă���
        // Unity�ƍ��킹�邱�Ƃœǂݕ��𓝈ꂷ�邩�Athis�⓯�����O���C�ɂ��Ȃ����Řb�������Č��߂�ׂ�
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

        // �C���X�y�N�^�[�Ŏg�p�������ꍇ�̓V���A���C�Y������t����
        [SerializeField]
        private SettingData _settingData;

        // �񋓌^�̓p�X�J���P�[�X ("PascalCasing") ���g�p
        enum PlayerState
        {
            // ���g���p�X�J���P�[�X ("PascalCasing") ���g�p
            Wait,
            Run
        }

        private PlayerState _playerState;

        // �f���Q�[�g�̓p�X�J���P�[�X ("PascalCasing") ���g�p
        public delegate void SampleDelegate();

        // �����̓L������ �P�[�X ("camelCasing") ���g�p
        public Player(string playername)
        {
            //playername = playername;
            PlayerName = playername;
        }

        // ���\�b�h���̓p�X�J���P�[�X ("PascalCasing") ���g�p
        void Start()
        {
            _playerState = PlayerState.Wait;
        }

        // Update is called once per frame
        void Update()
        {
            // �֐����ϐ��� _ ��t���Ȃ��L������ �P�[�X ("camelCasing") ���g�p
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
                    Debug.Log("�����Ă��Ȃ�");
                    break;
                case PlayerState.Run:
                    Debug.Log("�����Ă���");
                    break;
            }
        }
    }
}
