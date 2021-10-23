// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SLIST_HEADER_ARM" /> struct.</summary>
    public static unsafe partial class SLIST_HEADER_ARMTests
    {
        /// <summary>Validates that the <see cref="SLIST_HEADER_ARM" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SLIST_HEADER_ARM>(), Is.EqualTo(sizeof(SLIST_HEADER_ARM)));
        }

        /// <summary>Validates that the <see cref="SLIST_HEADER_ARM" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(SLIST_HEADER_ARM).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="SLIST_HEADER_ARM" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SLIST_HEADER_ARM), Is.EqualTo(16));
        }
    }
}
