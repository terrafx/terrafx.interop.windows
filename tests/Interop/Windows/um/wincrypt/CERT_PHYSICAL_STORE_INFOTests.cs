// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CERT_PHYSICAL_STORE_INFO" />struct.</summary>
    public static unsafe class CERT_PHYSICAL_STORE_INFOTests
    {
        /// <summary>Validates that the <see cref="CERT_PHYSICAL_STORE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CERT_PHYSICAL_STORE_INFO>(), Is.EqualTo(sizeof(CERT_PHYSICAL_STORE_INFO)));
        }

        /// <summary>Validates that the <see cref="CERT_PHYSICAL_STORE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CERT_PHYSICAL_STORE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CERT_PHYSICAL_STORE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CERT_PHYSICAL_STORE_INFO), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(CERT_PHYSICAL_STORE_INFO), Is.EqualTo(32));
            }
        }
    }
}
