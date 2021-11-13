// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12DeviceRemovedExtendedData" /> struct.</summary>
    [SupportedOSPlatform("windows10.0.18362.0")]
    public static unsafe partial class ID3D12DeviceRemovedExtendedDataTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12DeviceRemovedExtendedData" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID3D12DeviceRemovedExtendedData).GUID, Is.EqualTo(IID_ID3D12DeviceRemovedExtendedData));
        }

        /// <summary>Validates that the <see cref="ID3D12DeviceRemovedExtendedData" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ID3D12DeviceRemovedExtendedData>(), Is.EqualTo(sizeof(ID3D12DeviceRemovedExtendedData)));
        }

        /// <summary>Validates that the <see cref="ID3D12DeviceRemovedExtendedData" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12DeviceRemovedExtendedData).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ID3D12DeviceRemovedExtendedData" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ID3D12DeviceRemovedExtendedData), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ID3D12DeviceRemovedExtendedData), Is.EqualTo(4));
            }
        }
    }
}
