using UnityEngine;

namespace YutaSpace
{
    /// <summary>
    /// �ˮ`�t�ΡG���Ͷˮ`�Ȫ���A��s�ˮ`�ȻP�ʵe�ĪG
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�ˮ`��")]
        private GameObject prefabDamage;
        [SerializeField, Header("�ˮ`�Ȧ첾")]
        private Vector3 offsetDamage;

        private void Awake()
        {
            SpawnDamageObject();
        }
        /// <summary>
        /// �ͦ��ˮ`�Ȫ���
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
