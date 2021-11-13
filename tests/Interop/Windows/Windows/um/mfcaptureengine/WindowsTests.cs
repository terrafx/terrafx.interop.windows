// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="CLSID_MFCaptureEngine" /> property is correct.</summary>
        [Test]
        public static void CLSID_MFCaptureEngineTest()
        {
            Assert.That(CLSID_MFCaptureEngine, Is.EqualTo(new Guid(0xefce38d3, 0x8914, 0x4674, 0xa7, 0xdf, 0xae, 0x1b, 0x3d, 0x65, 0x4b, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MFCaptureEngineClassFactory" /> property is correct.</summary>
        [Test]
        public static void CLSID_MFCaptureEngineClassFactoryTest()
        {
            Assert.That(CLSID_MFCaptureEngineClassFactory, Is.EqualTo(new Guid(0xefce38d3, 0x8914, 0x4674, 0xa7, 0xdf, 0xae, 0x1b, 0x3d, 0x65, 0x4b, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_DeviceReferenceSystemTime" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_DeviceReferenceSystemTimeTest()
        {
            Assert.That(MFSampleExtension_DeviceReferenceSystemTime, Is.EqualTo(new Guid(0x6523775a, 0xba2d, 0x405f, 0xb2, 0xc5, 0x01, 0xff, 0x88, 0xe2, 0xe8, 0xf6)));
        }
    }
}
