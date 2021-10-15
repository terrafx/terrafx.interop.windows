// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Rect" /> struct.</summary>
    public static unsafe partial class RectTests
    {
        /// <summary>Validates that the <see cref="Rect" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<Rect>(), Is.EqualTo(sizeof(Rect)));
        }

        /// <summary>Validates that the <see cref="Rect" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(Rect).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="Rect" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(Rect), Is.EqualTo(16));
        }
    }
}
