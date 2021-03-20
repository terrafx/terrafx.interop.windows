// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IGestureRecognizer2" /> struct.</summary>
    public static unsafe class IGestureRecognizer2Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IGestureRecognizer2" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IGestureRecognizer2).GUID, Is.EqualTo(IID_IGestureRecognizer2));
        }

        /// <summary>Validates that the <see cref="IGestureRecognizer2" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IGestureRecognizer2>(), Is.EqualTo(sizeof(IGestureRecognizer2)));
        }

        /// <summary>Validates that the <see cref="IGestureRecognizer2" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IGestureRecognizer2).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IGestureRecognizer2" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IGestureRecognizer2), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IGestureRecognizer2), Is.EqualTo(4));
            }
        }
    }
}
