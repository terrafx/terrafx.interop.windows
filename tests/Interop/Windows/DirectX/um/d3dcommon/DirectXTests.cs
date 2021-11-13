// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX.UnitTests
{
    /// <summary>Provides validation of the <see cref="DirectX" /> class.</summary>
    public static partial class DirectXTests
    {
        /// <summary>Validates that the value of the <see cref="WKPDID_D3DDebugObjectName" /> property is correct.</summary>
        [Test]
        public static void WKPDID_D3DDebugObjectNameTest()
        {
            Assert.That(WKPDID_D3DDebugObjectName, Is.EqualTo(new Guid(0x429b8c22, 0x9188, 0x4b0c, 0x87, 0x42, 0xac, 0xb0, 0xbf, 0x85, 0xc2, 0x00)));
        }

        /// <summary>Validates that the value of the <see cref="WKPDID_D3DDebugObjectNameW" /> property is correct.</summary>
        [Test]
        public static void WKPDID_D3DDebugObjectNameWTest()
        {
            Assert.That(WKPDID_D3DDebugObjectNameW, Is.EqualTo(new Guid(0x4cca5fd8, 0x921f, 0x42c8, 0x85, 0x66, 0x70, 0xca, 0xf2, 0xa9, 0xb7, 0x41)));
        }

        /// <summary>Validates that the value of the <see cref="WKPDID_CommentStringW" /> property is correct.</summary>
        [Test]
        public static void WKPDID_CommentStringWTest()
        {
            Assert.That(WKPDID_CommentStringW, Is.EqualTo(new Guid(0xd0149dc0, 0x90e8, 0x4ec8, 0x81, 0x44, 0xe9, 0x00, 0xad, 0x26, 0x6b, 0xb2)));
        }

        /// <summary>Validates that the value of the <see cref="WKPDID_D3D12UniqueObjectId" /> property is correct.</summary>
        [Test]
        public static void WKPDID_D3D12UniqueObjectIdTest()
        {
            Assert.That(WKPDID_D3D12UniqueObjectId, Is.EqualTo(new Guid(0x1b39de15, 0xec04, 0x4bae, 0xba, 0x4d, 0x8c, 0xef, 0x79, 0xfc, 0x04, 0xc1)));
        }

        /// <summary>Validates that the value of the <see cref="D3D_TEXTURE_LAYOUT_ROW_MAJOR" /> property is correct.</summary>
        [Test]
        public static void D3D_TEXTURE_LAYOUT_ROW_MAJORTest()
        {
            Assert.That(D3D_TEXTURE_LAYOUT_ROW_MAJOR, Is.EqualTo(new Guid(0xb5dc234f, 0x72bb, 0x4bec, 0x97, 0x05, 0x8c, 0xf2, 0x58, 0xdf, 0x6b, 0x6c)));
        }

        /// <summary>Validates that the value of the <see cref="D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE" /> property is correct.</summary>
        [Test]
        public static void D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLETest()
        {
            Assert.That(D3D_TEXTURE_LAYOUT_64KB_STANDARD_SWIZZLE, Is.EqualTo(new Guid(0x4c0f29e3, 0x3f5f, 0x4d35, 0x84, 0xc9, 0xbc, 0x09, 0x83, 0xb6, 0x2c, 0x28)));
        }
    }
}
