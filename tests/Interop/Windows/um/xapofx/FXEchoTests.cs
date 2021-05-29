// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FXEcho" /> struct.</summary>
    public static unsafe class FXEchoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="FXEcho" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(FXEcho).GUID, Is.EqualTo(CLSID_FXEcho));
        }

        /// <summary>Validates that the <see cref="FXEcho" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FXEcho>(), Is.EqualTo(sizeof(FXEcho)));
        }

        /// <summary>Validates that the <see cref="FXEcho" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FXEcho).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FXEcho" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FXEcho), Is.EqualTo(1));
        }
    }
}
