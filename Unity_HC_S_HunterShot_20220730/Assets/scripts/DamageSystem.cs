using UnityEngine;

namespace YutaSpace
{
    /// <summary>
    /// 傷害系統：產生傷害值物件，更新傷害值與動畫效果
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("傷害值")]
        private GameObject prefabDamage;
        [SerializeField, Header("傷害值位移")]
        private Vector3 offsetDamage;

        private void Awake()
        {
            SpawnDamageObject();
        }
        /// <summary>
        /// 生成傷害值物件
        /// </summary>
        private void SpawnDamageObject()
        {
            Instantiate(
                prefabDamage,
                transform.position + offsetDamage,
                Quaternion.Euler(50, 0, 0));
        }
    }
}
