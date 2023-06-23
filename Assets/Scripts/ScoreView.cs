using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private ScorePresenter _scorePresenter;

     private void Awake()
     {
         _scorePresenter = new ScorePresenter();
         _scorePresenter.OnScoreChanged += UpdateScore;
     }

     public void IncreaseScore() => _scorePresenter.IncreaseScore(1);
    
     public void DecreaseScore() => _scorePresenter.DecreaseScore(1);

     private void UpdateScore(int score) => scoreText.text = score.ToString();

    private void OnDestroy()
    {
        _scorePresenter.OnScoreChanged -= UpdateScore;
    }
}