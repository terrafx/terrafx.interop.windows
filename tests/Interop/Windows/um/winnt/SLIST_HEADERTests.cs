// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SLIST_HEADER" />struct.</summary>
    public static unsafe class SLIST_HEADERTests
    {
        /// <summary>Validates that the <see cref="SLIST_HEADER" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SLIST_HEADER>(), Is.EqualTo(sizeof(SLIST_HEADER)));
        }

        /// <summary>Validates that the <see cref="SLIST_HEADER" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(SLIST_HEADER).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="SLIST_HEADER" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SLIST_HEADER), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(SLIST_HEADER), Is.EqualTo(8));
            }
        }
    }
}
