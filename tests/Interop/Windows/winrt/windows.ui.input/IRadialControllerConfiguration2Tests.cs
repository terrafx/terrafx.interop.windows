// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IRadialControllerConfiguration2" /> struct.</summary>
    public static unsafe class IRadialControllerConfiguration2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IRadialControllerConfiguration2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IRadialControllerConfiguration2).GUID, Is.EqualTo(IID_IRadialControllerConfiguration2));
        }

        /// <summary>Validates that the <see cref="IRadialControllerConfiguration2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IRadialControllerConfiguration2>(), Is.EqualTo(sizeof(IRadialControllerConfiguration2)));
        }

        /// <summary>Validates that the <see cref="IRadialControllerConfiguration2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IRadialControllerConfiguration2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IRadialControllerConfiguration2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IRadialControllerConfiguration2), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IRadialControllerConfiguration2), Is.EqualTo(4));
            }
        }
    }
}
