// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="EnumFsiItems" /> struct.</summary>
    public static unsafe class EnumFsiItemsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="EnumFsiItems" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(EnumFsiItems).GUID, Is.EqualTo(CLSID_EnumFsiItems));
        }

        /// <summary>Validates that the <see cref="EnumFsiItems" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<EnumFsiItems>(), Is.EqualTo(sizeof(EnumFsiItems)));
        }

        /// <summary>Validates that the <see cref="EnumFsiItems" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(EnumFsiItems).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="EnumFsiItems" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(EnumFsiItems), Is.EqualTo(1));
        }
    }
}
