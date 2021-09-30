// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_ALPHA_MODE;
using static TerraFX.Interop.D2D1_PIXEL_FORMAT;
using static TerraFX.Interop.DXGI_FORMAT;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_PIXEL_FORMAT" /> struct.</summary>
    public static unsafe class D2D1_PIXEL_FORMATTests
    {
        /// <summary>Validates that the <see cref="D2D1_PIXEL_FORMAT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_PIXEL_FORMAT>(), Is.EqualTo(sizeof(D2D1_PIXEL_FORMAT)));
        }

        /// <summary>Validates that the <see cref="D2D1_PIXEL_FORMAT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_PIXEL_FORMAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_PIXEL_FORMAT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D1_PIXEL_FORMAT), Is.EqualTo(8));
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.format, Is.EqualTo(DXGI_FORMAT_UNKNOWN));
            Assert.That(DEFAULT.alphaMode, Is.EqualTo(D2D1_ALPHA_MODE_UNKNOWN));
        }
    }
}
