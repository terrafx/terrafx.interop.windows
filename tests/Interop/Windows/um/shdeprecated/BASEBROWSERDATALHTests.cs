// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="BASEBROWSERDATALH" /> struct.</summary>
    public static unsafe class BASEBROWSERDATALHTests
    {
        /// <summary>Validates that the <see cref="BASEBROWSERDATALH" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<BASEBROWSERDATALH>(), Is.EqualTo(sizeof(BASEBROWSERDATALH)));
        }

        /// <summary>Validates that the <see cref="BASEBROWSERDATALH" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(BASEBROWSERDATALH).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="BASEBROWSERDATALH" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(BASEBROWSERDATALH), Is.EqualTo(216));
            }
            else
            {
                Assert.That(sizeof(BASEBROWSERDATALH), Is.EqualTo(132));
            }
        }
    }
}
