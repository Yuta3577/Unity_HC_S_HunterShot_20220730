using UnityEngine;

namespace YutaSpace
{
    /// <summary>
    /// �ǲ߹B��l�G
    /// 1.�ƾ�
    /// 2.���
    /// 3.�޿�
    /// 4.�T��
    /// </summary>
    public class LearnOperater : MonoBehaviour
    {
        private void Awake()
        {
            OperatorMath();
        }

        public float a = 10, b = 3;

        /// <summary>
        /// �ƾǹB��l
        /// </summary>
        private void OperatorMath()
        {
            //�[�B��B���B���B�l��
            //+�B-�B*�B/�B%
            print("�[�k" + (a + b)); //13
            print("��k" + (a - b)); //7
            print("���k" + (a * b)); //30
            print("���k" + (a / b)); //3.333
            print("�l��" + (a % b)); //1
        }
    }

}


