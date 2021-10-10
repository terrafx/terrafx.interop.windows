// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_PubAppInfo" /> struct.</summary>
    public static unsafe class _PubAppInfoTests
    {
        /// <summary>Validates that the <see cref="_PubAppInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_PubAppInfo>(), Is.EqualTo(sizeof(_PubAppInfo)));
        }

        /// <summary>Validates that the <see cref="_PubAppInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_PubAppInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_PubAppInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(_PubAppInfo), Is.EqualTo(80));
            }
            else
            {
                Assert.That(sizeof(_PubAppInfo), Is.EqualTo(76));
            }
        }
    }
}
