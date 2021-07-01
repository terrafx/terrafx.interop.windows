// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ks.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="KSIDENTIFIER" /> struct.</summary>
    public static unsafe class KSIDENTIFIERTests
    {
        /// <summary>Validates that the <see cref="KSIDENTIFIER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<KSIDENTIFIER>(), Is.EqualTo(sizeof(KSIDENTIFIER)));
        }

        /// <summary>Validates that the <see cref="KSIDENTIFIER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(KSIDENTIFIER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="KSIDENTIFIER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(KSIDENTIFIER), Is.EqualTo(24));
        }
    }
}
