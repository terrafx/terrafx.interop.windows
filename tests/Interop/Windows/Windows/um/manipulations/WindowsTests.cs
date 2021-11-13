// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="LIBID_ManipulationsLib" /> property is correct.</summary>
        [Test]
        public static void LIBID_ManipulationsLibTest()
        {
            Assert.That(LIBID_ManipulationsLib, Is.EqualTo(new Guid(0x935610b3, 0x6f81, 0x450f, 0x85, 0xd5, 0x42, 0xd3, 0xd2, 0x6c, 0x5c, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="IID__IManipulationEvents" /> property is correct.</summary>
        [Test]
        public static void IID__IManipulationEventsTest()
        {
            Assert.That(IID__IManipulationEvents, Is.EqualTo(new Guid(0x4f62c8da, 0x9c53, 0x4b22, 0x93, 0xdf, 0x92, 0x7a, 0x86, 0x2b, 0xbb, 0x03)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IInertiaProcessor" /> property is correct.</summary>
        [Test]
        public static void IID_IInertiaProcessorTest()
        {
            Assert.That(IID_IInertiaProcessor, Is.EqualTo(new Guid(0x18b00c6d, 0xc5ee, 0x41b1, 0x90, 0xa9, 0x9d, 0x4a, 0x92, 0x90, 0x95, 0xad)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IManipulationProcessor" /> property is correct.</summary>
        [Test]
        public static void IID_IManipulationProcessorTest()
        {
            Assert.That(IID_IManipulationProcessor, Is.EqualTo(new Guid(0xA22AC519, 0x8300, 0x48a0, 0xBE, 0xF4, 0xF1, 0xBE, 0x87, 0x37, 0xDB, 0xA4)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_InertiaProcessor" /> property is correct.</summary>
        [Test]
        public static void CLSID_InertiaProcessorTest()
        {
            Assert.That(CLSID_InertiaProcessor, Is.EqualTo(new Guid(0xabb27087, 0x4ce0, 0x4e58, 0xa0, 0xcb, 0xe2, 0x4d, 0xf9, 0x68, 0x14, 0xbe)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ManipulationProcessor" /> property is correct.</summary>
        [Test]
        public static void CLSID_ManipulationProcessorTest()
        {
            Assert.That(CLSID_ManipulationProcessor, Is.EqualTo(new Guid(0x597D4FB0, 0x47FD, 0x4aff, 0x89, 0xB9, 0xC6, 0xCF, 0xAE, 0x8C, 0xF0, 0x8E)));
        }
    }
}
