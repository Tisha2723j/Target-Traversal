using UnityEngine;
using UnityEngine.UI;

public class ChancesManager : MonoBehaviour
{
    public Text chancesText;
    public int maxChances = 10;
    private int remainingChances;

    void Start()
    {
        remainingChances = maxChances;
        UpdateChancesText();
    }

    public void DecreaseChances()
    {
        remainingChances--;
        UpdateChancesText();

        if (remainingChances <= 0)
        {
            // Game Over logic
        }
    }

    void UpdateChancesText()
    {
        chancesText.text = "Chances: " + remainingChances;
    }
}