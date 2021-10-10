// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="IID_ITfMSAAControl" /> property is correct.</summary>
        [Test]
        public static void IID_ITfMSAAControlTest()
        {
            Assert.That(IID_ITfMSAAControl, Is.EqualTo(new Guid(0xb5f8fb3b, 0x393f, 0x4f7c, 0x84, 0xcb, 0x50, 0x49, 0x24, 0xc2, 0x70, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IInternalDocWrap" /> property is correct.</summary>
        [Test]
        public static void IID_IInternalDocWrapTest()
        {
            Assert.That(IID_IInternalDocWrap, Is.EqualTo(new Guid(0xE1AA6466, 0x9DB4, 0x40ba, 0xBE, 0x03, 0x77, 0xC3, 0x8E, 0x8E, 0x60, 0xB2)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ITextStoreACPEx" /> property is correct.</summary>
        [Test]
        public static void IID_ITextStoreACPExTest()
        {
            Assert.That(IID_ITextStoreACPEx, Is.EqualTo(new Guid(0xA2DE3BC2, 0x3D8E, 0x11d3, 0x81, 0xA9, 0xF7, 0x53, 0xFB, 0xE6, 0x1A, 0x00)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ITextStoreAnchorEx" /> property is correct.</summary>
        [Test]
        public static void IID_ITextStoreAnchorExTest()
        {
            Assert.That(IID_ITextStoreAnchorEx, Is.EqualTo(new Guid(0xA2DE3BC1, 0x3D8E, 0x11d3, 0x81, 0xA9, 0xF7, 0x53, 0xFB, 0xE6, 0x1A, 0x00)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ITextStoreACPSinkEx" /> property is correct.</summary>
        [Test]
        public static void IID_ITextStoreACPSinkExTest()
        {
            Assert.That(IID_ITextStoreACPSinkEx, Is.EqualTo(new Guid(0x2bdf9464, 0x41e2, 0x43e3, 0x95, 0x0c, 0xa6, 0x86, 0x5b, 0xa2, 0x5c, 0xd4)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ITextStoreSinkAnchorEx" /> property is correct.</summary>
        [Test]
        public static void IID_ITextStoreSinkAnchorExTest()
        {
            Assert.That(IID_ITextStoreSinkAnchorEx, Is.EqualTo(new Guid(0x25642426, 0x028d, 0x4474, 0x97, 0x7b, 0x11, 0x1b, 0xb1, 0x14, 0xfe, 0x3e)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IAccDictionary" /> property is correct.</summary>
        [Test]
        public static void IID_IAccDictionaryTest()
        {
            Assert.That(IID_IAccDictionary, Is.EqualTo(new Guid(0x1DC4CB5F, 0xD737, 0x474d, 0xAD, 0xE9, 0x5C, 0xCF, 0xC9, 0xBC, 0x1C, 0xC9)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVersionInfo" /> property is correct.</summary>
        [Test]
        public static void IID_IVersionInfoTest()
        {
            Assert.That(IID_IVersionInfo, Is.EqualTo(new Guid(0x401518EC, 0xDB00, 0x4611, 0x9B, 0x29, 0x2A, 0x0E, 0x4B, 0x9A, 0xFA, 0x85)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ICoCreateLocally" /> property is correct.</summary>
        [Test]
        public static void IID_ICoCreateLocallyTest()
        {
            Assert.That(IID_ICoCreateLocally, Is.EqualTo(new Guid(0x03DE00AA, 0xF272, 0x41e3, 0x99, 0xCB, 0x03, 0xC5, 0xE8, 0x11, 0x4E, 0xA0)));
        }

        /// <summary>Validates that the value of the <see cref="IID_ICoCreatedLocally" /> property is correct.</summary>
        [Test]
        public static void IID_ICoCreatedLocallyTest()
        {
            Assert.That(IID_ICoCreatedLocally, Is.EqualTo(new Guid(0x0A53EB6C, 0x1908, 0x4742, 0x8C, 0xFF, 0x2C, 0xEE, 0x2E, 0x93, 0xF9, 0x4C)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IAccStore" /> property is correct.</summary>
        [Test]
        public static void IID_IAccStoreTest()
        {
            Assert.That(IID_IAccStore, Is.EqualTo(new Guid(0xE2CD4A63, 0x2B72, 0x4D48, 0xB7, 0x39, 0x95, 0xE4, 0x76, 0x51, 0x95, 0xBA)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IAccServerDocMgr" /> property is correct.</summary>
        [Test]
        public static void IID_IAccServerDocMgrTest()
        {
            Assert.That(IID_IAccServerDocMgr, Is.EqualTo(new Guid(0xAD7C73CF, 0x6DD5, 0x4855, 0xAB, 0xC2, 0xB0, 0x4B, 0xAD, 0x5B, 0x91, 0x53)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IAccClientDocMgr" /> property is correct.</summary>
        [Test]
        public static void IID_IAccClientDocMgrTest()
        {
            Assert.That(IID_IAccClientDocMgr, Is.EqualTo(new Guid(0x4C896039, 0x7B6D, 0x49e6, 0xA8, 0xC1, 0x45, 0x11, 0x6A, 0x98, 0x29, 0x2B)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDocWrap" /> property is correct.</summary>
        [Test]
        public static void IID_IDocWrapTest()
        {
            Assert.That(IID_IDocWrap, Is.EqualTo(new Guid(0xDCD285FE, 0x0BE0, 0x43BD, 0x99, 0xC9, 0xAA, 0xAE, 0xC5, 0x13, 0xC5, 0x55)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IClonableWrapper" /> property is correct.</summary>
        [Test]
        public static void IID_IClonableWrapperTest()
        {
            Assert.That(IID_IClonableWrapper, Is.EqualTo(new Guid(0xB33E75FF, 0xE84C, 0x4dca, 0xA2, 0x5C, 0x33, 0xB8, 0xDC, 0x00, 0x33, 0x74)));
        }

        /// <summary>Validates that the value of the <see cref="LIBID_MSAATEXTLib" /> property is correct.</summary>
        [Test]
        public static void LIBID_MSAATEXTLibTest()
        {
            Assert.That(LIBID_MSAATEXTLib, Is.EqualTo(new Guid(0x150E2D7A, 0xDAC1, 0x4582, 0x94, 0x7D, 0x2A, 0x8F, 0xD7, 0x8B, 0x82, 0xCD)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MSAAControl" /> property is correct.</summary>
        [Test]
        public static void CLSID_MSAAControlTest()
        {
            Assert.That(CLSID_MSAAControl, Is.EqualTo(new Guid(0x08cd963f, 0x7a3e, 0x4f5c, 0x9b, 0xd8, 0xd6, 0x92, 0xbb, 0x04, 0x3c, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AccStore" /> property is correct.</summary>
        [Test]
        public static void CLSID_AccStoreTest()
        {
            Assert.That(CLSID_AccStore, Is.EqualTo(new Guid(0x5440837F, 0x4BFF, 0x4AE5, 0xA1, 0xB1, 0x77, 0x22, 0xEC, 0xC6, 0x33, 0x2A)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AccDictionary" /> property is correct.</summary>
        [Test]
        public static void CLSID_AccDictionaryTest()
        {
            Assert.That(CLSID_AccDictionary, Is.EqualTo(new Guid(0x6572EE16, 0x5FE5, 0x4331, 0xBB, 0x6D, 0x76, 0xA4, 0x9C, 0x56, 0xE4, 0x23)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AccServerDocMgr" /> property is correct.</summary>
        [Test]
        public static void CLSID_AccServerDocMgrTest()
        {
            Assert.That(CLSID_AccServerDocMgr, Is.EqualTo(new Guid(0x6089A37E, 0xEB8A, 0x482D, 0xBD, 0x6F, 0xF9, 0xF4, 0x69, 0x04, 0xD1, 0x6D)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AccClientDocMgr" /> property is correct.</summary>
        [Test]
        public static void CLSID_AccClientDocMgrTest()
        {
            Assert.That(CLSID_AccClientDocMgr, Is.EqualTo(new Guid(0xFC48CC30, 0x4F3E, 0x4fa1, 0x80, 0x3B, 0xAD, 0x0E, 0x19, 0x6A, 0x83, 0xB1)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DocWrap" /> property is correct.</summary>
        [Test]
        public static void CLSID_DocWrapTest()
        {
            Assert.That(CLSID_DocWrap, Is.EqualTo(new Guid(0xBF426F7E, 0x7A5E, 0x44D6, 0x83, 0x0C, 0xA3, 0x90, 0xEA, 0x94, 0x62, 0xA3)));
        }
    }
}
