// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TT_HITTESTINFOW" /> struct.</summary>
    public static unsafe partial class TT_HITTESTINFOWTests
    {
        /// <summary>Validates that the <see cref="TT_HITTESTINFOW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TT_HITTESTINFOW>(), Is.EqualTo(sizeof(TT_HITTESTINFOW)));
        }

        /// <summary>Validates that the <see cref="TT_HITTESTINFOW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TT_HITTESTINFOW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TT_HITTESTINFOW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(TT_HITTESTINFOW), Is.EqualTo(88));
            }
            else
            {
                Assert.That(sizeof(TT_HITTESTINFOW), Is.EqualTo(60));
            }
        }
    }
}
