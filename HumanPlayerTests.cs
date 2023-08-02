using Gomoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gomoku.Models.Cell;

namespace GomokuTests
{
    public class HumanPlayerTests
    {
        IScreen screen;
        [SetUp]
        public void Setup()
        {
            screen = new ConsoleScreen();
        }

        [Test]
        public void HumanPlayer_When_Null_Board()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var hp = new HumanPlayer("John", StoneColor.White, screen);
            Assert.That(hp.GetName(), Is.Not.Null);
            Assert.That(() => hp.MakeMove(null), Throws.ArgumentNullException);
        }

        [Test]
        public void HumanPlayer_IsWhite_When_Move_Success()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var screenMock = new MockScreen();
            screenMock.SetUserInput("2", "3"); 
            var cp = new HumanPlayer("John", StoneColor.White, screenMock);
            var move = cp.MakeMove(bd);

            Assert.That(move.x, Is.EqualTo(2));
            Assert.That(move.y, Is.EqualTo(3));
        }

        [Test]
        public void HumanPlayer_When_Multiple_Move_Success()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var screenMock = new MockScreen();
            screenMock.SetUserInput("2", "3");
            var cp = new HumanPlayer("John", StoneColor.White, screenMock);
            var move = cp.MakeMove(bd);

            Assert.That(move.x, Is.EqualTo(2));
            Assert.That(move.y, Is.EqualTo(3));

            screenMock.SetUserInput("4", "6");
            move = cp.MakeMove(bd);

            Assert.That(move.x, Is.EqualTo(4));
            Assert.That(move.y, Is.EqualTo(6));
        }

        [Test]
        public void HumanPlayer_When_Coordinates_Greater_Throws_ArgumentOutOfRangeException()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));
            
            var screenMock = new MockScreen();
            screenMock.SetUserInput("11", "11");
            var cp = new HumanPlayer("John", StoneColor.White, screenMock);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                cp.MakeMove(bd);
            });
        }

        [Test]
        public void HumanPlayer_When_Coordinates_Less_Throws_ArgumentOutOfRangeException()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var screenMock = new MockScreen();
            screenMock.SetUserInput("-1", "-1");
            var cp = new HumanPlayer("John", StoneColor.White, screenMock);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                cp.MakeMove(bd);
            });
        }

        [Test]
        public void HumanPlayer_IsBlack()
        {
            var hp = new HumanPlayer("John", StoneColor.Black, screen);
            var color = hp.GetColor();
            Assert.That(color, Is.EqualTo(StoneColor.Black));
        }

        [Test]
        public void HumanPlayer_IsWhite()
        {
            var hp = new HumanPlayer("John", StoneColor.White, screen);
            var color = hp.GetColor();
            Assert.That(color, Is.EqualTo(StoneColor.White));
        }
    }
}
