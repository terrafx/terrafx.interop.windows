// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="POINTER_TYPE_INFO" /> struct.</summary>
    public static unsafe class POINTER_TYPE_INFOTests
    {
        /// <summary>Validates that the <see cref="POINTER_TYPE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<POINTER_TYPE_INFO>(), Is.EqualTo(sizeof(POINTER_TYPE_INFO)));
        }

        /// <summary>Validates that the <see cref="POINTER_TYPE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(POINTER_TYPE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="POINTER_TYPE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(POINTER_TYPE_INFO), Is.EqualTo(152));
            }
            else
            {
                Assert.That(sizeof(POINTER_TYPE_INFO), Is.EqualTo(144));
            }
        }
    }
}
