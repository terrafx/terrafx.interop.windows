// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WICRawToneCurvePoint" /> struct.</summary>
    public static class WICRawToneCurvePointTests
    {
        /// <summary>Validates that the layout of the <see cref="WICRawToneCurvePoint" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WICRawToneCurvePoint).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="WICRawToneCurvePoint" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<WICRawToneCurvePoint>(), Is.EqualTo(16));
        }
    }
}
