// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CMSG_KEY_AGREE_KEY_ENCRYPT_INFO" />struct.</summary>
    public static unsafe class CMSG_KEY_AGREE_KEY_ENCRYPT_INFOTests
    {
        /// <summary>Validates that the <see cref="CMSG_KEY_AGREE_KEY_ENCRYPT_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CMSG_KEY_AGREE_KEY_ENCRYPT_INFO>(), Is.EqualTo(sizeof(CMSG_KEY_AGREE_KEY_ENCRYPT_INFO)));
        }

        /// <summary>Validates that the <see cref="CMSG_KEY_AGREE_KEY_ENCRYPT_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CMSG_KEY_AGREE_KEY_ENCRYPT_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CMSG_KEY_AGREE_KEY_ENCRYPT_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CMSG_KEY_AGREE_KEY_ENCRYPT_INFO), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(CMSG_KEY_AGREE_KEY_ENCRYPT_INFO), Is.EqualTo(12));
            }
        }
    }
}
