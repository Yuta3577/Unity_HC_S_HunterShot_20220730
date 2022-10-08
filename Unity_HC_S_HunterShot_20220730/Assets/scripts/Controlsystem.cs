using UnityEngine;


namespace YutaSpace
{
	/// <summary>
	/// 控制系統
	/// </summary>
	public class Controlsysteam : MonoBehaviour
	{
		#region 資料
		[SerializeField]
		private float speed = 10.5f;
		[SerializeField]
		private int countshootmarble = 10;
		private int speedmarble = 1500;
		private float intervel = 0.5f;
		private GameObject prefabmarble;
		private string parAttack = "觸發攻擊";
		#endregion
	}
}

