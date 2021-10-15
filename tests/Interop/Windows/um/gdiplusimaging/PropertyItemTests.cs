// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PropertyItem" /> struct.</summary>
    public static unsafe class PropertyItemTests
    {
        /// <summary>Validates that the <see cref="PropertyItem" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PropertyItem>(), Is.EqualTo(sizeof(PropertyItem)));
        }

        /// <summary>Validates that the <see cref="PropertyItem" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PropertyItem).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PropertyItem" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PropertyItem), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(PropertyItem), Is.EqualTo(16));
            }
        }
    }
}
