using NUnit.Framework;

namespace Editor.Tests
{
    public class ScoreTest
    {
        private ScorePresenter _scorePresenter;

        [SetUp]
        public void Setup()
        {
            _scorePresenter = new ScorePresenter();
        }

        [Test]
        public void Increase_Score_By_One()
        {
            _scorePresenter.IncreaseScore(1);

            Assert.AreEqual(1, _scorePresenter.Score);
        }

        [Test]
        public void Decrease_Score_By_One()
        {
            _scorePresenter.DecreaseScore(1);

            Assert.AreEqual(-1, _scorePresenter.Score);
        }
    }
}