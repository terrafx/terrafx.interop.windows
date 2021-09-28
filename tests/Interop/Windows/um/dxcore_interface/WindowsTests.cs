// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="IID_IDXCoreAdapterFactory" /> property is correct.</summary>
        [Test]
        public static void IID_IDXCoreAdapterFactoryTest()
        {
            Assert.That(IID_IDXCoreAdapterFactory, Is.EqualTo(new Guid(0x78ee5945, 0xc36e, 0x4b13, 0xa6, 0x69, 0x00, 0x5d, 0xd1, 0x1c, 0x0f, 0x06)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDXCoreAdapterList" /> property is correct.</summary>
        [Test]
        public static void IID_IDXCoreAdapterListTest()
        {
            Assert.That(IID_IDXCoreAdapterList, Is.EqualTo(new Guid(0x526c7776, 0x40e9, 0x459b, 0xb7, 0x11, 0xf3, 0x2a, 0xd7, 0x6d, 0xfc, 0x28)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDXCoreAdapter" /> property is correct.</summary>
        [Test]
        public static void IID_IDXCoreAdapterTest()
        {
            Assert.That(IID_IDXCoreAdapter, Is.EqualTo(new Guid(0xf0db4c7f, 0xfe5a, 0x42a2, 0xbd, 0x62, 0xf2, 0xa6, 0xcf, 0x6f, 0xc8, 0x3e)));
        }

        /// <summary>Validates that the value of the <see cref="DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS" /> property is correct.</summary>
        [Test]
        public static void DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICSTest()
        {
            Assert.That(DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS, Is.EqualTo(new Guid(0x8c47866b, 0x7583, 0x450d, 0xf0, 0xf0, 0x6b, 0xad, 0xa8, 0x95, 0xaf, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS" /> property is correct.</summary>
        [Test]
        public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICSTest()
        {
            Assert.That(DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS, Is.EqualTo(new Guid(0x0c9ece4d, 0x2f6e, 0x4f01, 0x8c, 0x96, 0xe8, 0x9e, 0x33, 0x1b, 0x47, 0xb1)));
        }

        /// <summary>Validates that the value of the <see cref="DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE" /> property is correct.</summary>
        [Test]
        public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTETest()
        {
            Assert.That(DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE, Is.EqualTo(new Guid(0x248e2800, 0xa793, 0x4724, 0xab, 0xaa, 0x23, 0xa6, 0xde, 0x1b, 0xe0, 0x90)));
        }
    }
}
