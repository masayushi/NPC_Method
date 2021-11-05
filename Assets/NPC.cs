using System.Net.NetworkInformation;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // 道具價錢
    public int itemPrice;

    // 獲得任務道具
    public int questItem;


    /// <summary>
    /// 對話
    /// </summary>
    private void Dialogue(string conversation)
    {
        print("對話：" + conversation);
    }

    /// <summary>
    /// 開啟商店
    /// </summary>
    public bool OpenShop()
    {
        return true;
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    public int BuyItem()
    {
        itemPrice = 100;
        return 0;
    }

    /// <summary>
    /// 取得任務
    /// </summary>
    public void GetQuest(int mission)
    {
        print("任務編號：" + mission);
    }

    /// <summary>
    /// 任務更新
    /// </summary>
    private int QuestUpdate()
    {
        questItem = 1;
        return 0;
    }

    /// <summary>
    /// 任務完成
    /// </summary>
    private bool QuestComplete()
    {
        return false;
    }

    private void Start()
    {
        Dialogue("天氣很好哦~");
        OpenShop();
        BuyItem();
        GetQuest(1);
        int b = BuyItem();
        print("值：" + b);
        QuestUpdate();

    }
}
