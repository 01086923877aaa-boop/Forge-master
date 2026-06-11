using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    public int forgeLevel = 1;
    public int upgradeCost = 100;

    public void UpgradeForge()
    {
        if(GameManager.Instance.gold >= upgradeCost)
        {
            GameManager.Instance.gold -= upgradeCost;
            forgeLevel++;

            upgradeCost *= 2;

            Debug.Log("Forge Upgraded!");
        }
    }
}