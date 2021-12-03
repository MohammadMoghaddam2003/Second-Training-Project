using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    public static int Coin = 0;
    public Text CoinText;

    void Start()
    {
        CoinText.text = Coin.ToString("000");
    }

    
    void Update()
    {
        CoinText.text = Coin.ToString("000");
    }
}
