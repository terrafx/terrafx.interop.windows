// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CERT_ISSUER_SERIAL_NUMBER" />struct.</summary>
    public static unsafe class CERT_ISSUER_SERIAL_NUMBERTests
    {
        /// <summary>Validates that the <see cref="CERT_ISSUER_SERIAL_NUMBER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CERT_ISSUER_SERIAL_NUMBER>(), Is.EqualTo(sizeof(CERT_ISSUER_SERIAL_NUMBER)));
        }

        /// <summary>Validates that the <see cref="CERT_ISSUER_SERIAL_NUMBER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CERT_ISSUER_SERIAL_NUMBER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CERT_ISSUER_SERIAL_NUMBER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CERT_ISSUER_SERIAL_NUMBER), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(CERT_ISSUER_SERIAL_NUMBER), Is.EqualTo(16));
            }
        }
    }
}
