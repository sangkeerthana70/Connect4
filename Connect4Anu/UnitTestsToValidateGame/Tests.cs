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
            
        //}

        [Test]
        public void DifferentNumberOfMovesReturnsFalse()
        {
            Game game = new Game(6, 7, 'X', 'O');
            game.GameState[0, 0] = 'X';
            game.GameState[1, 0] = 'O';
            game.GameState[4, 5] = 'X';
            game.GameState[5, 5] = 'O';
            game.GameState[3, 2] = 'O';
            game.GameState[2, 5] = 'O';

            bool expected = false;
            bool actual = game.ValidateBoard();

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SameNumberOfMovesReturnsTrue()
        {
            Game game = new Game(6, 7, 'X', 'O');
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
