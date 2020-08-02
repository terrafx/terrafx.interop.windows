// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FLAGGED_BYTE_BLOB" />struct.</summary>
    public static unsafe class FLAGGED_BYTE_BLOBTests
    {
        /// <summary>Validates that the <see cref="FLAGGED_BYTE_BLOB" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FLAGGED_BYTE_BLOB>(), Is.EqualTo(sizeof(FLAGGED_BYTE_BLOB)));
        }

        /// <summary>Validates that the <see cref="FLAGGED_BYTE_BLOB" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FLAGGED_BYTE_BLOB).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FLAGGED_BYTE_BLOB" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FLAGGED_BYTE_BLOB), Is.EqualTo(12));
        }
    }
}
