// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ILauncherStatics3" /> struct.</summary>
    public static unsafe class ILauncherStatics3Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ILauncherStatics3" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ILauncherStatics3).GUID, Is.EqualTo(IID_ILauncherStatics3));
        }

        /// <summary>Validates that the <see cref="ILauncherStatics3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ILauncherStatics3>(), Is.EqualTo(sizeof(ILauncherStatics3)));
        }

        /// <summary>Validates that the <see cref="ILauncherStatics3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ILauncherStatics3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ILauncherStatics3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ILauncherStatics3), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ILauncherStatics3), Is.EqualTo(4));
            }
        }
    }
}
