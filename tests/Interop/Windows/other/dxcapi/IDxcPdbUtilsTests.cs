// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcapi.h in the microsoft/DirectXCompiler commit 747ee519eb9b65f893bb891bc6d229dfe9687e6a
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDxcPdbUtils" /> struct.</summary>
    public static unsafe class IDxcPdbUtilsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDxcPdbUtils" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDxcPdbUtils).GUID, Is.EqualTo(IID_IDxcPdbUtils));
        }

        /// <summary>Validates that the <see cref="IDxcPdbUtils" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDxcPdbUtils>(), Is.EqualTo(sizeof(IDxcPdbUtils)));
        }

        /// <summary>Validates that the <see cref="IDxcPdbUtils" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDxcPdbUtils).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDxcPdbUtils" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDxcPdbUtils), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDxcPdbUtils), Is.EqualTo(4));
            }
        }
    }
}
