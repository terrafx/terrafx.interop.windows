// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PropertySystem" /> struct.</summary>
    public static unsafe partial class PropertySystemTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="PropertySystem" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(PropertySystem).GUID, Is.EqualTo(CLSID_PropertySystem));
        }

        /// <summary>Validates that the <see cref="PropertySystem" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PropertySystem>(), Is.EqualTo(sizeof(PropertySystem)));
        }

        /// <summary>Validates that the <see cref="PropertySystem" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PropertySystem).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PropertySystem" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PropertySystem), Is.EqualTo(1));
        }
    }
}
