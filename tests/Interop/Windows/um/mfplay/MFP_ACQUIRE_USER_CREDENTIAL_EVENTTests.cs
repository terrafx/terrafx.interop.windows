// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFP_ACQUIRE_USER_CREDENTIAL_EVENT" />struct.</summary>
    public static unsafe class MFP_ACQUIRE_USER_CREDENTIAL_EVENTTests
    {
        /// <summary>Validates that the <see cref="MFP_ACQUIRE_USER_CREDENTIAL_EVENT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFP_ACQUIRE_USER_CREDENTIAL_EVENT>(), Is.EqualTo(sizeof(MFP_ACQUIRE_USER_CREDENTIAL_EVENT)));
        }

        /// <summary>Validates that the <see cref="MFP_ACQUIRE_USER_CREDENTIAL_EVENT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MFP_ACQUIRE_USER_CREDENTIAL_EVENT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MFP_ACQUIRE_USER_CREDENTIAL_EVENT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MFP_ACQUIRE_USER_CREDENTIAL_EVENT), Is.EqualTo(96));
            }
            else
            {
                Assert.That(sizeof(MFP_ACQUIRE_USER_CREDENTIAL_EVENT), Is.EqualTo(60));
            }
        }
    }
}
