// ������
using UnityEngine; // �ޥ�Unity�C�������R�W�Ŷ��G�ܮw��θ�ƻP�\��

// �}�� = ���O
/*
 * �h�����
 * �h�����
 */

namespace YutaSpace
{
    // Unity ���O�n���楲����b�C������W
    /// <summary>
    /// �K�n�G���U�����åB�|�X�{�b�sĶ�����ܤW
    /// first scripts �Ĥ@�Ӹ}���ǲ� C# ��¦�P Unity
    /// </summary>
    public class firstscripts : MonoBehaviour
    {
        #region ��ưϰ�
        //���
        //���
        #endregion

        #region �ƥ�ϰ�GUnity �J�f
        /// <summary>
        /// ����ƥ�G�C���}�l�ɨåB�b start �e����@��
        /// </summary>
        private void Awake()
        {
            print("���o�A�U�w:D");
        }

        /// <summary>
        /// �}�l�ƥ�G�C���}�l�ɨåB�b Awake �����@��
        /// </summary>
        private void Start()
        {
            print("�}�l�ƥ�I");
            // Rich Text
            print("<color=yellow>�����r</color>");
        }
        #endregion
    }
}

