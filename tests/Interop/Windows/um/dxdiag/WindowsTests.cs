// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="CLSID_DxDiagProvider" /> property is correct.</summary>
        [Test]
        public static void CLSID_DxDiagProviderTest()
        {
            Assert.That(CLSID_DxDiagProvider, Is.EqualTo(new Guid(0xA65B8071, 0x3BFE, 0x4213, 0x9A, 0x5B, 0x49, 0x1D, 0xA4, 0x46, 0x1C, 0xA7)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDxDiagProvider" /> property is correct.</summary>
        [Test]
        public static void IID_IDxDiagProviderTest()
        {
            Assert.That(IID_IDxDiagProvider, Is.EqualTo(new Guid(0x9C6B4CB0, 0x23F8, 0x49CC, 0xA3, 0xED, 0x45, 0xA5, 0x50, 0x00, 0xA6, 0xD2)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDxDiagContainer" /> property is correct.</summary>
        [Test]
        public static void IID_IDxDiagContainerTest()
        {
            Assert.That(IID_IDxDiagContainer, Is.EqualTo(new Guid(0x7D0F462F, 0x4064, 0x4862, 0xBC, 0x7F, 0x93, 0x3E, 0x50, 0x58, 0xC1, 0x0F)));
        }
    }
}
