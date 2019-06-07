using NUnit.Framework;
using DrawBoardV4Suerekha;


namespace UnitTestsToValidateGame
{
    [TestFixture]
    public class Tests
    {
        //[SetUp]
        //public void TestSetUp()
        //{
            Board board = new Board();
            Game game = new Game(6, 7, 'X', 'O');
        //}

        [Test]
        public void DifferentNumberOfMovesReturnsFalse()
        {

        }

        [Test]
        public void SameNumberOfMovesReturnsTrue()
        {
            game.GameState[0, 0] = 'X';
            game.GameState[1, 0] = 'O';
            game.GameState[4, 5] = 'X';
            game.GameState[5, 5] = 'O';

            bool expected = true;
            bool actual = game.ValidateBoard();

            Assert.AreEqual(expected, actual);

        }
    }
}
