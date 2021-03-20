// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MouseDelta" /> struct.</summary>
    public static unsafe class MouseDeltaTests
    {
        /// <summary>Validates that the <see cref="MouseDelta" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MouseDelta>(), Is.EqualTo(sizeof(MouseDelta)));
        }

        /// <summary>Validates that the <see cref="MouseDelta" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MouseDelta).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MouseDelta" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MouseDelta), Is.EqualTo(8));
        }
    }
}
