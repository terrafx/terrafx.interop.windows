// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="LIBID_RendezvousSessionLib" /> property is correct.</summary>
        [Test]
        public static void LIBID_RendezvousSessionLibTest()
        {
            Assert.That(LIBID_RendezvousSessionLib, Is.EqualTo(new Guid(0xEFD856A4, 0x5A85, 0x4A1B, 0xAD, 0xD5, 0x2E, 0xAD, 0xAC, 0xE6, 0xF6, 0xA2)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IRendezvousSession" /> property is correct.</summary>
        [Test]
        public static void IID_IRendezvousSessionTest()
        {
            Assert.That(IID_IRendezvousSession, Is.EqualTo(new Guid(0x9BA4B1DD, 0x8B0C, 0x48B7, 0x9E, 0x7C, 0x2F, 0x25, 0x85, 0x7C, 0x8D, 0xF5)));
        }

        /// <summary>Validates that the value of the <see cref="DIID_DRendezvousSessionEvents" /> property is correct.</summary>
        [Test]
        public static void DIID_DRendezvousSessionEventsTest()
        {
            Assert.That(DIID_DRendezvousSessionEvents, Is.EqualTo(new Guid(0x3FA19CF8, 0x64C4, 0x4F53, 0xAE, 0x60, 0x63, 0x5B, 0x38, 0x06, 0xEC, 0xA6)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IRendezvousApplication" /> property is correct.</summary>
        [Test]
        public static void IID_IRendezvousApplicationTest()
        {
            Assert.That(IID_IRendezvousApplication, Is.EqualTo(new Guid(0x4F4D070B, 0xA275, 0x49FB, 0xB1, 0x0D, 0x8E, 0xC2, 0x63, 0x87, 0xB5, 0x0D)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_RendezvousApplication" /> property is correct.</summary>
        [Test]
        public static void CLSID_RendezvousApplicationTest()
        {
            Assert.That(CLSID_RendezvousApplication, Is.EqualTo(new Guid(0x0B7E019A, 0xB5DE, 0x47fa, 0x89, 0x66, 0x90, 0x82, 0xF8, 0x2F, 0xB1, 0x92)));
        }
    }
}
