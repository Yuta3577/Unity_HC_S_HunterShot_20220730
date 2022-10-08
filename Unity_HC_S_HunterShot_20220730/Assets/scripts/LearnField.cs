using UnityEngine;

namespace YutaSpace
{
    /// <summary>
    /// �ǲ���� Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        #region ���y�k�B�׹����P�|�j����
        //���y�k�G
        //�׹��� ������� ���W��;
        private int number;

        //�׹��� ������� ���W�� ���w ��;
        private int level = 1;

        //�p�H�G�����O�i�H�s���A���|��ܦb�ݩʭ��O
        private int scoreA = 60;

        //���}�G�Ҧ����O�i�H�s���A�|��ܦb�ݩʭ��O
        //��� int
        public int scoreB = 90;
        //�B�I�� float
        public float speed = 3.5f;
        //�r�� string
        public string weapon = "���b��";
        //���L��
        public bool isDead = false;
        public bool isGrounded = true;
        #endregion


        #region Unity �`������
        //�V�q
        public Vector2 v2Position;
        public Vector2 v2One = Vector2.one;
        public Vector2 v2Custom = new Vector2(7.5f, 9.9f);

        public Vector3 v3Custom = new Vector3(1, 2, 3);
        public Vector4 v4Custom = new Vector4(9, 8, 7, 6);

        //�C��
        public Color colorDefault;
        public Color colorRed=Color.red;
        public Color colorCustom=new Color(1,0,1);
        public Color colorCustomRGBA=new Color(0,1,0,0.5f);

        //�C�|��� ����
        public KeyCode keyA = KeyCode.A;
        public KeyCode keyJump = KeyCode.Space;
        public KeyCode keyFire = KeyCode.Mouse0;

        //���������G������w�ȡA����z�L API ���o�Ϊ̦b�ݩʭ��O�즲
        public AudioClip soundAttack;
        public Sprite pictureWin;
        public Material materiaDissolve;

        //�C������G���h���O�P�M��������ιw�s��
        public GameObject goPurple;
        public GameObject prefabmarble;

        //����
        public ParticleSystem psLight;
        public Camera mainCamera;

		#endregion

		private void Awake()
		{
            //�� ���o��� Get
            //���W��
            //�HUnity�ݩʭ��O�Ȭ��D
            print(level);
            print("�t�סG" + speed);

            //�s �s���� Set
            //���W�� ���w ��
            weapon = "��h�u";
            scoreB = 10;
            speed = 105f;
            isDead = true;
		}

        #region ����ݩ� Flied Attritube
        [Header("���D")]
        public int testint = 10;
        [Tooltip("�ڬO���ܡC")]
        public float testFloat = 35f;
        [Range(10,100)]
        public int numberTest = 99;
        [Range(2.5f, 7.5f)]
        public float numberFloatTest = 5.5f;
        //Range �u���b��ƻP�B���I�W

        [SerializeField]
        private string weaponName = "���u�M";
		#endregion
	}

}
