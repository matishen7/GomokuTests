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
        IScreen screen;
        [SetUp]
        public void Setup()
        {
            screen = new ConsoleScreen();
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
            var board = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(board.GetGridSize, Is.EqualTo(10));

            var screenMock = new MockScreen();
            screenMock.SetUserInput("0", "0");
            var hp = new HumanPlayer("John", StoneColor.White, screenMock);
            var move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("0", "1");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("0", "2");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("0", "3");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("0", "4");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.True);
        }

        [Test]
        public void Board_IsVerticalWin()
        {
            var board = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(board.GetGridSize, Is.EqualTo(10));

            var screenMock = new MockScreen();
            screenMock.SetUserInput("0", "0");
            var hp = new HumanPlayer("John", StoneColor.White, screenMock);
            var move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("1", "0");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("2", "0");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("3", "0");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("4", "0");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.True);

        }

        [Test]
        public void Board_IsDiagonalDownWin()
        {
            var board = new BoardBuilder()
               .WithGridSize(10)
               .Build();
            Assert.That(board.GetGridSize, Is.EqualTo(10));

            var screenMock = new MockScreen();
            screenMock.SetUserInput("0", "0");
            var hp = new HumanPlayer("John", StoneColor.White, screenMock);
            var move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("1", "1");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("2", "2");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("3", "3");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("4", "4");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.True);
        }

        [Test]
        public void Board_IsDiagonalUpWin()
        {
            var board = new BoardBuilder()
               .WithGridSize(10)
               .Build();
            Assert.That(board.GetGridSize, Is.EqualTo(10));

            var screenMock = new MockScreen();
            screenMock.SetUserInput("0", "4");
            var hp = new HumanPlayer("John", StoneColor.White, screenMock);
            var move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("1", "3");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("2", "2");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("3", "1");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.False);

            screenMock.SetUserInput("4", "0");
            move = hp.MakeMove(board);
            board.grid[move.x][move.y].Color = hp.GetColor();
            board.CheckForWin(move.x, move.y);
            Assert.That(board.IsEndOfGame(), Is.True);
        }
    }
}
