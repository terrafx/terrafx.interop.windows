// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="CLSID_MFMediaSharingEngineClassFactory" /> property is correct.</summary>
        [Test]
        public static void CLSID_MFMediaSharingEngineClassFactoryTest()
        {
            Assert.That(CLSID_MFMediaSharingEngineClassFactory, Is.EqualTo(new Guid(0xf8e307fb, 0x6d45, 0x4ad3, 0x99, 0x93, 0x66, 0xcd, 0x5a, 0x52, 0x96, 0x59)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MFImageSharingEngineClassFactory" /> property is correct.</summary>
        [Test]
        public static void CLSID_MFImageSharingEngineClassFactoryTest()
        {
            Assert.That(CLSID_MFImageSharingEngineClassFactory, Is.EqualTo(new Guid(0xb22c3339, 0x87f3, 0x4059, 0xa0, 0xc5, 0x3, 0x7a, 0xa9, 0x70, 0x7e, 0xaf)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_PlayToSourceClassFactory" /> property is correct.</summary>
        [Test]
        public static void CLSID_PlayToSourceClassFactoryTest()
        {
            Assert.That(CLSID_PlayToSourceClassFactory, Is.EqualTo(new Guid(0xDA17539A, 0x3DC3, 0x42C1, 0xA7, 0x49, 0xA1, 0x83, 0xB5, 0x1F, 0x08, 0x5E)));
        }

        /// <summary>Validates that the value of the <see cref="GUID_PlayToService" /> property is correct.</summary>
        [Test]
        public static void GUID_PlayToServiceTest()
        {
            Assert.That(GUID_PlayToService, Is.EqualTo(new Guid(0xf6a8ff9d, 0x9e14, 0x41c9, 0xbf, 0x0f, 0x12, 0x0a, 0x2b, 0x3c, 0xe1, 0x20)));
        }

        /// <summary>Validates that the value of the <see cref="GUID_NativeDeviceService" /> property is correct.</summary>
        [Test]
        public static void GUID_NativeDeviceServiceTest()
        {
            Assert.That(GUID_NativeDeviceService, Is.EqualTo(new Guid(0xef71e53c, 0x52f4, 0x43c5, 0xb8, 0x6a, 0xad, 0x6c, 0xb2, 0x16, 0xa6, 0x1e)));
        }
    }
}
