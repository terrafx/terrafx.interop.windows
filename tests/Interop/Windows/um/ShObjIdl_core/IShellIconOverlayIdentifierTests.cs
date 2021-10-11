// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IShellIconOverlayIdentifier" /> struct.</summary>
    public static unsafe partial class IShellIconOverlayIdentifierTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IShellIconOverlayIdentifier" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IShellIconOverlayIdentifier).GUID, Is.EqualTo(IID_IShellIconOverlayIdentifier));
        }

        /// <summary>Validates that the <see cref="IShellIconOverlayIdentifier" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IShellIconOverlayIdentifier>(), Is.EqualTo(sizeof(IShellIconOverlayIdentifier)));
        }

        /// <summary>Validates that the <see cref="IShellIconOverlayIdentifier" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IShellIconOverlayIdentifier).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IShellIconOverlayIdentifier" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IShellIconOverlayIdentifier), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IShellIconOverlayIdentifier), Is.EqualTo(4));
            }
        }
    }
}
