// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HIDP_LINK_COLLECTION_NODE" /> struct.</summary>
    public static unsafe partial class HIDP_LINK_COLLECTION_NODETests
    {
        /// <summary>Validates that the <see cref="HIDP_LINK_COLLECTION_NODE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HIDP_LINK_COLLECTION_NODE>(), Is.EqualTo(sizeof(HIDP_LINK_COLLECTION_NODE)));
        }

        /// <summary>Validates that the <see cref="HIDP_LINK_COLLECTION_NODE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HIDP_LINK_COLLECTION_NODE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HIDP_LINK_COLLECTION_NODE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HIDP_LINK_COLLECTION_NODE), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(HIDP_LINK_COLLECTION_NODE), Is.EqualTo(20));
            }
        }
    }
}
