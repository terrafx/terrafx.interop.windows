// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="MF_MEDIA_SHARING_ENGINE_DEVICE_NAME" /> property is correct.</summary>
        [Test]
        public static void MF_MEDIA_SHARING_ENGINE_DEVICE_NAMETest()
        {
            Assert.That(MF_MEDIA_SHARING_ENGINE_DEVICE_NAME, Is.EqualTo(new Guid(0x771e05d1, 0x862f, 0x4299, 0x95, 0xac, 0xae, 0x81, 0xfd, 0x14, 0xf3, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MEDIA_SHARING_ENGINE_DEVICE" /> property is correct.</summary>
        [Test]
        public static void MF_MEDIA_SHARING_ENGINE_DEVICETest()
        {
            Assert.That(MF_MEDIA_SHARING_ENGINE_DEVICE, Is.EqualTo(new Guid(0xb461c58a, 0x7a08, 0x4b98, 0x99, 0xa8, 0x70, 0xfd, 0x5f, 0x3b, 0xad, 0xfd)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIME" /> property is correct.</summary>
        [Test]
        public static void MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIMETest()
        {
            Assert.That(MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIME, Is.EqualTo(new Guid(0x6f3497f5, 0xd528, 0x4a4f, 0x8d, 0xd7, 0xdb, 0x36, 0x65, 0x7e, 0xc4, 0xc9)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWN" /> property is correct.</summary>
        [Test]
        public static void MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWNTest()
        {
            Assert.That(MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWN, Is.EqualTo(new Guid(0xc112d94d, 0x6b9c, 0x48f8, 0xb6, 0xf9, 0x79, 0x50, 0xff, 0x9a, 0xb7, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_PREFERRED_SOURCE_URI" /> property is correct.</summary>
        [Test]
        public static void MF_PREFERRED_SOURCE_URITest()
        {
            Assert.That(MF_PREFERRED_SOURCE_URI, Is.EqualTo(new Guid(0x5fc85488, 0x436a, 0x4db8, 0x90, 0xaf, 0x4d, 0xb4, 0x2, 0xae, 0x5c, 0x57)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SHARING_ENGINE_SHAREDRENDERER" /> property is correct.</summary>
        [Test]
        public static void MF_SHARING_ENGINE_SHAREDRENDERERTest()
        {
            Assert.That(MF_SHARING_ENGINE_SHAREDRENDERER, Is.EqualTo(new Guid(0xefa446a0, 0x73e7, 0x404e, 0x8a, 0xe2, 0xfe, 0xf6, 0x0a, 0xf5, 0xa3, 0x2b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SHARING_ENGINE_CALLBACK" /> property is correct.</summary>
        [Test]
        public static void MF_SHARING_ENGINE_CALLBACKTest()
        {
            Assert.That(MF_SHARING_ENGINE_CALLBACK, Is.EqualTo(new Guid(0x57dc1e95, 0xd252, 0x43fa, 0x9b, 0xbc, 0x18, 0x0, 0x70, 0xee, 0xfe, 0x6d)));
        }

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
