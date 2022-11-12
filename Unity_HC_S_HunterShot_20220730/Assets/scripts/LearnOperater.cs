using UnityEngine;

namespace YutaSpace
{
    /// <summary>
    /// 學習運算子：
    /// 1.數學
    /// 2.比較
    /// 3.邏輯
    /// 4.三元
    /// </summary>
    public class LearnOperater : MonoBehaviour
    {
        private void Awake()
        {
            OperatorMath();
        }

        public float a = 10, b = 3;

        /// <summary>
        /// 數學運算子
        /// </summary>
        private void OperatorMath()
        {
            //加、減、乘、除、餘數
            //+、-、*、/、%
            print("加法" + (a + b)); //13
            print("減法" + (a - b)); //7
            print("乘法" + (a * b)); //30
            print("除法" + (a / b)); //3.333
            print("餘數" + (a % b)); //1
        }
    }

}


