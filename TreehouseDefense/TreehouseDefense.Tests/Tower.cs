using NUnit.Framework;
using System;
using TreehouseDefense.Tests.Mocks;
                      
namespace TreehouseDefense.Tests
{
    [TestFixture()]
    public class TowerTests
    {
        [Test()]
        public void FireOnInvadersDecreasesInvadersHealth()
        {
            var map = new Map(3, 3);
            var target = new Tower(new MapLocation(0, 0, map));

            var invaders = new InvaderMock[]
            {
                new InvaderMock() { Location = new MapLocation(0, 0, map) },
                new InvaderMock() { Location = new MapLocation(0, 0, map) }
            }

            target.FireOnInvaders(invaders);
        }
    }
}
