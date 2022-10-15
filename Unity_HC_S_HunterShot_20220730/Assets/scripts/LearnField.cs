﻿using UnityEngine;

namespace YutaSpace
{
    /// <summary>
    /// 學習欄位 Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        #region 欄位語法、修飾詞與四大類型
        //欄位語法：
        //修飾詞 資料類型 欄位名稱;
        private int number;

        //修飾詞 資料類型 欄位名稱 指定 值;
        private int level = 1;

        //私人：此類別可以存取，不會顯示在屬性面板
        private int scoreA = 60;

        //公開：所有類別可以存取，會顯示在屬性面板
        //整數 int
        public int scoreB = 90;
        //浮點數 float
        public float speed = 3.5f;
        //字串 string
        public string weapon = "火箭筒";
        //布林值
        public bool isDead = false;
        public bool isGrounded = true;
        #endregion


        #region Unity 常用類型
        //向量
        public Vector2 v2Position;
        public Vector2 v2One = Vector2.one;
        public Vector2 v2Custom = new Vector2(7.5f, 9.9f);

        public Vector3 v3Custom = new Vector3(1, 2, 3);
        public Vector4 v4Custom = new Vector4(9, 8, 7, 6);

        //顏色
        public Color colorDefault;
        public Color colorRed=Color.red;
        public Color colorCustom=new Color(1,0,1);
        public Color colorCustomRGBA=new Color(0,1,0,0.5f);

        //列舉資料 按鍵
        public KeyCode keyA = KeyCode.A;
        public KeyCode keyJump = KeyCode.Space;
        public KeyCode keyFire = KeyCode.Mouse0;

        //素材類型：不能指定值，必續透過 API 取得或者在屬性面板拖曳
        public AudioClip soundAttack;
        public Sprite pictureWin;
        public Material materiaDissolve;

        //遊戲物件：階層面板與專內的物件或預製物
        public GameObject goPurple;
        public GameObject prefabmarble;

        //元件
        public ParticleSystem psLight;
        public Camera mainCamera;

		#endregion

		private void Awake()
		{
            //取 取得資料 Get
            //欄位名稱
            //以Unity屬性面板值為主
            print(level);
            print("速度：" + speed);

            //存 存放資料 Set
            //欄位名稱 指定 值
            weapon = "手榴彈";
            scoreB = 10;
            speed = 105f;
            isDead = true;
		}

        #region 欄位屬性 Flied Attritube
        [Header("標題")]
        public int testint = 10;
        [Tooltip("我是提示。")]
        public float testFloat = 35f;
        [Range(10,100)]
        public int numberTest = 99;
        [Range(2.5f, 7.5f)]
        public float numberFloatTest = 5.5f;
        //Range 只能放在整數與浮動點上

        [SerializeField]
        private string weaponName = "美工刀";
		#endregion
	}

}
