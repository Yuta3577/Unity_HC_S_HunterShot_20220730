using UnityEngine;


namespace YutaSpace
{
	/// <summary>
	/// ����t��
	/// </summary>
	public class Controlsysteam : MonoBehaviour
	{
		#region ���
		[SerializeField]
		private float speed = 10.5f;
		[SerializeField]
		private int countshootmarble = 10;
		private int speedmarble = 1500;
		private float intervel = 0.5f;
		private GameObject prefabmarble;
		private string parAttack = "Ĳ�o����";
		#endregion
	}
}

