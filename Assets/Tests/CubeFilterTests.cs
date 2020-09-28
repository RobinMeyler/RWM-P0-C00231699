using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9, 999 };
            int[] output = CubeFilter.cubes(input);
            int[] expected = { 1, 27, 125, 343, 729, 997002999 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
