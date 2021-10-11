// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CALPWSTR" /> struct.</summary>
    public static unsafe partial class CALPWSTRTests
    {
        /// <summary>Validates that the <see cref="CALPWSTR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CALPWSTR>(), Is.EqualTo(sizeof(CALPWSTR)));
        }

        /// <summary>Validates that the <see cref="CALPWSTR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CALPWSTR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CALPWSTR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CALPWSTR), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(CALPWSTR), Is.EqualTo(8));
            }
        }
    }
}
