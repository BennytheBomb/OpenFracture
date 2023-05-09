using NUnit.Framework;
using OpenFracture.Runtime.Scripts.Fragment;
using UnityEngine;

namespace OpenFracture.Tests.Runtime
{
    public class TriangulationPointTests
    {
        [Test]
        public void TestInit()
        {
            int index = 1;
            Vector2 coords = new Vector2(0.5f, 0.75f);

            var point = new TriangulationPoint(index, coords);

            Assert.AreEqual(index, point.index);
            Assert.AreEqual(coords, point.coords);
        }
    }
}