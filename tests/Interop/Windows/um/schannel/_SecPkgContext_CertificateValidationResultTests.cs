// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_SecPkgContext_CertificateValidationResult" /> struct.</summary>
    public static unsafe class _SecPkgContext_CertificateValidationResultTests
    {
        /// <summary>Validates that the <see cref="_SecPkgContext_CertificateValidationResult" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_SecPkgContext_CertificateValidationResult>(), Is.EqualTo(sizeof(_SecPkgContext_CertificateValidationResult)));
        }

        /// <summary>Validates that the <see cref="_SecPkgContext_CertificateValidationResult" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_SecPkgContext_CertificateValidationResult).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_SecPkgContext_CertificateValidationResult" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(_SecPkgContext_CertificateValidationResult), Is.EqualTo(8));
        }
    }
}
