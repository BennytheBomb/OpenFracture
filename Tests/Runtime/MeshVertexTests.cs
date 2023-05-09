using NUnit.Framework;
using OpenFracture.Runtime.Scripts.Fragment;
using UnityEngine;

namespace OpenFracture.Tests.Runtime
{
    public class MeshVertexTests
    {
        [Test]
        public void EqualPositionsEqual()
        {
            MeshVertex vertexA = new MeshVertex(new Vector3(1, 2, 3), Vector3.up, Vector2.zero);
            MeshVertex vertexB = new MeshVertex(new Vector3(1, 2, 3), Vector3.up, Vector2.zero);
            Assert.True(vertexA == vertexB);
        }
    
        [Test]
        public void DifferentPositionsNotEqual()
        {
            MeshVertex vertexA = new MeshVertex(new Vector3(1, 2, 3), Vector3.up, Vector2.zero);
            MeshVertex vertexB = new MeshVertex(new Vector3(1, 2, 3), Vector3.up, Vector2.zero);
            Assert.True(vertexA == vertexB);
        }
    }
}