// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IHolographicCameraInterop" /> struct.</summary>
    public static unsafe class IHolographicCameraInteropTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHolographicCameraInterop" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IHolographicCameraInterop).GUID, Is.EqualTo(IID_IHolographicCameraInterop));
        }

        /// <summary>Validates that the <see cref="IHolographicCameraInterop" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IHolographicCameraInterop>(), Is.EqualTo(sizeof(IHolographicCameraInterop)));
        }

        /// <summary>Validates that the <see cref="IHolographicCameraInterop" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IHolographicCameraInterop).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IHolographicCameraInterop" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IHolographicCameraInterop), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IHolographicCameraInterop), Is.EqualTo(4));
            }
        }
    }
}
