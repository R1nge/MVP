using System;
using UnityEngine;

public class ScorePresenter
{
    private int _score;
    public int Score => _score;

    public event Action<int> OnScoreChanged;

    public void IncreaseScore(int amount)
    {
        if (amount == 0)
        {
            Debug.LogError("Trying to add 0");
            return;
        }

        if (amount < 0)
        {
            Debug.LogError("Trying to add a negative value");
            return;
        }

        _score += amount;
        Notify();
    }

    public void DecreaseScore(int amount)
    {
        if (amount == 0)
        {
            Debug.LogError("Trying to add 0");
            return;
        }

        if (amount < 0)
        {
            Debug.LogError("Trying to add a negative value");
            return;
        }

        _score -= amount;
        Notify();
    }

    private void Notify() => OnScoreChanged?.Invoke(_score);
}