using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DiffFilterTest
    {
        [Test]
        public void DiffFilterSimple()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = DiffFilter.numbersDiff(input);
            int[] expected = { 4, 2, 6, 5, 6, 5, 6, 5, 6, 5 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }
            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void DiffFilterMinus()
        {
            int[] input = { 4, 2, 8, -3, 9, 4, 10, 5, 11, 6 };
            int[] output = DiffFilter.numbersDiff(input);
            int[] expected = { 4, 2, 6, 11, 12, 5, 6, 5, 6, 5 };  // 11 and 12 difference from (-3 -> 8), (9 -> -3)

            foreach (var o in output)
            {
                Debug.Log(o);
            }
            CollectionAssert.AreEqual(expected, output);
        }
    }
}
