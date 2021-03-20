// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAttachableInputObject" /> struct.</summary>
    public static unsafe class IAttachableInputObjectTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAttachableInputObject" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAttachableInputObject).GUID, Is.EqualTo(IID_IAttachableInputObject));
        }

        /// <summary>Validates that the <see cref="IAttachableInputObject" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAttachableInputObject>(), Is.EqualTo(sizeof(IAttachableInputObject)));
        }

        /// <summary>Validates that the <see cref="IAttachableInputObject" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAttachableInputObject).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAttachableInputObject" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAttachableInputObject), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAttachableInputObject), Is.EqualTo(4));
            }
        }
    }
}
