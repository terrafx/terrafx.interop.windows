// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="USN_JOURNAL_DATA_V1" /> struct.</summary>
    public static unsafe class USN_JOURNAL_DATA_V1Tests
    {
        /// <summary>Validates that the <see cref="USN_JOURNAL_DATA_V1" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<USN_JOURNAL_DATA_V1>(), Is.EqualTo(sizeof(USN_JOURNAL_DATA_V1)));
        }

        /// <summary>Validates that the <see cref="USN_JOURNAL_DATA_V1" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(USN_JOURNAL_DATA_V1).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="USN_JOURNAL_DATA_V1" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(USN_JOURNAL_DATA_V1), Is.EqualTo(64));
        }
    }
}
