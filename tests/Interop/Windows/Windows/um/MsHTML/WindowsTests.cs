// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="SID_SEditCommandTarget" /> property is correct.</summary>
        [Test]
        public static void SID_SEditCommandTargetTest()
        {
            Assert.That(SID_SEditCommandTarget, Is.EqualTo(new Guid(0x3050f4b5, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_EditStateCommands" /> property is correct.</summary>
        [Test]
        public static void CGID_EditStateCommandsTest()
        {
            Assert.That(CGID_EditStateCommands, Is.EqualTo(new Guid(0x3050f4b6, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SHTMLEditHost" /> property is correct.</summary>
        [Test]
        public static void SID_SHTMLEditHostTest()
        {
            Assert.That(SID_SHTMLEditHost, Is.EqualTo(new Guid(0x3050f6a0, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SHTMLEditServices" /> property is correct.</summary>
        [Test]
        public static void SID_SHTMLEditServicesTest()
        {
            Assert.That(SID_SHTMLEditServices, Is.EqualTo(new Guid(0x3050f7f9, 0x98b5, 0x11cf, 0xbb, 0x82, 0x00, 0xaa, 0x00, 0xbd, 0xce, 0x0b)));
        }
    }
}
