using NUnit.Framework;
using DrawBoardV4Suerekha;


namespace UnitTestsToValidateGame
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void TestSetUp()
        {
            Board board = new Board();

        }

        [Test]
        public void DifferentNumberOfMovesReturnsFalse()
        {
            // player1 represents 'X' and Palyer2 represents 'O' refer Game constructor
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

        [Test]
        public void FourConsecutiveHorizontalXs_RetunsXAsWinner()
        {
            Game game = new Game(6, 7, 'X', 'O');
            game.GameState[0, 0] = 'X';
            game.GameState[0, 1] = 'X';
            game.GameState[0, 2] = 'X';
            game.GameState[0, 3] = 'X';
            game.GameState[0, 4] = 'X';

            char expected = 'X';
            char actual = game.DetermineWinner();
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FourConsecutiveHorizontalOs_RetunsOAsWinner()
        {
            Game game = new Game(6, 7, 'X', 'O');
            game.GameState[3, 0] = 'O';
            game.GameState[3, 1] = 'O';
            game.GameState[3, 2] = 'O';
            game.GameState[3, 3] = 'O';
            game.GameState[3, 4] = 'O';
            char expected = 'O';
            char actual = game.DetermineWinner();
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);
        }
        /*
        [Test]
        public void FourConsecutiveVerticalXs_RetunXAsWinner()
        {
            Game game = new Game(6, 7, 'X', 'O');
            
            game.GameState[2, 0] = 'X';
            game.GameState[3, 0] = 'X';
            game.GameState[4, 0] = 'X';
            game.GameState[5, 0] = 'X';
            char expected = 'X';
            char actual = game.DetermineWinner();
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void FourConsecutiveVerticalOs_RetunsOAsWinner()
        {
            Game game = new Game(6, 7, 'X', 'O');

            game.GameState[2, 0] = 'O';
            game.GameState[3, 0] = 'O';
            game.GameState[4, 0] = 'O';
            game.GameState[5, 0] = 'O';
            char expected = 'O';
            char actual = game.DetermineWinner();
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void FourConsecutiveDiagonalXs_RetunsXAsWinner()
        {
            Game game = new Game(6, 7, 'X', 'O');

            game.GameState[5, 6] = 'X';
            game.GameState[4, 5] = 'X';
            game.GameState[3, 4] = 'X';
            game.GameState[2, 3] = 'X';
            char expected = 'X';
            char actual = game.DetermineWinner();
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void FourConsecutiveDiagonalOs_RetunsOAsWinner()
        {

            Game game = new Game(6, 7, 'X', 'O');

            game.GameState[5, 6] = 'O';
            game.GameState[4, 5] = 'O';
            game.GameState[3, 4] = 'O';
            game.GameState[2, 3] = 'O';
            char expected = 'O';
            char actual = game.DetermineWinner();
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);

        }
        */
    }
}
