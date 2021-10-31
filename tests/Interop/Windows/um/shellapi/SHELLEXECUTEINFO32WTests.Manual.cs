// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SHELLEXECUTEINFO32W" /> struct.</summary>
    public static unsafe partial class SHELLEXECUTEINFO32WTests
    {
        /// <summary>Validates that the <see cref="SHELLEXECUTEINFO32W" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SHELLEXECUTEINFO32W>(), Is.EqualTo(sizeof(SHELLEXECUTEINFO32W)));
        }

        /// <summary>Validates that the <see cref="SHELLEXECUTEINFO32W" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SHELLEXECUTEINFO32W).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SHELLEXECUTEINFO32W" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SHELLEXECUTEINFO32W), Is.EqualTo(104));
            }
            else
            {
                Assert.That(sizeof(SHELLEXECUTEINFO32W), Is.EqualTo(60));
            }
        }
    }
}
