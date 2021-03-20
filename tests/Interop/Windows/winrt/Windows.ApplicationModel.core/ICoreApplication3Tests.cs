// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICoreApplication3" /> struct.</summary>
    public static unsafe class ICoreApplication3Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICoreApplication3" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICoreApplication3).GUID, Is.EqualTo(IID_ICoreApplication3));
        }

        /// <summary>Validates that the <see cref="ICoreApplication3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICoreApplication3>(), Is.EqualTo(sizeof(ICoreApplication3)));
        }

        /// <summary>Validates that the <see cref="ICoreApplication3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICoreApplication3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICoreApplication3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICoreApplication3), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICoreApplication3), Is.EqualTo(4));
            }
        }
    }
}
