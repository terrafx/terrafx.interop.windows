// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXCoreHardwareID" /> struct.</summary>
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static unsafe partial class DXCoreHardwareIDTests
    {
        /// <summary>Validates that the <see cref="DXCoreHardwareID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DXCoreHardwareID>(), Is.EqualTo(sizeof(DXCoreHardwareID)));
        }

        /// <summary>Validates that the <see cref="DXCoreHardwareID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXCoreHardwareID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DXCoreHardwareID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DXCoreHardwareID), Is.EqualTo(16));
        }
    }
}
