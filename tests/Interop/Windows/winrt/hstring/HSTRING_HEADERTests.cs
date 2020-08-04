// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/hstring.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HSTRING_HEADER" /> struct.</summary>
    public static unsafe class HSTRING_HEADERTests
    {
        /// <summary>Validates that the <see cref="HSTRING_HEADER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HSTRING_HEADER>(), Is.EqualTo(sizeof(HSTRING_HEADER)));
        }

        /// <summary>Validates that the <see cref="HSTRING_HEADER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HSTRING_HEADER).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HSTRING_HEADER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HSTRING_HEADER), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(HSTRING_HEADER), Is.EqualTo(20));
            }
        }
    }
}
