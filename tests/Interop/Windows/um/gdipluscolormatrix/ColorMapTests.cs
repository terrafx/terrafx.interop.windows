// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluscolormatrix.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ColorMap" /> struct.</summary>
    public static unsafe partial class ColorMapTests
    {
        /// <summary>Validates that the <see cref="ColorMap" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ColorMap>(), Is.EqualTo(sizeof(ColorMap)));
        }

        /// <summary>Validates that the <see cref="ColorMap" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ColorMap).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ColorMap" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ColorMap), Is.EqualTo(8));
        }
    }
}
