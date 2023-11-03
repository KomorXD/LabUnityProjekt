using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance {  get; private set; }

    [SerializeField] private Difficulty difficulty;
    public Difficulty GameDifficulty { get => difficulty; set => difficulty = value; }

    [SerializeField] private string username;
    public string Username { get => username; set => username = value; }

    [SerializeField] private bool playerWon;
    public bool PlayerWon { get => playerWon; set => playerWon = value; }

    private void Awake()
    {
        if(Instance != null)
        {
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
