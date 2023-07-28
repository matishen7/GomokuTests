using Gomoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gomoku.Models.Cell;

namespace GomokuTests
{
    public class BoardTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Board_SetGridSize()
        {
            var board = new Board();
            board.SetGridSize(10);
            Assert.That(board.GetGridSize, Is.EqualTo(10));
        }

        [Test]
        public void Board_EndOfGame()
        {
            var board = new Board();
            Assert.That(board.IsEndOfGame(), Is.EqualTo(false));
        }

        [Test]
        public void Board_IsHorizontalWin()
        {
            var board = new Board();
            Assert.That(board.GetGridSize, Is.EqualTo(15));
            Assert.That(board.IsEndOfGame(), Is.EqualTo(false));
            var player1 = new HumanPlayer("John");
            
            player1.Move(board, 0, 0);
            board.CheckForWin(0, 0);
            var end = board.IsEndOfGame();
            Assert.That(end, Is.False);
            
            player1.Move(board, 0, 1);
            board.CheckForWin(0, 1);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 0, 2);
            board.CheckForWin(0, 2);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);
            
            player1.Move(board, 0, 3);
            board.CheckForWin(0, 3);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 0, 4);
            board.CheckForWin(0, 4);
            end = board.IsEndOfGame();
            Assert.That(end, Is.True);
        }

        [Test]
        public void Board_IsVerticalWin()
        {
            var board = new Board();
            Assert.That(board.GetGridSize, Is.EqualTo(15));
            Assert.That(board.IsEndOfGame(), Is.EqualTo(false));
            var player1 = new HumanPlayer("John");

            player1.Move(board, 0, 0);
            board.CheckForWin(0, 0);
            var end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 1, 0);
            board.CheckForWin(1, 0);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 2, 0);
            board.CheckForWin(2, 0);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 3, 0);
            board.CheckForWin(3, 0);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 4, 0);
            board.CheckForWin(4, 0);
            end = board.IsEndOfGame();
            Assert.That(end, Is.True);
        }

        [Test]
        public void Board_IsDiagonalDownWin()
        {
            var board = new Board();
            Assert.That(board.GetGridSize, Is.EqualTo(15));
            Assert.That(board.IsEndOfGame(), Is.EqualTo(false));
            var player1 = new HumanPlayer("John");

            player1.Move(board, 0, 0);
            board.CheckForWin(0, 0);
            var end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 1, 1);
            board.CheckForWin(1, 1);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 2, 2);
            board.CheckForWin(2, 2);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 3, 3);
            board.CheckForWin(3, 3);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 4, 4);
            board.CheckForWin(4, 4);
            end = board.IsEndOfGame();
            Assert.That(end, Is.True);
        }

        [Test]
        public void Board_IsDiagonalUpWin()
        {
            var board = new Board();
            Assert.That(board.GetGridSize, Is.EqualTo(15));
            Assert.That(board.IsEndOfGame(), Is.EqualTo(false));
            var player1 = new HumanPlayer("John");

            player1.Move(board, 0, 4);
            board.CheckForWin(0, 4);
            var end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 1, 3);
            board.CheckForWin(1, 3);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 2, 2);
            board.CheckForWin(2, 2);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 3, 1);
            board.CheckForWin(3, 1);
            end = board.IsEndOfGame();
            Assert.That(end, Is.False);

            player1.Move(board, 4, 0);
            board.CheckForWin(4, 0);
            end = board.IsEndOfGame();
            Assert.That(end, Is.True);
        }
    }
}
