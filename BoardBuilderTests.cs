using Gomoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomokuTests
{
    public class BoardBuilderTests
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
        }

        [Test]
        public void BoardBuilder_DefaultGridSize()
        {
            var bd = new BoardBuilder()
                .Build();
            Assert.That(bd.GetGridSize, Is.EqualTo(15));
        }
    }
}
