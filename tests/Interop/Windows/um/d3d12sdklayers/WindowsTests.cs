// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="WKPDID_D3DAutoDebugObjectNameW" /> property is correct.</summary>
        [Test]
        public static void WKPDID_D3DAutoDebugObjectNameWTest()
        {
            Assert.That(WKPDID_D3DAutoDebugObjectNameW, Is.EqualTo(new Guid(0xd4902e36, 0x757a, 0x4942, 0x95, 0x94, 0xb6, 0x76, 0x9a, 0xfa, 0x43, 0xcd)));
        }

        /// <summary>Validates that the value of the <see cref="DXGI_DEBUG_D3D12" /> property is correct.</summary>
        [Test]
        public static void DXGI_DEBUG_D3D12Test()
        {
            Assert.That(DXGI_DEBUG_D3D12, Is.EqualTo(new Guid(0xcf59a98c, 0xa950, 0x4326, 0x91, 0xef, 0x9b, 0xba, 0xa1, 0x7b, 0xfd, 0x95)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12Debug" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugTest()
        {
            Assert.That(IID_ID3D12Debug, Is.EqualTo(new Guid(0x344488b7, 0x6846, 0x474b, 0xb9, 0x89, 0xf0, 0x27, 0x44, 0x82, 0x45, 0xe0)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12Debug1" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12Debug1Test()
        {
            Assert.That(IID_ID3D12Debug1, Is.EqualTo(new Guid(0xaffaa4ca, 0x63fe, 0x4d8e, 0xb8, 0xad, 0x15, 0x90, 0x00, 0xaf, 0x43, 0x04)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12Debug2" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12Debug2Test()
        {
            Assert.That(IID_ID3D12Debug2, Is.EqualTo(new Guid(0x93a665c4, 0xa3b2, 0x4e5d, 0xb6, 0x92, 0xa2, 0x6a, 0xe1, 0x4e, 0x33, 0x74)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12Debug3" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12Debug3Test()
        {
            Assert.That(IID_ID3D12Debug3, Is.EqualTo(new Guid(0x5cf4e58f, 0xf671, 0x4ff1, 0xa5, 0x42, 0x36, 0x86, 0xe3, 0xd1, 0x53, 0xd1)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12Debug4" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12Debug4Test()
        {
            Assert.That(IID_ID3D12Debug4, Is.EqualTo(new Guid(0x014b816e, 0x9ec5, 0x4a2f, 0xa8, 0x45, 0xff, 0xbe, 0x44, 0x1c, 0xe1, 0x3a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12Debug5" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12Debug5Test()
        {
            Assert.That(IID_ID3D12Debug5, Is.EqualTo(new Guid(0x548d6b12, 0x09fa, 0x40e0, 0x90, 0x69, 0x5d, 0xcd, 0x58, 0x9a, 0x52, 0xc9)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12DebugDevice1" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugDevice1Test()
        {
            Assert.That(IID_ID3D12DebugDevice1, Is.EqualTo(new Guid(0xa9b71770, 0xd099, 0x4a65, 0xa6, 0x98, 0x3d, 0xee, 0x10, 0x02, 0x0f, 0x88)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12DebugDevice" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugDeviceTest()
        {
            Assert.That(IID_ID3D12DebugDevice, Is.EqualTo(new Guid(0x3febd6dd, 0x4973, 0x4787, 0x81, 0x94, 0xe4, 0x5f, 0x9e, 0x28, 0x92, 0x3e)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12DebugDevice2" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugDevice2Test()
        {
            Assert.That(IID_ID3D12DebugDevice2, Is.EqualTo(new Guid(0x60eccbc1, 0x378d, 0x4df1, 0x89, 0x4c, 0xf8, 0xac, 0x5c, 0xe4, 0xd7, 0xdd)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12DebugCommandQueue" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugCommandQueueTest()
        {
            Assert.That(IID_ID3D12DebugCommandQueue, Is.EqualTo(new Guid(0x09e0bf36, 0x54ac, 0x484f, 0x88, 0x47, 0x4b, 0xae, 0xea, 0xb6, 0x05, 0x3a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12DebugCommandList1" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugCommandList1Test()
        {
            Assert.That(IID_ID3D12DebugCommandList1, Is.EqualTo(new Guid(0x102ca951, 0x311b, 0x4b01, 0xb1, 0x1f, 0xec, 0xb8, 0x3e, 0x06, 0x1b, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12DebugCommandList" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugCommandListTest()
        {
            Assert.That(IID_ID3D12DebugCommandList, Is.EqualTo(new Guid(0x09e0bf36, 0x54ac, 0x484f, 0x88, 0x47, 0x4b, 0xae, 0xea, 0xb6, 0x05, 0x3f)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12DebugCommandList2" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12DebugCommandList2Test()
        {
            Assert.That(IID_ID3D12DebugCommandList2, Is.EqualTo(new Guid(0xaeb575cf, 0x4e06, 0x48be, 0xba, 0x3b, 0xc4, 0x50, 0xfc, 0x96, 0x65, 0x2e)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12SharingContract" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12SharingContractTest()
        {
            Assert.That(IID_ID3D12SharingContract, Is.EqualTo(new Guid(0x0adf7d52, 0x929c, 0x4e61, 0xad, 0xdb, 0xff, 0xed, 0x30, 0xde, 0x66, 0xef)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12InfoQueue" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12InfoQueueTest()
        {
            Assert.That(IID_ID3D12InfoQueue, Is.EqualTo(new Guid(0x0742a90b, 0xc387, 0x483f, 0xb9, 0x46, 0x30, 0xa7, 0xe4, 0xe6, 0x14, 0x58)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ID3D12InfoQueue1" /> property is correct.</summary>
        [Test]
        public static void IID_ID3D12InfoQueue1Test()
        {
            Assert.That(IID_ID3D12InfoQueue1, Is.EqualTo(new Guid(0x2852dd88, 0xb484, 0x4c0c, 0xb6, 0xb1, 0x67, 0x16, 0x85, 0x00, 0xe6, 0x00)));
        }
    }
}
