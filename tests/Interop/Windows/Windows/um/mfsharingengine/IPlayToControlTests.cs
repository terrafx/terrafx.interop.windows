// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPlayToControl" /> struct.</summary>
    [SupportedOSPlatform("windows8.0")]
    public static unsafe partial class IPlayToControlTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPlayToControl" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPlayToControl).GUID, Is.EqualTo(IID_IPlayToControl));
        }

        /// <summary>Validates that the <see cref="IPlayToControl" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IPlayToControl>(), Is.EqualTo(sizeof(IPlayToControl)));
        }

        /// <summary>Validates that the <see cref="IPlayToControl" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPlayToControl).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IPlayToControl" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IPlayToControl), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IPlayToControl), Is.EqualTo(4));
            }
        }
    }
}
