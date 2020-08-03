// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXCoreAdapter" /> struct.</summary>
    public static unsafe class IDXCoreAdapterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXCoreAdapter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXCoreAdapter).GUID, Is.EqualTo(IID_IDXCoreAdapter));
        }

        /// <summary>Validates that the <see cref="IDXCoreAdapter" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDXCoreAdapter>(), Is.EqualTo(sizeof(IDXCoreAdapter)));
        }

        /// <summary>Validates that the <see cref="IDXCoreAdapter" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXCoreAdapter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDXCoreAdapter" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDXCoreAdapter), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDXCoreAdapter), Is.EqualTo(4));
            }
        }
    }
}
