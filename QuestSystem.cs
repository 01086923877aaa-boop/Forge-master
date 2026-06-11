using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    public int rewardGold = 500;

    public void CompleteQuest()
    {
        GameManager.Instance.AddGold(rewardGold);
        Debug.Log("Quest Completed!");
    }
}