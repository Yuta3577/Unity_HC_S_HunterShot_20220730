﻿using UnityEngine;


namespace YutaSpace
{
	/// <summary>
	/// 控制系統
	/// </summary>
	public class Controlsysteam : MonoBehaviour
	{
		#region 資料
		[SerializeField, Range(0,50)]
		private float speed = 10.5f;
		[SerializeField]
		private int countshootmarble = 10;
		[SerializeField, Range(0, 5000)]
		private int speedmarble = 1500;
		[SerializeField, Range(0, 3)]
		private float intervel = 0.5f;
		[SerializeField, Header("彈珠預製物")]
		private GameObject prefabmarble;

		private string parAttack = "觸發攻擊";
        #endregion

        #region 方法
		/// <summary>
		/// 旋轉角色
		/// </summary>
		private void TurnCharacter()
        {

        }

		/// <summary>
		/// 發射彈珠
		/// </summary>
		private void ShootMarble()
        {

        }

		/// <summary>
		/// 生成彈珠
		/// </summary>
		/// <param name="countToSpawn">生成彈珠的數量</param>
		private void SpawnMarble(int countToSpawn)
        {

        }
        #endregion
    }
}

