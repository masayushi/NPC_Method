using System.Net.NetworkInformation;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // �D�����
    public int itemPrice;

    // ��o���ȹD��
    public int questItem;


    /// <summary>
    /// ���
    /// </summary>
    private void Dialogue(string conversation)
    {
        print("��ܡG" + conversation);
    }

    /// <summary>
    /// �}�Ұө�
    /// </summary>
    public bool OpenShop()
    {
        return true;
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    public int BuyItem()
    {
        itemPrice = 100;
        return 0;
    }

    /// <summary>
    /// ���o����
    /// </summary>
    public void GetQuest(int mission)
    {
        print("���Ƚs���G" + mission);
    }

    /// <summary>
    /// ���ȧ�s
    /// </summary>
    private int QuestUpdate()
    {
        questItem = 1;
        return 0;
    }

    /// <summary>
    /// ���ȧ���
    /// </summary>
    private bool QuestComplete()
    {
        return false;
    }

    private void Start()
    {
        Dialogue("�Ѯ�ܦn�@~");
        OpenShop();
        BuyItem();
        GetQuest(1);
        int b = BuyItem();
        print("�ȡG" + b);
        QuestUpdate();

    }
}
