// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static unsafe partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="DXGI_DEBUG_ALL" /> property is correct.</summary>
        [Test]
        public static void DXGI_DEBUG_ALLTest()
        {
            Assert.That(DXGI_DEBUG_ALL, Is.EqualTo(new Guid(0xe48ae283, 0xda80, 0x490b, 0x87, 0xe6, 0x43, 0xe9, 0xa9, 0xcf, 0xda, 0x8)));
        }

        /// <summary>Validates that the value of the <see cref="DXGI_DEBUG_DX" /> property is correct.</summary>
        [Test]
        public static void DXGI_DEBUG_DXTest()
        {
            Assert.That(DXGI_DEBUG_DX, Is.EqualTo(new Guid(0x35cdd7fc, 0x13b2, 0x421d, 0xa5, 0xd7, 0x7e, 0x44, 0x51, 0x28, 0x7d, 0x64)));
        }

        /// <summary>Validates that the value of the <see cref="DXGI_DEBUG_DXGI" /> property is correct.</summary>
        [Test]
        public static void DXGI_DEBUG_DXGITest()
        {
            Assert.That(DXGI_DEBUG_DXGI, Is.EqualTo(new Guid(0x25cddaa4, 0xb1c6, 0x47e1, 0xac, 0x3e, 0x98, 0x87, 0x5b, 0x5a, 0x2e, 0x2a)));
        }

        /// <summary>Validates that the value of the <see cref="DXGI_DEBUG_APP" /> property is correct.</summary>
        [Test]
        public static void DXGI_DEBUG_APPTest()
        {
            Assert.That(DXGI_DEBUG_APP, Is.EqualTo(new Guid(0x6cd6e01, 0x4219, 0x4ebd, 0x87, 0x9, 0x27, 0xed, 0x23, 0x36, 0xc, 0x62)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDXGIInfoQueue" /> property is correct.</summary>
        [Test]
        public static void IID_IDXGIInfoQueueTest()
        {
            Assert.That(IID_IDXGIInfoQueue, Is.EqualTo(new Guid(0xD67441C7, 0x672A, 0x476f, 0x9E, 0x82, 0xCD, 0x55, 0xB4, 0x49, 0x49, 0xCE)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDXGIDebug" /> property is correct.</summary>
        [Test]
        public static void IID_IDXGIDebugTest()
        {
            Assert.That(IID_IDXGIDebug, Is.EqualTo(new Guid(0x119E7452, 0xDE9E, 0x40fe, 0x88, 0x06, 0x88, 0xF9, 0x0C, 0x12, 0xB4, 0x41)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDXGIDebug1" /> property is correct.</summary>
        [Test]
        public static void IID_IDXGIDebug1Test()
        {
            Assert.That(IID_IDXGIDebug1, Is.EqualTo(new Guid(0xc5a05f0c, 0x16f2, 0x4adf, 0x9f, 0x4d, 0xa8, 0xc4, 0xd5, 0x8a, 0xc5, 0x50)));
        }
    }
}
