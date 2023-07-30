using Gomoku.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Gomoku.Models.Cell;

namespace GomokuTests
{
    public class ComputerPlayerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BoardBuilder_SetGridSize()
        {
            var bd = new BoardBuilder()
                .WithGridSize(10)
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(10));

            var cp = new ComputerPlayer();
            Assert.That(cp.GetName(), Is.Not.Null);
            Assert.That(() => cp.Move(null, 0, 0), Throws.ArgumentNullException);
        }
    }
}
