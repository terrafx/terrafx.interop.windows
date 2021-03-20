// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICoreWindowStatic" /> struct.</summary>
    public static unsafe class ICoreWindowStaticTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICoreWindowStatic" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICoreWindowStatic).GUID, Is.EqualTo(IID_ICoreWindowStatic));
        }

        /// <summary>Validates that the <see cref="ICoreWindowStatic" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICoreWindowStatic>(), Is.EqualTo(sizeof(ICoreWindowStatic)));
        }

        /// <summary>Validates that the <see cref="ICoreWindowStatic" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICoreWindowStatic).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICoreWindowStatic" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICoreWindowStatic), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICoreWindowStatic), Is.EqualTo(4));
            }
        }
    }
}
