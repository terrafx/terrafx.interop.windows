// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MINIDUMP_DIRECTORY" /> struct.</summary>
    public static unsafe partial class MINIDUMP_DIRECTORYTests
    {
        /// <summary>Validates that the <see cref="MINIDUMP_DIRECTORY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MINIDUMP_DIRECTORY>(), Is.EqualTo(sizeof(MINIDUMP_DIRECTORY)));
        }

        /// <summary>Validates that the <see cref="MINIDUMP_DIRECTORY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MINIDUMP_DIRECTORY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MINIDUMP_DIRECTORY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MINIDUMP_DIRECTORY), Is.EqualTo(12));
        }
    }
}
