// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="DiaSource" /> struct.</summary>
    public static unsafe partial class DiaSourceTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DiaSource" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DiaSource).GUID, Is.EqualTo(CLSID_DiaSource));
        }

        /// <summary>Validates that the <see cref="DiaSource" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DiaSource>(), Is.EqualTo(sizeof(DiaSource)));
        }

        /// <summary>Validates that the <see cref="DiaSource" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DiaSource).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DiaSource" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DiaSource), Is.EqualTo(1));
        }
    }
}
