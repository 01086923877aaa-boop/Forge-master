using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public void SaveGame()
    {
        PlayerPrefs.SetInt("Gold", GameManager.Instance.gold);
        PlayerPrefs.Save();
    }

    public void LoadGame()
    {
        GameManager.Instance.gold = PlayerPrefs.GetInt("Gold", 0);
    }
}