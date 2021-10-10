// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_None" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_NoneTest()
        {
            Assert.That(MEDIASUBTYPE_None, Is.EqualTo(new Guid(0xe436eb8e, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_Video" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_VideoTest()
        {
            Assert.That(MEDIATYPE_Video, Is.EqualTo(new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_Audio" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_AudioTest()
        {
            Assert.That(MEDIATYPE_Audio, Is.EqualTo(new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_Text" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_TextTest()
        {
            Assert.That(MEDIATYPE_Text, Is.EqualTo(new Guid(0x73747874, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_Midi" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_MidiTest()
        {
            Assert.That(MEDIATYPE_Midi, Is.EqualTo(new Guid(0x7364696D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_Stream" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_StreamTest()
        {
            Assert.That(MEDIATYPE_Stream, Is.EqualTo(new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_Interleaved" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_InterleavedTest()
        {
            Assert.That(MEDIATYPE_Interleaved, Is.EqualTo(new Guid(0x73766169, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_File" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_FileTest()
        {
            Assert.That(MEDIATYPE_File, Is.EqualTo(new Guid(0x656c6966, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_ScriptCommand" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_ScriptCommandTest()
        {
            Assert.That(MEDIATYPE_ScriptCommand, Is.EqualTo(new Guid(0x73636d64, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_AUXLine21Data" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_AUXLine21DataTest()
        {
            Assert.That(MEDIATYPE_AUXLine21Data, Is.EqualTo(new Guid(0x670aea80, 0x3a82, 0x11d0, 0xb7, 0x9b, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_AUXTeletextPage" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_AUXTeletextPageTest()
        {
            Assert.That(MEDIATYPE_AUXTeletextPage, Is.EqualTo(new Guid(0x11264acb, 0x37de, 0x4eba, 0x8c, 0x35, 0x7f, 0x4, 0xa1, 0xa6, 0x83, 0x32)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_CC_CONTAINER" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_CC_CONTAINERTest()
        {
            Assert.That(MEDIATYPE_CC_CONTAINER, Is.EqualTo(new Guid(0xaeb312e9, 0x3357, 0x43ca, 0xb7, 0x1, 0x97, 0xec, 0x19, 0x8e, 0x2b, 0x62)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_DTVCCData" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_DTVCCDataTest()
        {
            Assert.That(MEDIATYPE_DTVCCData, Is.EqualTo(new Guid(0xfb77e152, 0x53b2, 0x499c, 0xb4, 0x6b, 0x50, 0x9f, 0xc3, 0x3e, 0xdf, 0xd7)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_MSTVCaption" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_MSTVCaptionTest()
        {
            Assert.That(MEDIATYPE_MSTVCaption, Is.EqualTo(new Guid(0xB88B8A89, 0xB049, 0x4C80, 0xAD, 0xCF, 0x58, 0x98, 0x98, 0x5E, 0x22, 0xC1)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_VBI" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_VBITest()
        {
            Assert.That(MEDIATYPE_VBI, Is.EqualTo(new Guid(0xf72a76e1, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DVB_SUBTITLES" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DVB_SUBTITLESTest()
        {
            Assert.That(MEDIASUBTYPE_DVB_SUBTITLES, Is.EqualTo(new Guid(0x34FFCBC3, 0xD5B3, 0x4171, 0x90, 0x02, 0xD4, 0xC6, 0x03, 0x01, 0x69, 0x7F)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ISDB_CAPTIONS" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ISDB_CAPTIONSTest()
        {
            Assert.That(MEDIASUBTYPE_ISDB_CAPTIONS, Is.EqualTo(new Guid(0x059dd67d, 0x2e55, 0x4d41, 0x8d, 0x1b, 0x01, 0xf5, 0xe4, 0xf5, 0x06, 0x07)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ISDB_SUPERIMPOSE" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ISDB_SUPERIMPOSETest()
        {
            Assert.That(MEDIASUBTYPE_ISDB_SUPERIMPOSE, Is.EqualTo(new Guid(0x36dc6d28, 0xf1a6, 0x4216, 0x90, 0x48, 0x9c, 0xfc, 0xef, 0xeb, 0x5e, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_Timecode" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_TimecodeTest()
        {
            Assert.That(MEDIATYPE_Timecode, Is.EqualTo(new Guid(0x482dee3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_LMRT" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_LMRTTest()
        {
            Assert.That(MEDIATYPE_LMRT, Is.EqualTo(new Guid(0x74726c6d, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_URL_STREAM" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_URL_STREAMTest()
        {
            Assert.That(MEDIATYPE_URL_STREAM, Is.EqualTo(new Guid(0x736c7275, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_CLPL" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_CLPLTest()
        {
            Assert.That(MEDIASUBTYPE_CLPL, Is.EqualTo(new Guid(0x4C504C43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_YUYV" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_YUYVTest()
        {
            Assert.That(MEDIASUBTYPE_YUYV, Is.EqualTo(new Guid(0x56595559, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IYUV" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IYUVTest()
        {
            Assert.That(MEDIASUBTYPE_IYUV, Is.EqualTo(new Guid(0x56555949, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_YVU9" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_YVU9Test()
        {
            Assert.That(MEDIASUBTYPE_YVU9, Is.EqualTo(new Guid(0x39555659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Y411" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Y411Test()
        {
            Assert.That(MEDIASUBTYPE_Y411, Is.EqualTo(new Guid(0x31313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Y41P" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Y41PTest()
        {
            Assert.That(MEDIASUBTYPE_Y41P, Is.EqualTo(new Guid(0x50313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_YUY2" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_YUY2Test()
        {
            Assert.That(MEDIASUBTYPE_YUY2, Is.EqualTo(new Guid(0x32595559, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_YVYU" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_YVYUTest()
        {
            Assert.That(MEDIASUBTYPE_YVYU, Is.EqualTo(new Guid(0x55595659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_UYVY" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_UYVYTest()
        {
            Assert.That(MEDIASUBTYPE_UYVY, Is.EqualTo(new Guid(0x59565955, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Y211" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Y211Test()
        {
            Assert.That(MEDIASUBTYPE_Y211, Is.EqualTo(new Guid(0x31313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_CLJR" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_CLJRTest()
        {
            Assert.That(MEDIASUBTYPE_CLJR, Is.EqualTo(new Guid(0x524a4c43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IF09" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IF09Test()
        {
            Assert.That(MEDIASUBTYPE_IF09, Is.EqualTo(new Guid(0x39304649, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_CPLA" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_CPLATest()
        {
            Assert.That(MEDIASUBTYPE_CPLA, Is.EqualTo(new Guid(0x414c5043, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MJPG" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MJPGTest()
        {
            Assert.That(MEDIASUBTYPE_MJPG, Is.EqualTo(new Guid(0x47504A4D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_TVMJ" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_TVMJTest()
        {
            Assert.That(MEDIASUBTYPE_TVMJ, Is.EqualTo(new Guid(0x4A4D5654, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_WAKE" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_WAKETest()
        {
            Assert.That(MEDIASUBTYPE_WAKE, Is.EqualTo(new Guid(0x454B4157, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_CFCC" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_CFCCTest()
        {
            Assert.That(MEDIASUBTYPE_CFCC, Is.EqualTo(new Guid(0x43434643, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IJPG" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IJPGTest()
        {
            Assert.That(MEDIASUBTYPE_IJPG, Is.EqualTo(new Guid(0x47504A49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Plum" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_PlumTest()
        {
            Assert.That(MEDIASUBTYPE_Plum, Is.EqualTo(new Guid(0x6D756C50, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DVCS" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DVCSTest()
        {
            Assert.That(MEDIASUBTYPE_DVCS, Is.EqualTo(new Guid(0x53435644, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_H264" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_H264Test()
        {
            Assert.That(MEDIASUBTYPE_H264, Is.EqualTo(new Guid(0x34363248, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DVSD" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DVSDTest()
        {
            Assert.That(MEDIASUBTYPE_DVSD, Is.EqualTo(new Guid(0x44535644, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MDVF" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MDVFTest()
        {
            Assert.That(MEDIASUBTYPE_MDVF, Is.EqualTo(new Guid(0x4656444D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB1" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB1Test()
        {
            Assert.That(MEDIASUBTYPE_RGB1, Is.EqualTo(new Guid(0xe436eb78, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB4" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB4Test()
        {
            Assert.That(MEDIASUBTYPE_RGB4, Is.EqualTo(new Guid(0xe436eb79, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB8" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB8Test()
        {
            Assert.That(MEDIASUBTYPE_RGB8, Is.EqualTo(new Guid(0xe436eb7a, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB565" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB565Test()
        {
            Assert.That(MEDIASUBTYPE_RGB565, Is.EqualTo(new Guid(0xe436eb7b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB555" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB555Test()
        {
            Assert.That(MEDIASUBTYPE_RGB555, Is.EqualTo(new Guid(0xe436eb7c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB24" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB24Test()
        {
            Assert.That(MEDIASUBTYPE_RGB24, Is.EqualTo(new Guid(0xe436eb7d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB32" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB32Test()
        {
            Assert.That(MEDIASUBTYPE_RGB32, Is.EqualTo(new Guid(0xe436eb7e, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB1555" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB1555Test()
        {
            Assert.That(MEDIASUBTYPE_ARGB1555, Is.EqualTo(new Guid(0x297c55af, 0xe209, 0x4cb3, 0xb7, 0x57, 0xc7, 0x6d, 0x6b, 0x9c, 0x88, 0xa8)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB4444" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB4444Test()
        {
            Assert.That(MEDIASUBTYPE_ARGB4444, Is.EqualTo(new Guid(0x6e6415e6, 0x5c24, 0x425f, 0x93, 0xcd, 0x80, 0x10, 0x2b, 0x3d, 0x1c, 0xca)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB32" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB32Test()
        {
            Assert.That(MEDIASUBTYPE_ARGB32, Is.EqualTo(new Guid(0x773c9ac0, 0x3274, 0x11d0, 0xb7, 0x24, 0x0, 0xaa, 0x0, 0x6c, 0x1a, 0x1)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_A2R10G10B10" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_A2R10G10B10Test()
        {
            Assert.That(MEDIASUBTYPE_A2R10G10B10, Is.EqualTo(new Guid(0x2f8bb76d, 0xb644, 0x4550, 0xac, 0xf3, 0xd3, 0x0c, 0xaa, 0x65, 0xd5, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_A2B10G10R10" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_A2B10G10R10Test()
        {
            Assert.That(MEDIASUBTYPE_A2B10G10R10, Is.EqualTo(new Guid(0x576f7893, 0xbdf6, 0x48c4, 0x87, 0x5f, 0xae, 0x7b, 0x81, 0x83, 0x45, 0x67)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AYUV" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AYUVTest()
        {
            Assert.That(MEDIASUBTYPE_AYUV, Is.EqualTo(new Guid(0x56555941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AI44" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AI44Test()
        {
            Assert.That(MEDIASUBTYPE_AI44, Is.EqualTo(new Guid(0x34344941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IA44" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IA44Test()
        {
            Assert.That(MEDIASUBTYPE_IA44, Is.EqualTo(new Guid(0x34344149, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB32_D3D_DX7_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB32_D3D_DX7_RTTest()
        {
            Assert.That(MEDIASUBTYPE_RGB32_D3D_DX7_RT, Is.EqualTo(new Guid(0x32335237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB16_D3D_DX7_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB16_D3D_DX7_RTTest()
        {
            Assert.That(MEDIASUBTYPE_RGB16_D3D_DX7_RT, Is.EqualTo(new Guid(0x36315237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB32_D3D_DX7_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB32_D3D_DX7_RTTest()
        {
            Assert.That(MEDIASUBTYPE_ARGB32_D3D_DX7_RT, Is.EqualTo(new Guid(0x38384137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB4444_D3D_DX7_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB4444_D3D_DX7_RTTest()
        {
            Assert.That(MEDIASUBTYPE_ARGB4444_D3D_DX7_RT, Is.EqualTo(new Guid(0x34344137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB1555_D3D_DX7_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB1555_D3D_DX7_RTTest()
        {
            Assert.That(MEDIASUBTYPE_ARGB1555_D3D_DX7_RT, Is.EqualTo(new Guid(0x35314137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB32_D3D_DX9_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB32_D3D_DX9_RTTest()
        {
            Assert.That(MEDIASUBTYPE_RGB32_D3D_DX9_RT, Is.EqualTo(new Guid(0x32335239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RGB16_D3D_DX9_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RGB16_D3D_DX9_RTTest()
        {
            Assert.That(MEDIASUBTYPE_RGB16_D3D_DX9_RT, Is.EqualTo(new Guid(0x36315239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB32_D3D_DX9_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB32_D3D_DX9_RTTest()
        {
            Assert.That(MEDIASUBTYPE_ARGB32_D3D_DX9_RT, Is.EqualTo(new Guid(0x38384139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB4444_D3D_DX9_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB4444_D3D_DX9_RTTest()
        {
            Assert.That(MEDIASUBTYPE_ARGB4444_D3D_DX9_RT, Is.EqualTo(new Guid(0x34344139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_ARGB1555_D3D_DX9_RT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_ARGB1555_D3D_DX9_RTTest()
        {
            Assert.That(MEDIASUBTYPE_ARGB1555_D3D_DX9_RT, Is.EqualTo(new Guid(0x35314139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_YV12" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_YV12Test()
        {
            Assert.That(MEDIASUBTYPE_YV12, Is.EqualTo(new Guid(0x32315659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_NV12" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_NV12Test()
        {
            Assert.That(MEDIASUBTYPE_NV12, Is.EqualTo(new Guid(0x3231564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_NV11" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_NV11Test()
        {
            Assert.That(MEDIASUBTYPE_NV11, Is.EqualTo(new Guid(0x3131564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_P208" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_P208Test()
        {
            Assert.That(MEDIASUBTYPE_P208, Is.EqualTo(new Guid(0x38303250, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_P210" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_P210Test()
        {
            Assert.That(MEDIASUBTYPE_P210, Is.EqualTo(new Guid(0x30313250, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_P216" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_P216Test()
        {
            Assert.That(MEDIASUBTYPE_P216, Is.EqualTo(new Guid(0x36313250, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_P010" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_P010Test()
        {
            Assert.That(MEDIASUBTYPE_P010, Is.EqualTo(new Guid(0x30313050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_P016" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_P016Test()
        {
            Assert.That(MEDIASUBTYPE_P016, Is.EqualTo(new Guid(0x36313050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Y210" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Y210Test()
        {
            Assert.That(MEDIASUBTYPE_Y210, Is.EqualTo(new Guid(0x30313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Y216" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Y216Test()
        {
            Assert.That(MEDIASUBTYPE_Y216, Is.EqualTo(new Guid(0x36313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_P408" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_P408Test()
        {
            Assert.That(MEDIASUBTYPE_P408, Is.EqualTo(new Guid(0x38303450, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_NV24" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_NV24Test()
        {
            Assert.That(MEDIASUBTYPE_NV24, Is.EqualTo(new Guid(0x3432564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_420O" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_420OTest()
        {
            Assert.That(MEDIASUBTYPE_420O, Is.EqualTo(new Guid(0x4F303234, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IMC1" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IMC1Test()
        {
            Assert.That(MEDIASUBTYPE_IMC1, Is.EqualTo(new Guid(0x31434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IMC2" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IMC2Test()
        {
            Assert.That(MEDIASUBTYPE_IMC2, Is.EqualTo(new Guid(0x32434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IMC3" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IMC3Test()
        {
            Assert.That(MEDIASUBTYPE_IMC3, Is.EqualTo(new Guid(0x33434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IMC4" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IMC4Test()
        {
            Assert.That(MEDIASUBTYPE_IMC4, Is.EqualTo(new Guid(0x34434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_S340" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_S340Test()
        {
            Assert.That(MEDIASUBTYPE_S340, Is.EqualTo(new Guid(0x30343353, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_S342" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_S342Test()
        {
            Assert.That(MEDIASUBTYPE_S342, Is.EqualTo(new Guid(0x32343353, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Overlay" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_OverlayTest()
        {
            Assert.That(MEDIASUBTYPE_Overlay, Is.EqualTo(new Guid(0xe436eb7f, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MPEG1Packet" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MPEG1PacketTest()
        {
            Assert.That(MEDIASUBTYPE_MPEG1Packet, Is.EqualTo(new Guid(0xe436eb80, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MPEG1Payload" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MPEG1PayloadTest()
        {
            Assert.That(MEDIASUBTYPE_MPEG1Payload, Is.EqualTo(new Guid(0xe436eb81, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MPEG1AudioPayload" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MPEG1AudioPayloadTest()
        {
            Assert.That(MEDIASUBTYPE_MPEG1AudioPayload, Is.EqualTo(new Guid(0x00000050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_MPEG1SystemStream" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_MPEG1SystemStreamTest()
        {
            Assert.That(MEDIATYPE_MPEG1SystemStream, Is.EqualTo(new Guid(0xe436eb82, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MPEG1System" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MPEG1SystemTest()
        {
            Assert.That(MEDIASUBTYPE_MPEG1System, Is.EqualTo(new Guid(0xe436eb84, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MPEG1VideoCD" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MPEG1VideoCDTest()
        {
            Assert.That(MEDIASUBTYPE_MPEG1VideoCD, Is.EqualTo(new Guid(0xe436eb85, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MPEG1Video" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MPEG1VideoTest()
        {
            Assert.That(MEDIASUBTYPE_MPEG1Video, Is.EqualTo(new Guid(0xe436eb86, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_MPEG1Audio" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_MPEG1AudioTest()
        {
            Assert.That(MEDIASUBTYPE_MPEG1Audio, Is.EqualTo(new Guid(0xe436eb87, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Avi" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AviTest()
        {
            Assert.That(MEDIASUBTYPE_Avi, Is.EqualTo(new Guid(0xe436eb88, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Asf" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AsfTest()
        {
            Assert.That(MEDIASUBTYPE_Asf, Is.EqualTo(new Guid(0x3db80f90, 0x9412, 0x11d1, 0xad, 0xed, 0x0, 0x0, 0xf8, 0x75, 0x4b, 0x99)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_QTMovie" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_QTMovieTest()
        {
            Assert.That(MEDIASUBTYPE_QTMovie, Is.EqualTo(new Guid(0xe436eb89, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_QTRpza" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_QTRpzaTest()
        {
            Assert.That(MEDIASUBTYPE_QTRpza, Is.EqualTo(new Guid(0x617a7072, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_QTSmc" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_QTSmcTest()
        {
            Assert.That(MEDIASUBTYPE_QTSmc, Is.EqualTo(new Guid(0x20636d73, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_QTRle" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_QTRleTest()
        {
            Assert.That(MEDIASUBTYPE_QTRle, Is.EqualTo(new Guid(0x20656c72, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_QTJpeg" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_QTJpegTest()
        {
            Assert.That(MEDIASUBTYPE_QTJpeg, Is.EqualTo(new Guid(0x6765706a, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_PCMAudio_Obsolete" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_PCMAudio_ObsoleteTest()
        {
            Assert.That(MEDIASUBTYPE_PCMAudio_Obsolete, Is.EqualTo(new Guid(0xe436eb8a, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_PCM" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_PCMTest()
        {
            Assert.That(MEDIASUBTYPE_PCM, Is.EqualTo(new Guid(0x00000001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_WAVE" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_WAVETest()
        {
            Assert.That(MEDIASUBTYPE_WAVE, Is.EqualTo(new Guid(0xe436eb8b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AU" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AUTest()
        {
            Assert.That(MEDIASUBTYPE_AU, Is.EqualTo(new Guid(0xe436eb8c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AIFF" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AIFFTest()
        {
            Assert.That(MEDIASUBTYPE_AIFF, Is.EqualTo(new Guid(0xe436eb8d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_dvsd" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_dvsdTest()
        {
            Assert.That(MEDIASUBTYPE_dvsd, Is.EqualTo(new Guid(0x64737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_dvhd" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_dvhdTest()
        {
            Assert.That(MEDIASUBTYPE_dvhd, Is.EqualTo(new Guid(0x64687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_dvsl" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_dvslTest()
        {
            Assert.That(MEDIASUBTYPE_dvsl, Is.EqualTo(new Guid(0x6c737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_dv25" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_dv25Test()
        {
            Assert.That(MEDIASUBTYPE_dv25, Is.EqualTo(new Guid(0x35327664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_dv50" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_dv50Test()
        {
            Assert.That(MEDIASUBTYPE_dv50, Is.EqualTo(new Guid(0x30357664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_dvh1" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_dvh1Test()
        {
            Assert.That(MEDIASUBTYPE_dvh1, Is.EqualTo(new Guid(0x31687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Line21_BytePair" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Line21_BytePairTest()
        {
            Assert.That(MEDIASUBTYPE_Line21_BytePair, Is.EqualTo(new Guid(0x6e8d4a22, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Line21_GOPPacket" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Line21_GOPPacketTest()
        {
            Assert.That(MEDIASUBTYPE_Line21_GOPPacket, Is.EqualTo(new Guid(0x6e8d4a23, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_Line21_VBIRawData" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_Line21_VBIRawDataTest()
        {
            Assert.That(MEDIASUBTYPE_Line21_VBIRawData, Is.EqualTo(new Guid(0x6e8d4a24, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_708_608Data" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_708_608DataTest()
        {
            Assert.That(MEDIASUBTYPE_708_608Data, Is.EqualTo(new Guid(0xaf414bc, 0x4ed2, 0x445e, 0x98, 0x39, 0x8f, 0x9, 0x55, 0x68, 0xab, 0x3c)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DtvCcData" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DtvCcDataTest()
        {
            Assert.That(MEDIASUBTYPE_DtvCcData, Is.EqualTo(new Guid(0xF52ADDAA, 0x36F0, 0x43F5, 0x95, 0xEA, 0x6D, 0x86, 0x64, 0x84, 0x26, 0x2A)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_CC_CONTAINER" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_CC_CONTAINERTest()
        {
            Assert.That(MEDIASUBTYPE_CC_CONTAINER, Is.EqualTo(new Guid(0x7ea626db, 0x54da, 0x437b, 0xbe, 0x9f, 0xf7, 0x30, 0x73, 0xad, 0xfa, 0x3c)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_TELETEXT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_TELETEXTTest()
        {
            Assert.That(MEDIASUBTYPE_TELETEXT, Is.EqualTo(new Guid(0xf72a76e3, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_VBI" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_VBITest()
        {
            Assert.That(MEDIASUBTYPE_VBI, Is.EqualTo(new Guid(0x663da43c, 0x3e8, 0x4e9a, 0x9c, 0xd5, 0xbf, 0x11, 0xed, 0xd, 0xef, 0x76)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_WSS" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_WSSTest()
        {
            Assert.That(MEDIASUBTYPE_WSS, Is.EqualTo(new Guid(0x2791D576, 0x8E7A, 0x466F, 0x9E, 0x90, 0x5D, 0x3F, 0x30, 0x83, 0x73, 0x8B)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_XDS" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_XDSTest()
        {
            Assert.That(MEDIASUBTYPE_XDS, Is.EqualTo(new Guid(0x1ca73e3, 0xdce6, 0x4575, 0xaf, 0xe1, 0x2b, 0xf1, 0xc9, 0x2, 0xca, 0xf3)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_VPS" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_VPSTest()
        {
            Assert.That(MEDIASUBTYPE_VPS, Is.EqualTo(new Guid(0xa1b3f620, 0x9792, 0x4d8d, 0x81, 0xa4, 0x86, 0xaf, 0x25, 0x77, 0x20, 0x90)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DRM_Audio" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DRM_AudioTest()
        {
            Assert.That(MEDIASUBTYPE_DRM_Audio, Is.EqualTo(new Guid(0x00000009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_IEEE_FLOAT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_IEEE_FLOATTest()
        {
            Assert.That(MEDIASUBTYPE_IEEE_FLOAT, Is.EqualTo(new Guid(0x00000003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DOLBY_AC3_SPDIF" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DOLBY_AC3_SPDIFTest()
        {
            Assert.That(MEDIASUBTYPE_DOLBY_AC3_SPDIF, Is.EqualTo(new Guid(0x00000092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_RAW_SPORT" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_RAW_SPORTTest()
        {
            Assert.That(MEDIASUBTYPE_RAW_SPORT, Is.EqualTo(new Guid(0x00000240, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_SPDIF_TAG_241h" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_SPDIF_TAG_241hTest()
        {
            Assert.That(MEDIASUBTYPE_SPDIF_TAG_241h, Is.EqualTo(new Guid(0x00000241, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DssVideo" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DssVideoTest()
        {
            Assert.That(MEDIASUBTYPE_DssVideo, Is.EqualTo(new Guid(0xa0af4f81, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_DssAudio" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_DssAudioTest()
        {
            Assert.That(MEDIASUBTYPE_DssAudio, Is.EqualTo(new Guid(0xa0af4f82, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_VPVideo" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_VPVideoTest()
        {
            Assert.That(MEDIASUBTYPE_VPVideo, Is.EqualTo(new Guid(0x5a9b6a40, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_VPVBI" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_VPVBITest()
        {
            Assert.That(MEDIASUBTYPE_VPVBI, Is.EqualTo(new Guid(0x5a9b6a41, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CaptureGraphBuilder" /> property is correct.</summary>
        [Test]
        public static void CLSID_CaptureGraphBuilderTest()
        {
            Assert.That(CLSID_CaptureGraphBuilder, Is.EqualTo(new Guid(0xBF87B6E0, 0x8C27, 0x11d0, 0xB3, 0xF0, 0x0, 0xAA, 0x00, 0x37, 0x61, 0xC5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CaptureGraphBuilder2" /> property is correct.</summary>
        [Test]
        public static void CLSID_CaptureGraphBuilder2Test()
        {
            Assert.That(CLSID_CaptureGraphBuilder2, Is.EqualTo(new Guid(0xBF87B6E1, 0x8C27, 0x11d0, 0xB3, 0xF0, 0x0, 0xAA, 0x00, 0x37, 0x61, 0xC5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ProtoFilterGraph" /> property is correct.</summary>
        [Test]
        public static void CLSID_ProtoFilterGraphTest()
        {
            Assert.That(CLSID_ProtoFilterGraph, Is.EqualTo(new Guid(0xe436ebb0, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SystemClock" /> property is correct.</summary>
        [Test]
        public static void CLSID_SystemClockTest()
        {
            Assert.That(CLSID_SystemClock, Is.EqualTo(new Guid(0xe436ebb1, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FilterMapper" /> property is correct.</summary>
        [Test]
        public static void CLSID_FilterMapperTest()
        {
            Assert.That(CLSID_FilterMapper, Is.EqualTo(new Guid(0xe436ebb2, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FilterGraph" /> property is correct.</summary>
        [Test]
        public static void CLSID_FilterGraphTest()
        {
            Assert.That(CLSID_FilterGraph, Is.EqualTo(new Guid(0xe436ebb3, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FilterGraphNoThread" /> property is correct.</summary>
        [Test]
        public static void CLSID_FilterGraphNoThreadTest()
        {
            Assert.That(CLSID_FilterGraphNoThread, Is.EqualTo(new Guid(0xe436ebb8, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FilterGraphPrivateThread" /> property is correct.</summary>
        [Test]
        public static void CLSID_FilterGraphPrivateThreadTest()
        {
            Assert.That(CLSID_FilterGraphPrivateThread, Is.EqualTo(new Guid(0xa3ecbc41, 0x581a, 0x4476, 0xb6, 0x93, 0xa6, 0x33, 0x40, 0x46, 0x2d, 0x8b)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MPEG1Doc" /> property is correct.</summary>
        [Test]
        public static void CLSID_MPEG1DocTest()
        {
            Assert.That(CLSID_MPEG1Doc, Is.EqualTo(new Guid(0xe4bbd160, 0x4269, 0x11ce, 0x83, 0x8d, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FileSource" /> property is correct.</summary>
        [Test]
        public static void CLSID_FileSourceTest()
        {
            Assert.That(CLSID_FileSource, Is.EqualTo(new Guid(0x701722e0, 0x8ae3, 0x11ce, 0xa8, 0x5c, 0x00, 0xaa, 0x00, 0x2f, 0xea, 0xb5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MPEG1PacketPlayer" /> property is correct.</summary>
        [Test]
        public static void CLSID_MPEG1PacketPlayerTest()
        {
            Assert.That(CLSID_MPEG1PacketPlayer, Is.EqualTo(new Guid(0x26c25940, 0x4ca9, 0x11ce, 0xa8, 0x28, 0x0, 0xaa, 0x0, 0x2f, 0xea, 0xb5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MPEG1Splitter" /> property is correct.</summary>
        [Test]
        public static void CLSID_MPEG1SplitterTest()
        {
            Assert.That(CLSID_MPEG1Splitter, Is.EqualTo(new Guid(0x336475d0, 0x942a, 0x11ce, 0xa8, 0x70, 0x00, 0xaa, 0x00, 0x2f, 0xea, 0xb5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CMpegVideoCodec" /> property is correct.</summary>
        [Test]
        public static void CLSID_CMpegVideoCodecTest()
        {
            Assert.That(CLSID_CMpegVideoCodec, Is.EqualTo(new Guid(0xfeb50740, 0x7bef, 0x11ce, 0x9b, 0xd9, 0x0, 0x0, 0xe2, 0x2, 0x59, 0x9c)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CMpegAudioCodec" /> property is correct.</summary>
        [Test]
        public static void CLSID_CMpegAudioCodecTest()
        {
            Assert.That(CLSID_CMpegAudioCodec, Is.EqualTo(new Guid(0x4a2286e0, 0x7bef, 0x11ce, 0x9b, 0xd9, 0x0, 0x0, 0xe2, 0x2, 0x59, 0x9c)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_TextRender" /> property is correct.</summary>
        [Test]
        public static void CLSID_TextRenderTest()
        {
            Assert.That(CLSID_TextRender, Is.EqualTo(new Guid(0xe30629d3, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_InfTee" /> property is correct.</summary>
        [Test]
        public static void CLSID_InfTeeTest()
        {
            Assert.That(CLSID_InfTee, Is.EqualTo(new Guid(0xf8388a40, 0xd5bb, 0x11d0, 0xbe, 0x5a, 0x0, 0x80, 0xc7, 0x6, 0x56, 0x8e)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AviSplitter" /> property is correct.</summary>
        [Test]
        public static void CLSID_AviSplitterTest()
        {
            Assert.That(CLSID_AviSplitter, Is.EqualTo(new Guid(0x1b544c20, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AviReader" /> property is correct.</summary>
        [Test]
        public static void CLSID_AviReaderTest()
        {
            Assert.That(CLSID_AviReader, Is.EqualTo(new Guid(0x1b544c21, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VfwCapture" /> property is correct.</summary>
        [Test]
        public static void CLSID_VfwCaptureTest()
        {
            Assert.That(CLSID_VfwCapture, Is.EqualTo(new Guid(0x1b544c22, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CaptureProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_CapturePropertiesTest()
        {
            Assert.That(CLSID_CaptureProperties, Is.EqualTo(new Guid(0x1B544c22, 0xFD0B, 0x11ce, 0x8C, 0x63, 0x00, 0xAA, 0x00, 0x44, 0xB5, 0x1F)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FGControl" /> property is correct.</summary>
        [Test]
        public static void CLSID_FGControlTest()
        {
            Assert.That(CLSID_FGControl, Is.EqualTo(new Guid(0xe436ebb4, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MOVReader" /> property is correct.</summary>
        [Test]
        public static void CLSID_MOVReaderTest()
        {
            Assert.That(CLSID_MOVReader, Is.EqualTo(new Guid(0x44584800, 0xf8ee, 0x11ce, 0xb2, 0xd4, 0x00, 0xdd, 0x1, 0x10, 0x1b, 0x85)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_QuickTimeParser" /> property is correct.</summary>
        [Test]
        public static void CLSID_QuickTimeParserTest()
        {
            Assert.That(CLSID_QuickTimeParser, Is.EqualTo(new Guid(0xd51bd5a0, 0x7548, 0x11cf, 0xa5, 0x20, 0x0, 0x80, 0xc7, 0x7e, 0xf5, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_QTDec" /> property is correct.</summary>
        [Test]
        public static void CLSID_QTDecTest()
        {
            Assert.That(CLSID_QTDec, Is.EqualTo(new Guid(0xfdfe9681, 0x74a3, 0x11d0, 0xaf, 0xa7, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AVIDoc" /> property is correct.</summary>
        [Test]
        public static void CLSID_AVIDocTest()
        {
            Assert.That(CLSID_AVIDoc, Is.EqualTo(new Guid(0xd3588ab0, 0x0781, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0xb, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoRenderer" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoRendererTest()
        {
            Assert.That(CLSID_VideoRenderer, Is.EqualTo(new Guid(0x70e102b0, 0x5556, 0x11ce, 0x97, 0xc0, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_Colour" /> property is correct.</summary>
        [Test]
        public static void CLSID_ColourTest()
        {
            Assert.That(CLSID_Colour, Is.EqualTo(new Guid(0x1643e180, 0x90f5, 0x11ce, 0x97, 0xd5, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_Dither" /> property is correct.</summary>
        [Test]
        public static void CLSID_DitherTest()
        {
            Assert.That(CLSID_Dither, Is.EqualTo(new Guid(0x1da08500, 0x9edc, 0x11cf, 0xbc, 0x10, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ModexRenderer" /> property is correct.</summary>
        [Test]
        public static void CLSID_ModexRendererTest()
        {
            Assert.That(CLSID_ModexRenderer, Is.EqualTo(new Guid(0x7167665, 0x5011, 0x11cf, 0xbf, 0x33, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioRender" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioRenderTest()
        {
            Assert.That(CLSID_AudioRender, Is.EqualTo(new Guid(0xe30629d1, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioPropertiesTest()
        {
            Assert.That(CLSID_AudioProperties, Is.EqualTo(new Guid(0x05589faf, 0xc356, 0x11ce, 0xbf, 0x01, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DSoundRender" /> property is correct.</summary>
        [Test]
        public static void CLSID_DSoundRenderTest()
        {
            Assert.That(CLSID_DSoundRender, Is.EqualTo(new Guid(0x79376820, 0x07D0, 0x11CF, 0xA2, 0x4D, 0x0, 0x20, 0xAF, 0xD7, 0x97, 0x67)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioRecord" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioRecordTest()
        {
            Assert.That(CLSID_AudioRecord, Is.EqualTo(new Guid(0xe30629d2, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioInputMixerProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioInputMixerPropertiesTest()
        {
            Assert.That(CLSID_AudioInputMixerProperties, Is.EqualTo(new Guid(0x2ca8ca52, 0x3c3f, 0x11d2, 0xb7, 0x3d, 0x0, 0xc0, 0x4f, 0xb6, 0xbd, 0x3d)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AVIDec" /> property is correct.</summary>
        [Test]
        public static void CLSID_AVIDecTest()
        {
            Assert.That(CLSID_AVIDec, Is.EqualTo(new Guid(0xcf49d4e0, 0x1115, 0x11ce, 0xb0, 0x3a, 0x0, 0x20, 0xaf, 0xb, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AVIDraw" /> property is correct.</summary>
        [Test]
        public static void CLSID_AVIDrawTest()
        {
            Assert.That(CLSID_AVIDraw, Is.EqualTo(new Guid(0xa888df60, 0x1e90, 0x11cf, 0xac, 0x98, 0x0, 0xaa, 0x0, 0x4c, 0xf, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ACMWrapper" /> property is correct.</summary>
        [Test]
        public static void CLSID_ACMWrapperTest()
        {
            Assert.That(CLSID_ACMWrapper, Is.EqualTo(new Guid(0x6a08cf80, 0x0e18, 0x11cf, 0xa2, 0x4d, 0x0, 0x20, 0xaf, 0xd7, 0x97, 0x67)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AsyncReader" /> property is correct.</summary>
        [Test]
        public static void CLSID_AsyncReaderTest()
        {
            Assert.That(CLSID_AsyncReader, Is.EqualTo(new Guid(0xe436ebb5, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_URLReader" /> property is correct.</summary>
        [Test]
        public static void CLSID_URLReaderTest()
        {
            Assert.That(CLSID_URLReader, Is.EqualTo(new Guid(0xe436ebb6, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_PersistMonikerPID" /> property is correct.</summary>
        [Test]
        public static void CLSID_PersistMonikerPIDTest()
        {
            Assert.That(CLSID_PersistMonikerPID, Is.EqualTo(new Guid(0xe436ebb7, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AVICo" /> property is correct.</summary>
        [Test]
        public static void CLSID_AVICoTest()
        {
            Assert.That(CLSID_AVICo, Is.EqualTo(new Guid(0xd76e2820, 0x1563, 0x11cf, 0xac, 0x98, 0x0, 0xaa, 0x0, 0x4c, 0xf, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FileWriter" /> property is correct.</summary>
        [Test]
        public static void CLSID_FileWriterTest()
        {
            Assert.That(CLSID_FileWriter, Is.EqualTo(new Guid(0x8596e5f0, 0xda5, 0x11d0, 0xbd, 0x21, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AviDest" /> property is correct.</summary>
        [Test]
        public static void CLSID_AviDestTest()
        {
            Assert.That(CLSID_AviDest, Is.EqualTo(new Guid(0xe2510970, 0xf137, 0x11ce, 0x8b, 0x67, 0x0, 0xaa, 0x0, 0xa3, 0xf1, 0xa6)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AviMuxProptyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_AviMuxProptyPageTest()
        {
            Assert.That(CLSID_AviMuxProptyPage, Is.EqualTo(new Guid(0xc647b5c0, 0x157c, 0x11d0, 0xbd, 0x23, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AviMuxProptyPage1" /> property is correct.</summary>
        [Test]
        public static void CLSID_AviMuxProptyPage1Test()
        {
            Assert.That(CLSID_AviMuxProptyPage1, Is.EqualTo(new Guid(0xa9ae910, 0x85c0, 0x11d0, 0xbd, 0x42, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AVIMIDIRender" /> property is correct.</summary>
        [Test]
        public static void CLSID_AVIMIDIRenderTest()
        {
            Assert.That(CLSID_AVIMIDIRender, Is.EqualTo(new Guid(0x07b65360, 0xc445, 0x11ce, 0xaf, 0xde, 0x00, 0xaa, 0x00, 0x6c, 0x14, 0xf4)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_WMAsfReader" /> property is correct.</summary>
        [Test]
        public static void CLSID_WMAsfReaderTest()
        {
            Assert.That(CLSID_WMAsfReader, Is.EqualTo(new Guid(0x187463a0, 0x5bb7, 0x11d3, 0xac, 0xbe, 0x0, 0x80, 0xc7, 0x5e, 0x24, 0x6e)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_WMAsfWriter" /> property is correct.</summary>
        [Test]
        public static void CLSID_WMAsfWriterTest()
        {
            Assert.That(CLSID_WMAsfWriter, Is.EqualTo(new Guid(0x7c23220e, 0x55bb, 0x11d3, 0x8b, 0x16, 0x0, 0xc0, 0x4f, 0xb6, 0xbd, 0x3d)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MPEG2Demultiplexer" /> property is correct.</summary>
        [Test]
        public static void CLSID_MPEG2DemultiplexerTest()
        {
            Assert.That(CLSID_MPEG2Demultiplexer, Is.EqualTo(new Guid(0xafb6c280, 0x2c41, 0x11d3, 0x8a, 0x60, 0x00, 0x00, 0xf8, 0x1e, 0x0e, 0x4a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MPEG2Demultiplexer_NoClock" /> property is correct.</summary>
        [Test]
        public static void CLSID_MPEG2Demultiplexer_NoClockTest()
        {
            Assert.That(CLSID_MPEG2Demultiplexer_NoClock, Is.EqualTo(new Guid(0x687d3367, 0x3644, 0x467a, 0xad, 0xfe, 0x6c, 0xd7, 0xa8, 0x5c, 0x4a, 0x2c)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MMSPLITTER" /> property is correct.</summary>
        [Test]
        public static void CLSID_MMSPLITTERTest()
        {
            Assert.That(CLSID_MMSPLITTER, Is.EqualTo(new Guid(0x3ae86b20, 0x7be8, 0x11d1, 0xab, 0xe6, 0x00, 0xa0, 0xc9, 0x05, 0xf3, 0x75)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_StreamBufferSink" /> property is correct.</summary>
        [Test]
        public static void CLSID_StreamBufferSinkTest()
        {
            Assert.That(CLSID_StreamBufferSink, Is.EqualTo(new Guid(0x2db47ae5, 0xcf39, 0x43c2, 0xb4, 0xd6, 0xc, 0xd8, 0xd9, 0x9, 0x46, 0xf4)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SBE2Sink" /> property is correct.</summary>
        [Test]
        public static void CLSID_SBE2SinkTest()
        {
            Assert.That(CLSID_SBE2Sink, Is.EqualTo(new Guid(0xe2448508, 0x95da, 0x4205, 0x9a, 0x27, 0x7e, 0xc8, 0x1e, 0x72, 0x3b, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_StreamBufferSource" /> property is correct.</summary>
        [Test]
        public static void CLSID_StreamBufferSourceTest()
        {
            Assert.That(CLSID_StreamBufferSource, Is.EqualTo(new Guid(0xc9f5fe02, 0xf851, 0x4eb5, 0x99, 0xee, 0xad, 0x60, 0x2a, 0xf1, 0xe6, 0x19)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_StreamBufferConfig" /> property is correct.</summary>
        [Test]
        public static void CLSID_StreamBufferConfigTest()
        {
            Assert.That(CLSID_StreamBufferConfig, Is.EqualTo(new Guid(0xfa8a68b2, 0xc864, 0x4ba2, 0xad, 0x53, 0xd3, 0x87, 0x6a, 0x87, 0x49, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_StreamBufferPropertyHandler" /> property is correct.</summary>
        [Test]
        public static void CLSID_StreamBufferPropertyHandlerTest()
        {
            Assert.That(CLSID_StreamBufferPropertyHandler, Is.EqualTo(new Guid(0xe37a73f8, 0xfb01, 0x43dc, 0x91, 0x4e, 0xaa, 0xee, 0x76, 0x9, 0x5a, 0xb9)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_StreamBufferThumbnailHandler" /> property is correct.</summary>
        [Test]
        public static void CLSID_StreamBufferThumbnailHandlerTest()
        {
            Assert.That(CLSID_StreamBufferThumbnailHandler, Is.EqualTo(new Guid(0x713790ee, 0x5ee1, 0x45ba, 0x80, 0x70, 0xa1, 0x33, 0x7d, 0x27, 0x62, 0xfa)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_Mpeg2VideoStreamAnalyzer" /> property is correct.</summary>
        [Test]
        public static void CLSID_Mpeg2VideoStreamAnalyzerTest()
        {
            Assert.That(CLSID_Mpeg2VideoStreamAnalyzer, Is.EqualTo(new Guid(0x6cfad761, 0x735d, 0x4aa5, 0x8a, 0xfc, 0xaf, 0x91, 0xa7, 0xd6, 0x1e, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_StreamBufferRecordingAttributes" /> property is correct.</summary>
        [Test]
        public static void CLSID_StreamBufferRecordingAttributesTest()
        {
            Assert.That(CLSID_StreamBufferRecordingAttributes, Is.EqualTo(new Guid(0xccaa63ac, 0x1057, 0x4778, 0xae, 0x92, 0x12, 0x6, 0xab, 0x9a, 0xce, 0xe6)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_StreamBufferComposeRecording" /> property is correct.</summary>
        [Test]
        public static void CLSID_StreamBufferComposeRecordingTest()
        {
            Assert.That(CLSID_StreamBufferComposeRecording, Is.EqualTo(new Guid(0xd682c4ba, 0xa90a, 0x42fe, 0xb9, 0xe1, 0x3, 0x10, 0x98, 0x49, 0xc4, 0x23)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SBE2File" /> property is correct.</summary>
        [Test]
        public static void CLSID_SBE2FileTest()
        {
            Assert.That(CLSID_SBE2File, Is.EqualTo(new Guid(0x93a094d7, 0x51e8, 0x485b, 0x90, 0x4a, 0x8d, 0x6b, 0x97, 0xdc, 0x6b, 0x39)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVVideoCodec" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVVideoCodecTest()
        {
            Assert.That(CLSID_DVVideoCodec, Is.EqualTo(new Guid(0xb1b77c00, 0xc3e4, 0x11cf, 0xaf, 0x79, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVVideoEnc" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVVideoEncTest()
        {
            Assert.That(CLSID_DVVideoEnc, Is.EqualTo(new Guid(0x13aa3650, 0xbb6f, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVSplitter" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVSplitterTest()
        {
            Assert.That(CLSID_DVSplitter, Is.EqualTo(new Guid(0x4eb31670, 0x9fc6, 0x11cf, 0xaf, 0x6e, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVMux" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVMuxTest()
        {
            Assert.That(CLSID_DVMux, Is.EqualTo(new Guid(0x129d7e40, 0xc10d, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SeekingPassThru" /> property is correct.</summary>
        [Test]
        public static void CLSID_SeekingPassThruTest()
        {
            Assert.That(CLSID_SeekingPassThru, Is.EqualTo(new Guid(0x60af76c, 0x68dd, 0x11d0, 0x8f, 0xc1, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0x9d)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_Line21Decoder" /> property is correct.</summary>
        [Test]
        public static void CLSID_Line21DecoderTest()
        {
            Assert.That(CLSID_Line21Decoder, Is.EqualTo(new Guid(0x6e8d4a20, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_Line21Decoder2" /> property is correct.</summary>
        [Test]
        public static void CLSID_Line21Decoder2Test()
        {
            Assert.That(CLSID_Line21Decoder2, Is.EqualTo(new Guid(0xe4206432, 0x01a1, 0x4bee, 0xb3, 0xe1, 0x37, 0x02, 0xc8, 0xed, 0xc5, 0x74)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CCAFilter" /> property is correct.</summary>
        [Test]
        public static void CLSID_CCAFilterTest()
        {
            Assert.That(CLSID_CCAFilter, Is.EqualTo(new Guid(0x3d07a539, 0x35ca, 0x447c, 0x9b, 0x5, 0x8d, 0x85, 0xce, 0x92, 0x4f, 0x9e)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_OverlayMixer" /> property is correct.</summary>
        [Test]
        public static void CLSID_OverlayMixerTest()
        {
            Assert.That(CLSID_OverlayMixer, Is.EqualTo(new Guid(0xcd8743a1, 0x3736, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VBISurfaces" /> property is correct.</summary>
        [Test]
        public static void CLSID_VBISurfacesTest()
        {
            Assert.That(CLSID_VBISurfaces, Is.EqualTo(new Guid(0x814b9800, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_WSTDecoder" /> property is correct.</summary>
        [Test]
        public static void CLSID_WSTDecoderTest()
        {
            Assert.That(CLSID_WSTDecoder, Is.EqualTo(new Guid(0x70bc06e0, 0x5666, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MjpegDec" /> property is correct.</summary>
        [Test]
        public static void CLSID_MjpegDecTest()
        {
            Assert.That(CLSID_MjpegDec, Is.EqualTo(new Guid(0x301056d0, 0x6dff, 0x11d2, 0x9e, 0xeb, 0x0, 0x60, 0x8, 0x3, 0x9e, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MJPGEnc" /> property is correct.</summary>
        [Test]
        public static void CLSID_MJPGEncTest()
        {
            Assert.That(CLSID_MJPGEnc, Is.EqualTo(new Guid(0xb80ab0a0, 0x7416, 0x11d2, 0x9e, 0xeb, 0x0, 0x60, 0x8, 0x3, 0x9e, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SystemDeviceEnum" /> property is correct.</summary>
        [Test]
        public static void CLSID_SystemDeviceEnumTest()
        {
            Assert.That(CLSID_SystemDeviceEnum, Is.EqualTo(new Guid(0x62BE5D10, 0x60EB, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CDeviceMoniker" /> property is correct.</summary>
        [Test]
        public static void CLSID_CDeviceMonikerTest()
        {
            Assert.That(CLSID_CDeviceMoniker, Is.EqualTo(new Guid(0x4315D437, 0x5B8C, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoInputDeviceCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoInputDeviceCategoryTest()
        {
            Assert.That(CLSID_VideoInputDeviceCategory, Is.EqualTo(new Guid(0x860BB310, 0x5D01, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CVidCapClassManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_CVidCapClassManagerTest()
        {
            Assert.That(CLSID_CVidCapClassManager, Is.EqualTo(new Guid(0x860BB310, 0x5D01, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_LegacyAmFilterCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_LegacyAmFilterCategoryTest()
        {
            Assert.That(CLSID_LegacyAmFilterCategory, Is.EqualTo(new Guid(0x083863F1, 0x70DE, 0x11d0, 0xBD, 0x40, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CQzFilterClassManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_CQzFilterClassManagerTest()
        {
            Assert.That(CLSID_CQzFilterClassManager, Is.EqualTo(new Guid(0x083863F1, 0x70DE, 0x11d0, 0xBD, 0x40, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoCompressorCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoCompressorCategoryTest()
        {
            Assert.That(CLSID_VideoCompressorCategory, Is.EqualTo(new Guid(0x33d9a760, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CIcmCoClassManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_CIcmCoClassManagerTest()
        {
            Assert.That(CLSID_CIcmCoClassManager, Is.EqualTo(new Guid(0x33d9a760, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioCompressorCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioCompressorCategoryTest()
        {
            Assert.That(CLSID_AudioCompressorCategory, Is.EqualTo(new Guid(0x33d9a761, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CAcmCoClassManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_CAcmCoClassManagerTest()
        {
            Assert.That(CLSID_CAcmCoClassManager, Is.EqualTo(new Guid(0x33d9a761, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioInputDeviceCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioInputDeviceCategoryTest()
        {
            Assert.That(CLSID_AudioInputDeviceCategory, Is.EqualTo(new Guid(0x33d9a762, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CWaveinClassManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_CWaveinClassManagerTest()
        {
            Assert.That(CLSID_CWaveinClassManager, Is.EqualTo(new Guid(0x33d9a762, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioRendererCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioRendererCategoryTest()
        {
            Assert.That(CLSID_AudioRendererCategory, Is.EqualTo(new Guid(0xe0f158e1, 0xcb04, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CWaveOutClassManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_CWaveOutClassManagerTest()
        {
            Assert.That(CLSID_CWaveOutClassManager, Is.EqualTo(new Guid(0xe0f158e1, 0xcb04, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MidiRendererCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_MidiRendererCategoryTest()
        {
            Assert.That(CLSID_MidiRendererCategory, Is.EqualTo(new Guid(0x4EfE2452, 0x168A, 0x11d1, 0xBC, 0x76, 0x0, 0xc0, 0x4F, 0xB9, 0x45, 0x3B)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CMidiOutClassManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_CMidiOutClassManagerTest()
        {
            Assert.That(CLSID_CMidiOutClassManager, Is.EqualTo(new Guid(0x4EfE2452, 0x168A, 0x11d1, 0xBC, 0x76, 0x0, 0xc0, 0x4F, 0xB9, 0x45, 0x3B)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_TransmitCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_TransmitCategoryTest()
        {
            Assert.That(CLSID_TransmitCategory, Is.EqualTo(new Guid(0xcc7bfb41, 0xf175, 0x11d1, 0xa3, 0x92, 0x0, 0xe0, 0x29, 0x1f, 0x39, 0x59)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DeviceControlCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_DeviceControlCategoryTest()
        {
            Assert.That(CLSID_DeviceControlCategory, Is.EqualTo(new Guid(0xcc7bfb46, 0xf175, 0x11d1, 0xa3, 0x92, 0x0, 0xe0, 0x29, 0x1f, 0x39, 0x59)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ActiveMovieCategories" /> property is correct.</summary>
        [Test]
        public static void CLSID_ActiveMovieCategoriesTest()
        {
            Assert.That(CLSID_ActiveMovieCategories, Is.EqualTo(new Guid(0xda4e3da0, 0xd07d, 0x11d0, 0xbd, 0x50, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVDHWDecodersCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVDHWDecodersCategoryTest()
        {
            Assert.That(CLSID_DVDHWDecodersCategory, Is.EqualTo(new Guid(0x2721AE20, 0x7E70, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MediaEncoderCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_MediaEncoderCategoryTest()
        {
            Assert.That(CLSID_MediaEncoderCategory, Is.EqualTo(new Guid(0x7D22E920, 0x5CA9, 0x4787, 0x8C, 0x2B, 0xA6, 0x77, 0x9B, 0xD1, 0x17, 0x81)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MediaMultiplexerCategory" /> property is correct.</summary>
        [Test]
        public static void CLSID_MediaMultiplexerCategoryTest()
        {
            Assert.That(CLSID_MediaMultiplexerCategory, Is.EqualTo(new Guid(0x236C9559, 0xADCE, 0x4736, 0xBF, 0x72, 0xBA, 0xB3, 0x4E, 0x39, 0x21, 0x96)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_FilterMapper2" /> property is correct.</summary>
        [Test]
        public static void CLSID_FilterMapper2Test()
        {
            Assert.That(CLSID_FilterMapper2, Is.EqualTo(new Guid(0xcda42200, 0xbd88, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MemoryAllocator" /> property is correct.</summary>
        [Test]
        public static void CLSID_MemoryAllocatorTest()
        {
            Assert.That(CLSID_MemoryAllocator, Is.EqualTo(new Guid(0x1e651cc0, 0xb199, 0x11d0, 0x82, 0x12, 0x00, 0xc0, 0x4f, 0xc3, 0x2c, 0x45)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MediaPropertyBag" /> property is correct.</summary>
        [Test]
        public static void CLSID_MediaPropertyBagTest()
        {
            Assert.That(CLSID_MediaPropertyBag, Is.EqualTo(new Guid(0xcdbd8d00, 0xc193, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DvdGraphBuilder" /> property is correct.</summary>
        [Test]
        public static void CLSID_DvdGraphBuilderTest()
        {
            Assert.That(CLSID_DvdGraphBuilder, Is.EqualTo(new Guid(0xFCC152B7, 0xF372, 0x11d0, 0x8E, 0x00, 0x00, 0xC0, 0x4F, 0xD7, 0xC0, 0x8B)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVDNavigator" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVDNavigatorTest()
        {
            Assert.That(CLSID_DVDNavigator, Is.EqualTo(new Guid(0x9b8c4620, 0x2c1a, 0x11d0, 0x84, 0x93, 0x0, 0xa0, 0x24, 0x38, 0xad, 0x48)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVDState" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVDStateTest()
        {
            Assert.That(CLSID_DVDState, Is.EqualTo(new Guid(0xf963c5cf, 0xa659, 0x4a93, 0x96, 0x38, 0xca, 0xf3, 0xcd, 0x27, 0x7d, 0x13)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SmartTee" /> property is correct.</summary>
        [Test]
        public static void CLSID_SmartTeeTest()
        {
            Assert.That(CLSID_SmartTee, Is.EqualTo(new Guid(0xcc58e280, 0x8aa1, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DtvCcFilter" /> property is correct.</summary>
        [Test]
        public static void CLSID_DtvCcFilterTest()
        {
            Assert.That(CLSID_DtvCcFilter, Is.EqualTo(new Guid(0xfb056ba0, 0x2502, 0x45b9, 0x8e, 0x86, 0x2b, 0x40, 0xde, 0x84, 0xad, 0x29)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CaptionsFilter" /> property is correct.</summary>
        [Test]
        public static void CLSID_CaptionsFilterTest()
        {
            Assert.That(CLSID_CaptionsFilter, Is.EqualTo(new Guid(0x2F7EE4B6, 0x6FF5, 0x4EB4, 0xB2, 0x4A, 0x2B, 0xFC, 0x41, 0x11, 0x71, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SubtitlesFilter" /> property is correct.</summary>
        [Test]
        public static void CLSID_SubtitlesFilterTest()
        {
            Assert.That(CLSID_SubtitlesFilter, Is.EqualTo(new Guid(0x9f22cfea, 0xce07, 0x41ab, 0x8b, 0xa0, 0xc7, 0x36, 0x4a, 0xf9, 0x0a, 0xf9)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DirectShowPluginControl" /> property is correct.</summary>
        [Test]
        public static void CLSID_DirectShowPluginControlTest()
        {
            Assert.That(CLSID_DirectShowPluginControl, Is.EqualTo(new Guid(0x8670c736, 0xf614, 0x427b, 0x8a, 0xda, 0xbb, 0xad, 0xc5, 0x87, 0x19, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_None" /> property is correct.</summary>
        [Test]
        public static void FORMAT_NoneTest()
        {
            Assert.That(FORMAT_None, Is.EqualTo(new Guid(0x0F6417D6, 0xc318, 0x11d0, 0xa4, 0x3f, 0x00, 0xa0, 0xc9, 0x22, 0x31, 0x96)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_VideoInfo" /> property is correct.</summary>
        [Test]
        public static void FORMAT_VideoInfoTest()
        {
            Assert.That(FORMAT_VideoInfo, Is.EqualTo(new Guid(0x05589f80, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_VideoInfo2" /> property is correct.</summary>
        [Test]
        public static void FORMAT_VideoInfo2Test()
        {
            Assert.That(FORMAT_VideoInfo2, Is.EqualTo(new Guid(0xf72a76A0, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_WaveFormatEx" /> property is correct.</summary>
        [Test]
        public static void FORMAT_WaveFormatExTest()
        {
            Assert.That(FORMAT_WaveFormatEx, Is.EqualTo(new Guid(0x05589f81, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_MPEGVideo" /> property is correct.</summary>
        [Test]
        public static void FORMAT_MPEGVideoTest()
        {
            Assert.That(FORMAT_MPEGVideo, Is.EqualTo(new Guid(0x05589f82, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_MPEGStreams" /> property is correct.</summary>
        [Test]
        public static void FORMAT_MPEGStreamsTest()
        {
            Assert.That(FORMAT_MPEGStreams, Is.EqualTo(new Guid(0x05589f83, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_DvInfo" /> property is correct.</summary>
        [Test]
        public static void FORMAT_DvInfoTest()
        {
            Assert.That(FORMAT_DvInfo, Is.EqualTo(new Guid(0x05589f84, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_525WSS" /> property is correct.</summary>
        [Test]
        public static void FORMAT_525WSSTest()
        {
            Assert.That(FORMAT_525WSS, Is.EqualTo(new Guid(0xc7ecf04d, 0x4582, 0x4869, 0x9a, 0xbb, 0xbf, 0xb5, 0x23, 0xb6, 0x2e, 0xdf)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DirectDrawProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_DirectDrawPropertiesTest()
        {
            Assert.That(CLSID_DirectDrawProperties, Is.EqualTo(new Guid(0x944d4c00, 0xdd52, 0x11ce, 0xbf, 0x0e, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_PerformanceProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_PerformancePropertiesTest()
        {
            Assert.That(CLSID_PerformanceProperties, Is.EqualTo(new Guid(0x59ce6880, 0xacf8, 0x11cf, 0xb5, 0x6e, 0x00, 0x80, 0xc7, 0xc4, 0xb6, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_QualityProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_QualityPropertiesTest()
        {
            Assert.That(CLSID_QualityProperties, Is.EqualTo(new Guid(0x418afb70, 0xf8b8, 0x11ce, 0xaa, 0xc6, 0x00, 0x20, 0xaf, 0x0b, 0x99, 0xa3)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IBaseVideoMixer" /> property is correct.</summary>
        [Test]
        public static void IID_IBaseVideoMixerTest()
        {
            Assert.That(IID_IBaseVideoMixer, Is.EqualTo(new Guid(0x61ded640, 0xe912, 0x11ce, 0xa0, 0x99, 0x00, 0xaa, 0x00, 0x47, 0x9a, 0x58)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawVideo" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawVideoTest()
        {
            Assert.That(IID_IDirectDrawVideo, Is.EqualTo(new Guid(0x36d39eb0, 0xdd75, 0x11ce, 0xbf, 0x0e, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IQualProp" /> property is correct.</summary>
        [Test]
        public static void IID_IQualPropTest()
        {
            Assert.That(IID_IQualProp, Is.EqualTo(new Guid(0x1bd0ecb0, 0xf8e2, 0x11ce, 0xaa, 0xc6, 0x00, 0x20, 0xaf, 0x0b, 0x99, 0xa3)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VPObject" /> property is correct.</summary>
        [Test]
        public static void CLSID_VPObjectTest()
        {
            Assert.That(CLSID_VPObject, Is.EqualTo(new Guid(0xce292861, 0xfc88, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPObject" /> property is correct.</summary>
        [Test]
        public static void IID_IVPObjectTest()
        {
            Assert.That(IID_IVPObject, Is.EqualTo(new Guid(0xce292862, 0xfc88, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPControl" /> property is correct.</summary>
        [Test]
        public static void IID_IVPControlTest()
        {
            Assert.That(IID_IVPControl, Is.EqualTo(new Guid(0x25df12c1, 0x3de0, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VPVBIObject" /> property is correct.</summary>
        [Test]
        public static void CLSID_VPVBIObjectTest()
        {
            Assert.That(CLSID_VPVBIObject, Is.EqualTo(new Guid(0x814b9801, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPVBIObject" /> property is correct.</summary>
        [Test]
        public static void IID_IVPVBIObjectTest()
        {
            Assert.That(IID_IVPVBIObject, Is.EqualTo(new Guid(0x814b9802, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPConfig" /> property is correct.</summary>
        [Test]
        public static void IID_IVPConfigTest()
        {
            Assert.That(IID_IVPConfig, Is.EqualTo(new Guid(0xbc29a660, 0x30e3, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPNotify" /> property is correct.</summary>
        [Test]
        public static void IID_IVPNotifyTest()
        {
            Assert.That(IID_IVPNotify, Is.EqualTo(new Guid(0xc76794a1, 0xd6c5, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPNotify2" /> property is correct.</summary>
        [Test]
        public static void IID_IVPNotify2Test()
        {
            Assert.That(IID_IVPNotify2, Is.EqualTo(new Guid(0xebf47183, 0x8764, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPVBIConfig" /> property is correct.</summary>
        [Test]
        public static void IID_IVPVBIConfigTest()
        {
            Assert.That(IID_IVPVBIConfig, Is.EqualTo(new Guid(0xec529b00, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IVPVBINotify" /> property is correct.</summary>
        [Test]
        public static void IID_IVPVBINotifyTest()
        {
            Assert.That(IID_IVPVBINotify, Is.EqualTo(new Guid(0xec529b01, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IMixerPinConfig" /> property is correct.</summary>
        [Test]
        public static void IID_IMixerPinConfigTest()
        {
            Assert.That(IID_IMixerPinConfig, Is.EqualTo(new Guid(0x593cdde1, 0x759, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IMixerPinConfig2" /> property is correct.</summary>
        [Test]
        public static void IID_IMixerPinConfig2Test()
        {
            Assert.That(IID_IMixerPinConfig2, Is.EqualTo(new Guid(0xebf47182, 0x8764, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDDVideoPortContainer" /> property is correct.</summary>
        [Test]
        public static void IID_IDDVideoPortContainerTest()
        {
            Assert.That(IID_IDDVideoPortContainer, Is.EqualTo(new Guid(0x6C142760, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawKernel" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawKernelTest()
        {
            Assert.That(IID_IDirectDrawKernel, Is.EqualTo(new Guid(0x8D56C120, 0x6A08, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawSurfaceKernel" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawSurfaceKernelTest()
        {
            Assert.That(IID_IDirectDrawSurfaceKernel, Is.EqualTo(new Guid(0x60755DA0, 0x6A40, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ModexProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_ModexPropertiesTest()
        {
            Assert.That(CLSID_ModexProperties, Is.EqualTo(new Guid(0x0618aa30, 0x6bc4, 0x11cf, 0xbf, 0x36, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IFullScreenVideo" /> property is correct.</summary>
        [Test]
        public static void IID_IFullScreenVideoTest()
        {
            Assert.That(IID_IFullScreenVideo, Is.EqualTo(new Guid(0xdd1d7110, 0x7836, 0x11cf, 0xbf, 0x47, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IFullScreenVideoEx" /> property is correct.</summary>
        [Test]
        public static void IID_IFullScreenVideoExTest()
        {
            Assert.That(IID_IFullScreenVideoEx, Is.EqualTo(new Guid(0x53479470, 0xf1dd, 0x11cf, 0xbc, 0x42, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVDecPropertiesPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVDecPropertiesPageTest()
        {
            Assert.That(CLSID_DVDecPropertiesPage, Is.EqualTo(new Guid(0x101193c0, 0xbfe, 0x11d0, 0xaf, 0x91, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVEncPropertiesPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVEncPropertiesPageTest()
        {
            Assert.That(CLSID_DVEncPropertiesPage, Is.EqualTo(new Guid(0x4150f050, 0xbb6f, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVMuxPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVMuxPropertyPageTest()
        {
            Assert.That(CLSID_DVMuxPropertyPage, Is.EqualTo(new Guid(0x4db880e0, 0xc10d, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IAMDirectSound" /> property is correct.</summary>
        [Test]
        public static void IID_IAMDirectSoundTest()
        {
            Assert.That(IID_IAMDirectSound, Is.EqualTo(new Guid(0x546f4260, 0xd53e, 0x11cf, 0xb3, 0xf0, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IMpegAudioDecoder" /> property is correct.</summary>
        [Test]
        public static void IID_IMpegAudioDecoderTest()
        {
            Assert.That(IID_IMpegAudioDecoder, Is.EqualTo(new Guid(0xb45dd570, 0x3c77, 0x11d1, 0xab, 0xe1, 0x00, 0xa0, 0xc9, 0x05, 0xf3, 0x75)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IAMLine21Decoder" /> property is correct.</summary>
        [Test]
        public static void IID_IAMLine21DecoderTest()
        {
            Assert.That(IID_IAMLine21Decoder, Is.EqualTo(new Guid(0x6e8d4a21, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IAMWstDecoder" /> property is correct.</summary>
        [Test]
        public static void IID_IAMWstDecoderTest()
        {
            Assert.That(IID_IAMWstDecoder, Is.EqualTo(new Guid(0xc056de21, 0x75c2, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_WstDecoderPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_WstDecoderPropertyPageTest()
        {
            Assert.That(CLSID_WstDecoderPropertyPage, Is.EqualTo(new Guid(0x4e27f80, 0x91e4, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_AnalogVideo" /> property is correct.</summary>
        [Test]
        public static void FORMAT_AnalogVideoTest()
        {
            Assert.That(FORMAT_AnalogVideo, Is.EqualTo(new Guid(0x482dde0, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_AnalogVideo" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_AnalogVideoTest()
        {
            Assert.That(MEDIATYPE_AnalogVideo, Is.EqualTo(new Guid(0x482dde1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_NTSC_M" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_NTSC_MTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_NTSC_M, Is.EqualTo(new Guid(0x482dde2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_B" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_BTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_B, Is.EqualTo(new Guid(0x482dde5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_D" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_DTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_D, Is.EqualTo(new Guid(0x482dde6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_G" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_GTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_G, Is.EqualTo(new Guid(0x482dde7, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_H" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_HTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_H, Is.EqualTo(new Guid(0x482dde8, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_I" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_ITest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_I, Is.EqualTo(new Guid(0x482dde9, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_M" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_MTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_M, Is.EqualTo(new Guid(0x482ddea, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_N" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_NTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_N, Is.EqualTo(new Guid(0x482ddeb, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_PAL_N_COMBO" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_PAL_N_COMBOTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_PAL_N_COMBO, Is.EqualTo(new Guid(0x482ddec, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_SECAM_B" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_SECAM_BTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_SECAM_B, Is.EqualTo(new Guid(0x482ddf0, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_SECAM_D" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_SECAM_DTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_SECAM_D, Is.EqualTo(new Guid(0x482ddf1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_SECAM_G" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_SECAM_GTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_SECAM_G, Is.EqualTo(new Guid(0x482ddf2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_SECAM_H" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_SECAM_HTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_SECAM_H, Is.EqualTo(new Guid(0x482ddf3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_SECAM_K" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_SECAM_KTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_SECAM_K, Is.EqualTo(new Guid(0x482ddf4, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_SECAM_K1" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_SECAM_K1Test()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_SECAM_K1, Is.EqualTo(new Guid(0x482ddf5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIASUBTYPE_AnalogVideo_SECAM_L" /> property is correct.</summary>
        [Test]
        public static void MEDIASUBTYPE_AnalogVideo_SECAM_LTest()
        {
            Assert.That(MEDIASUBTYPE_AnalogVideo_SECAM_L, Is.EqualTo(new Guid(0x482ddf6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="MEDIATYPE_AnalogAudio" /> property is correct.</summary>
        [Test]
        public static void MEDIATYPE_AnalogAudioTest()
        {
            Assert.That(MEDIATYPE_AnalogAudio, Is.EqualTo(new Guid(0x482dee1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_CAPTIONED_H264VIDEO" /> property is correct.</summary>
        [Test]
        public static void FORMAT_CAPTIONED_H264VIDEOTest()
        {
            Assert.That(FORMAT_CAPTIONED_H264VIDEO, Is.EqualTo(new Guid(0xa4efc024, 0x873e, 0x4da3, 0x89, 0x8b, 0x47, 0x4d, 0xdb, 0xd7, 0x9f, 0xd0)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_CC_CONTAINER" /> property is correct.</summary>
        [Test]
        public static void FORMAT_CC_CONTAINERTest()
        {
            Assert.That(FORMAT_CC_CONTAINER, Is.EqualTo(new Guid(0x50997a4a, 0xe508, 0x4054, 0xa2, 0xb2, 0x10, 0xff, 0xa, 0xc1, 0xa6, 0x9a)));
        }

        /// <summary>Validates that the value of the <see cref="CAPTION_FORMAT_ATSC" /> property is correct.</summary>
        [Test]
        public static void CAPTION_FORMAT_ATSCTest()
        {
            Assert.That(CAPTION_FORMAT_ATSC, Is.EqualTo(new Guid(0x3ed9cb31, 0xfd10, 0x4ade, 0xbc, 0xcc, 0xfb, 0x91, 0x5, 0xd2, 0xf3, 0xef)));
        }

        /// <summary>Validates that the value of the <see cref="CAPTION_FORMAT_DVB" /> property is correct.</summary>
        [Test]
        public static void CAPTION_FORMAT_DVBTest()
        {
            Assert.That(CAPTION_FORMAT_DVB, Is.EqualTo(new Guid(0x12230db4, 0xff2a, 0x447e, 0xbb, 0x88, 0x68, 0x41, 0xc4, 0x16, 0xd0, 0x68)));
        }

        /// <summary>Validates that the value of the <see cref="CAPTION_FORMAT_DIRECTV" /> property is correct.</summary>
        [Test]
        public static void CAPTION_FORMAT_DIRECTVTest()
        {
            Assert.That(CAPTION_FORMAT_DIRECTV, Is.EqualTo(new Guid(0xe9ca1ce7, 0x915e, 0x47be, 0x9b, 0xb9, 0xbf, 0x1d, 0x8a, 0x13, 0xa5, 0xec)));
        }

        /// <summary>Validates that the value of the <see cref="CAPTION_FORMAT_ECHOSTAR" /> property is correct.</summary>
        [Test]
        public static void CAPTION_FORMAT_ECHOSTARTest()
        {
            Assert.That(CAPTION_FORMAT_ECHOSTAR, Is.EqualTo(new Guid(0xebb1a262, 0x1158, 0x4b99, 0xae, 0x80, 0x92, 0xac, 0x77, 0x69, 0x52, 0xc4)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_CAPTIONED_MPEG2VIDEO" /> property is correct.</summary>
        [Test]
        public static void FORMAT_CAPTIONED_MPEG2VIDEOTest()
        {
            Assert.That(FORMAT_CAPTIONED_MPEG2VIDEO, Is.EqualTo(new Guid(0x7ab2ada2, 0x81b6, 0x4f14, 0xb3, 0xc8, 0xd0, 0xc4, 0x86, 0x39, 0x3b, 0x67)));
        }

        /// <summary>Validates that the value of the <see cref="TIME_FORMAT_NONE" /> property is correct.</summary>
        [Test]
        public static void TIME_FORMAT_NONETest()
        {
            Assert.That(TIME_FORMAT_NONE, Is.EqualTo(new Guid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)));
        }

        /// <summary>Validates that the value of the <see cref="TIME_FORMAT_FRAME" /> property is correct.</summary>
        [Test]
        public static void TIME_FORMAT_FRAMETest()
        {
            Assert.That(TIME_FORMAT_FRAME, Is.EqualTo(new Guid(0x7b785570, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="TIME_FORMAT_BYTE" /> property is correct.</summary>
        [Test]
        public static void TIME_FORMAT_BYTETest()
        {
            Assert.That(TIME_FORMAT_BYTE, Is.EqualTo(new Guid(0x7b785571, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="TIME_FORMAT_SAMPLE" /> property is correct.</summary>
        [Test]
        public static void TIME_FORMAT_SAMPLETest()
        {
            Assert.That(TIME_FORMAT_SAMPLE, Is.EqualTo(new Guid(0x7b785572, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="TIME_FORMAT_FIELD" /> property is correct.</summary>
        [Test]
        public static void TIME_FORMAT_FIELDTest()
        {
            Assert.That(TIME_FORMAT_FIELD, Is.EqualTo(new Guid(0x7b785573, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="TIME_FORMAT_MEDIA_TIME" /> property is correct.</summary>
        [Test]
        public static void TIME_FORMAT_MEDIA_TIMETest()
        {
            Assert.That(TIME_FORMAT_MEDIA_TIME, Is.EqualTo(new Guid(0x7b785574, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="AMPROPSETID_Pin" /> property is correct.</summary>
        [Test]
        public static void AMPROPSETID_PinTest()
        {
            Assert.That(AMPROPSETID_Pin, Is.EqualTo(new Guid(0x9b00f101, 0x1567, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_CAPTURE" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_CAPTURETest()
        {
            Assert.That(PIN_CATEGORY_CAPTURE, Is.EqualTo(new Guid(0xfb6c4281, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_PREVIEW" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_PREVIEWTest()
        {
            Assert.That(PIN_CATEGORY_PREVIEW, Is.EqualTo(new Guid(0xfb6c4282, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_ANALOGVIDEOIN" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_ANALOGVIDEOINTest()
        {
            Assert.That(PIN_CATEGORY_ANALOGVIDEOIN, Is.EqualTo(new Guid(0xfb6c4283, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_VBI" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_VBITest()
        {
            Assert.That(PIN_CATEGORY_VBI, Is.EqualTo(new Guid(0xfb6c4284, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_VIDEOPORT" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_VIDEOPORTTest()
        {
            Assert.That(PIN_CATEGORY_VIDEOPORT, Is.EqualTo(new Guid(0xfb6c4285, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_NABTS" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_NABTSTest()
        {
            Assert.That(PIN_CATEGORY_NABTS, Is.EqualTo(new Guid(0xfb6c4286, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_EDS" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_EDSTest()
        {
            Assert.That(PIN_CATEGORY_EDS, Is.EqualTo(new Guid(0xfb6c4287, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_TELETEXT" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_TELETEXTTest()
        {
            Assert.That(PIN_CATEGORY_TELETEXT, Is.EqualTo(new Guid(0xfb6c4288, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_CC" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_CCTest()
        {
            Assert.That(PIN_CATEGORY_CC, Is.EqualTo(new Guid(0xfb6c4289, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_STILL" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_STILLTest()
        {
            Assert.That(PIN_CATEGORY_STILL, Is.EqualTo(new Guid(0xfb6c428a, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_TIMECODE" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_TIMECODETest()
        {
            Assert.That(PIN_CATEGORY_TIMECODE, Is.EqualTo(new Guid(0xfb6c428b, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="PIN_CATEGORY_VIDEOPORT_VBI" /> property is correct.</summary>
        [Test]
        public static void PIN_CATEGORY_VIDEOPORT_VBITest()
        {
            Assert.That(PIN_CATEGORY_VIDEOPORT_VBI, Is.EqualTo(new Guid(0xfb6c428c, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="LOOK_UPSTREAM_ONLY" /> property is correct.</summary>
        [Test]
        public static void LOOK_UPSTREAM_ONLYTest()
        {
            Assert.That(LOOK_UPSTREAM_ONLY, Is.EqualTo(new Guid(0xac798be0, 0x98e3, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="LOOK_DOWNSTREAM_ONLY" /> property is correct.</summary>
        [Test]
        public static void LOOK_DOWNSTREAM_ONLYTest()
        {
            Assert.That(LOOK_DOWNSTREAM_ONLY, Is.EqualTo(new Guid(0xac798be1, 0x98e3, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_TVTunerFilterPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_TVTunerFilterPropertyPageTest()
        {
            Assert.That(CLSID_TVTunerFilterPropertyPage, Is.EqualTo(new Guid(0x266eee41, 0x6c63, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CrossbarFilterPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_CrossbarFilterPropertyPageTest()
        {
            Assert.That(CLSID_CrossbarFilterPropertyPage, Is.EqualTo(new Guid(0x71f96461, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_TVAudioFilterPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_TVAudioFilterPropertyPageTest()
        {
            Assert.That(CLSID_TVAudioFilterPropertyPage, Is.EqualTo(new Guid(0x71f96463, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoProcAmpPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoProcAmpPropertyPageTest()
        {
            Assert.That(CLSID_VideoProcAmpPropertyPage, Is.EqualTo(new Guid(0x71f96464, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_CameraControlPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_CameraControlPropertyPageTest()
        {
            Assert.That(CLSID_CameraControlPropertyPage, Is.EqualTo(new Guid(0x71f96465, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AnalogVideoDecoderPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_AnalogVideoDecoderPropertyPageTest()
        {
            Assert.That(CLSID_AnalogVideoDecoderPropertyPage, Is.EqualTo(new Guid(0x71f96466, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoStreamConfigPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoStreamConfigPropertyPageTest()
        {
            Assert.That(CLSID_VideoStreamConfigPropertyPage, Is.EqualTo(new Guid(0x71f96467, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AudioRendererAdvancedProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_AudioRendererAdvancedPropertiesTest()
        {
            Assert.That(CLSID_AudioRendererAdvancedProperties, Is.EqualTo(new Guid(0x37e92a92, 0xd9aa, 0x11d2, 0xbf, 0x84, 0x8e, 0xf2, 0xb1, 0x55, 0x5a, 0xed)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoMixingRenderer" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoMixingRendererTest()
        {
            Assert.That(CLSID_VideoMixingRenderer, Is.EqualTo(new Guid(0xB87BEB7B, 0x8D29, 0x423f, 0xAE, 0x4D, 0x65, 0x82, 0xC1, 0x01, 0x75, 0xAC)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoRendererDefault" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoRendererDefaultTest()
        {
            Assert.That(CLSID_VideoRendererDefault, Is.EqualTo(new Guid(0x6BC1CFFA, 0x8FC1, 0x4261, 0xAC, 0x22, 0xCF, 0xB4, 0xCC, 0x38, 0xDB, 0x50)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AllocPresenter" /> property is correct.</summary>
        [Test]
        public static void CLSID_AllocPresenterTest()
        {
            Assert.That(CLSID_AllocPresenter, Is.EqualTo(new Guid(0x99d54f63, 0x1a69, 0x41ae, 0xaa, 0x4d, 0xc9, 0x76, 0xeb, 0x3f, 0x07, 0x13)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_AllocPresenterDDXclMode" /> property is correct.</summary>
        [Test]
        public static void CLSID_AllocPresenterDDXclModeTest()
        {
            Assert.That(CLSID_AllocPresenterDDXclMode, Is.EqualTo(new Guid(0x4444ac9e, 0x242e, 0x471b, 0xa3, 0xc7, 0x45, 0xdc, 0xd4, 0x63, 0x52, 0xbc)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoPortManager" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoPortManagerTest()
        {
            Assert.That(CLSID_VideoPortManager, Is.EqualTo(new Guid(0x6f26a6cd, 0x967b, 0x47fd, 0x87, 0x4a, 0x7a, 0xed, 0x2c, 0x9d, 0x25, 0xa2)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_VideoMixingRenderer9" /> property is correct.</summary>
        [Test]
        public static void CLSID_VideoMixingRenderer9Test()
        {
            Assert.That(CLSID_VideoMixingRenderer9, Is.EqualTo(new Guid(0x51b4abf3, 0x748f, 0x4e3b, 0xa2, 0x76, 0xc8, 0x28, 0x33, 0x0e, 0x92, 0x6a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_EnhancedVideoRenderer" /> property is correct.</summary>
        [Test]
        public static void CLSID_EnhancedVideoRendererTest()
        {
            Assert.That(CLSID_EnhancedVideoRenderer, Is.EqualTo(new Guid(0xfa10746c, 0x9b63, 0x4b6c, 0xbc, 0x49, 0xfc, 0x30, 0xe, 0xa5, 0xf2, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MFVideoMixer9" /> property is correct.</summary>
        [Test]
        public static void CLSID_MFVideoMixer9Test()
        {
            Assert.That(CLSID_MFVideoMixer9, Is.EqualTo(new Guid(0xE474E05A, 0xAB65, 0x4f6a, 0x82, 0x7C, 0x21, 0x8B, 0x1B, 0xAA, 0xF3, 0x1F)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MFVideoPresenter9" /> property is correct.</summary>
        [Test]
        public static void CLSID_MFVideoPresenter9Test()
        {
            Assert.That(CLSID_MFVideoPresenter9, Is.EqualTo(new Guid(0x98455561, 0x5136, 0x4d28, 0xab, 0x8, 0x4c, 0xee, 0x40, 0xea, 0x27, 0x81)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_EVRTearlessWindowPresenter9" /> property is correct.</summary>
        [Test]
        public static void CLSID_EVRTearlessWindowPresenter9Test()
        {
            Assert.That(CLSID_EVRTearlessWindowPresenter9, Is.EqualTo(new Guid(0xa0a7a57b, 0x59b2, 0x4919, 0xa6, 0x94, 0xad, 0xd0, 0xa5, 0x26, 0xc3, 0x73)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_EVRPlaybackPipelineOptimizer" /> property is correct.</summary>
        [Test]
        public static void CLSID_EVRPlaybackPipelineOptimizerTest()
        {
            Assert.That(CLSID_EVRPlaybackPipelineOptimizer, Is.EqualTo(new Guid(0x62079164, 0x233b, 0x41f8, 0xa8, 0x0f, 0xf0, 0x17, 0x05, 0xf5, 0x14, 0xa8)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_ForceBob" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_ForceBobTest()
        {
            Assert.That(EVRConfig_ForceBob, Is.EqualTo(new Guid(0xe447df01, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_AllowDropToBob" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_AllowDropToBobTest()
        {
            Assert.That(EVRConfig_AllowDropToBob, Is.EqualTo(new Guid(0xe447df02, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_ForceThrottle" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_ForceThrottleTest()
        {
            Assert.That(EVRConfig_ForceThrottle, Is.EqualTo(new Guid(0xe447df03, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_AllowDropToThrottle" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_AllowDropToThrottleTest()
        {
            Assert.That(EVRConfig_AllowDropToThrottle, Is.EqualTo(new Guid(0xe447df04, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_ForceHalfInterlace" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_ForceHalfInterlaceTest()
        {
            Assert.That(EVRConfig_ForceHalfInterlace, Is.EqualTo(new Guid(0xe447df05, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_AllowDropToHalfInterlace" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_AllowDropToHalfInterlaceTest()
        {
            Assert.That(EVRConfig_AllowDropToHalfInterlace, Is.EqualTo(new Guid(0xe447df06, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_ForceScaling" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_ForceScalingTest()
        {
            Assert.That(EVRConfig_ForceScaling, Is.EqualTo(new Guid(0xe447df07, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_AllowScaling" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_AllowScalingTest()
        {
            Assert.That(EVRConfig_AllowScaling, Is.EqualTo(new Guid(0xe447df08, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_ForceBatching" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_ForceBatchingTest()
        {
            Assert.That(EVRConfig_ForceBatching, Is.EqualTo(new Guid(0xe447df09, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EVRConfig_AllowBatching" /> property is correct.</summary>
        [Test]
        public static void EVRConfig_AllowBatchingTest()
        {
            Assert.That(EVRConfig_AllowBatching, Is.EqualTo(new Guid(0xe447df0a, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_NetworkProvider" /> property is correct.</summary>
        [Test]
        public static void CLSID_NetworkProviderTest()
        {
            Assert.That(CLSID_NetworkProvider, Is.EqualTo(new Guid(0xb2f3a67c, 0x29da, 0x4c78, 0x88, 0x31, 0x9, 0x1e, 0xd5, 0x9, 0xa4, 0x75)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ATSCNetworkProvider" /> property is correct.</summary>
        [Test]
        public static void CLSID_ATSCNetworkProviderTest()
        {
            Assert.That(CLSID_ATSCNetworkProvider, Is.EqualTo(new Guid(0x0dad2fdd, 0x5fd7, 0x11d3, 0x8f, 0x50, 0x00, 0xc0, 0x4f, 0x79, 0x71, 0xe2)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ATSCNetworkPropertyPage" /> property is correct.</summary>
        [Test]
        public static void CLSID_ATSCNetworkPropertyPageTest()
        {
            Assert.That(CLSID_ATSCNetworkPropertyPage, Is.EqualTo(new Guid(0xe3444d16, 0x5ac4, 0x4386, 0x88, 0xdf, 0x13, 0xfd, 0x23, 0x0e, 0x1d, 0xda)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVBSNetworkProvider" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVBSNetworkProviderTest()
        {
            Assert.That(CLSID_DVBSNetworkProvider, Is.EqualTo(new Guid(0xfa4b375a, 0x45b4, 0x4d45, 0x84, 0x40, 0x26, 0x39, 0x57, 0xb1, 0x16, 0x23)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVBTNetworkProvider" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVBTNetworkProviderTest()
        {
            Assert.That(CLSID_DVBTNetworkProvider, Is.EqualTo(new Guid(0x216c62df, 0x6d7f, 0x4e9a, 0x85, 0x71, 0x5, 0xf1, 0x4e, 0xdb, 0x76, 0x6a)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DVBCNetworkProvider" /> property is correct.</summary>
        [Test]
        public static void CLSID_DVBCNetworkProviderTest()
        {
            Assert.That(CLSID_DVBCNetworkProvider, Is.EqualTo(new Guid(0xdc0c0fe7, 0x485, 0x4266, 0xb9, 0x3f, 0x68, 0xfb, 0xf8, 0xe, 0xd8, 0x34)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_UDCRTag" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_UDCRTagTest()
        {
            Assert.That(DSATTRIB_UDCRTag, Is.EqualTo(new Guid(0xEB7836CA, 0x14FF, 0x4919, 0xbc, 0xe7, 0x3a, 0xf1, 0x23, 0x19, 0xe5, 0x0c)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_PicSampleSeq" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_PicSampleSeqTest()
        {
            Assert.That(DSATTRIB_PicSampleSeq, Is.EqualTo(new Guid(0x2f5bae02, 0x7b8f, 0x4f60, 0x82, 0xd6, 0xe4, 0xea, 0x2f, 0x1f, 0x4c, 0x99)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_OptionalVideoAttributes" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_OptionalVideoAttributesTest()
        {
            Assert.That(DSATTRIB_OptionalVideoAttributes, Is.EqualTo(new Guid(0x5A5F08CA, 0x55C2, 0x4033, 0x92, 0xAB, 0x55, 0xDB, 0x8F, 0x78, 0x12, 0x26)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_CC_CONTAINER_INFO" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_CC_CONTAINER_INFOTest()
        {
            Assert.That(DSATTRIB_CC_CONTAINER_INFO, Is.EqualTo(new Guid(0xe7e050fb, 0xdd5d, 0x40dd, 0x99, 0x15, 0x35, 0xDC, 0xB8, 0x1B, 0xDC, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_TRANSPORT_PROPERTIES" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_TRANSPORT_PROPERTIESTest()
        {
            Assert.That(DSATTRIB_TRANSPORT_PROPERTIES, Is.EqualTo(new Guid(0xb622f612, 0x47ad, 0x4671, 0xad, 0x6c, 0x5, 0xa9, 0x8e, 0x65, 0xde, 0x3a)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_PBDATAG_ATTRIBUTE" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_PBDATAG_ATTRIBUTETest()
        {
            Assert.That(DSATTRIB_PBDATAG_ATTRIBUTE, Is.EqualTo(new Guid(0xe0b56679, 0x12b9, 0x43cc, 0xb7, 0xdf, 0x57, 0x8c, 0xaa, 0x5a, 0x7b, 0x63)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_CAPTURE_STREAMTIME" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_CAPTURE_STREAMTIMETest()
        {
            Assert.That(DSATTRIB_CAPTURE_STREAMTIME, Is.EqualTo(new Guid(0x0c1a5614, 0x30cd, 0x4f40, 0xbc, 0xbf, 0xd0, 0x3e, 0x52, 0x30, 0x62, 0x07)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_DSHOW_STREAM_DESC" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_DSHOW_STREAM_DESCTest()
        {
            Assert.That(DSATTRIB_DSHOW_STREAM_DESC, Is.EqualTo(new Guid(0x5fb5673b, 0xa2a, 0x4565, 0x82, 0x7b, 0x68, 0x53, 0xfd, 0x75, 0xe6, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="DSATTRIB_SAMPLE_LIVE_STREAM_TIME" /> property is correct.</summary>
        [Test]
        public static void DSATTRIB_SAMPLE_LIVE_STREAM_TIMETest()
        {
            Assert.That(DSATTRIB_SAMPLE_LIVE_STREAM_TIME, Is.EqualTo(new Guid(0x892cd111, 0x72f3, 0x411d, 0x8b, 0x91, 0xa9, 0xe9, 0x12, 0x3a, 0xc2, 0x9a)));
        }

        /// <summary>Validates that the value of the <see cref="UUID_UdriTagTables" /> property is correct.</summary>
        [Test]
        public static void UUID_UdriTagTablesTest()
        {
            Assert.That(UUID_UdriTagTables, Is.EqualTo(new Guid(0xe1b98d74, 0x9778, 0x4878, 0xb6, 0x64, 0xeb, 0x20, 0x20, 0x36, 0x4d, 0x88)));
        }

        /// <summary>Validates that the value of the <see cref="UUID_WMDRMTagTables" /> property is correct.</summary>
        [Test]
        public static void UUID_WMDRMTagTablesTest()
        {
            Assert.That(UUID_WMDRMTagTables, Is.EqualTo(new Guid(0x5DCD1101, 0x9263, 0x45bb, 0xa4, 0xd5, 0xc4, 0x15, 0xab, 0x8c, 0x58, 0x9c)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DShowTVEFilter" /> property is correct.</summary>
        [Test]
        public static void CLSID_DShowTVEFilterTest()
        {
            Assert.That(CLSID_DShowTVEFilter, Is.EqualTo(new Guid(0x05500280, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_TVEFilterTuneProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_TVEFilterTunePropertiesTest()
        {
            Assert.That(CLSID_TVEFilterTuneProperties, Is.EqualTo(new Guid(0x05500281, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_TVEFilterCCProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_TVEFilterCCPropertiesTest()
        {
            Assert.That(CLSID_TVEFilterCCProperties, Is.EqualTo(new Guid(0x05500282, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_TVEFilterStatsProperties" /> property is correct.</summary>
        [Test]
        public static void CLSID_TVEFilterStatsPropertiesTest()
        {
            Assert.That(CLSID_TVEFilterStatsProperties, Is.EqualTo(new Guid(0x05500283, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_IVideoEncoderProxy" /> property is correct.</summary>
        [Test]
        public static void CLSID_IVideoEncoderProxyTest()
        {
            Assert.That(CLSID_IVideoEncoderProxy, Is.EqualTo(new Guid(0xb43c4eec, 0x8c32, 0x4791, 0x91, 0x2, 0x50, 0x8a, 0xda, 0x5e, 0xe8, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_ICodecAPIProxy" /> property is correct.</summary>
        [Test]
        public static void CLSID_ICodecAPIProxyTest()
        {
            Assert.That(CLSID_ICodecAPIProxy, Is.EqualTo(new Guid(0x7ff0997a, 0x1999, 0x4286, 0xa7, 0x3c, 0x62, 0x2b, 0x88, 0x14, 0xe7, 0xeb)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_IVideoEncoderCodecAPIProxy" /> property is correct.</summary>
        [Test]
        public static void CLSID_IVideoEncoderCodecAPIProxyTest()
        {
            Assert.That(CLSID_IVideoEncoderCodecAPIProxy, Is.EqualTo(new Guid(0xb05dabd9, 0x56e5, 0x4fdc, 0xaf, 0xa4, 0x8a, 0x47, 0xe9, 0x1f, 0x1c, 0x9c)));
        }

        /// <summary>Validates that the value of the <see cref="ENCAPIPARAM_BITRATE" /> property is correct.</summary>
        [Test]
        public static void ENCAPIPARAM_BITRATETest()
        {
            Assert.That(ENCAPIPARAM_BITRATE, Is.EqualTo(new Guid(0x49cc4c43, 0xca83, 0x4ad4, 0xa9, 0xaf, 0xf3, 0x69, 0x6a, 0xf6, 0x66, 0xdf)));
        }

        /// <summary>Validates that the value of the <see cref="ENCAPIPARAM_PEAK_BITRATE" /> property is correct.</summary>
        [Test]
        public static void ENCAPIPARAM_PEAK_BITRATETest()
        {
            Assert.That(ENCAPIPARAM_PEAK_BITRATE, Is.EqualTo(new Guid(0x703f16a9, 0x3d48, 0x44a1, 0xb0, 0x77, 0x1, 0x8d, 0xff, 0x91, 0x5d, 0x19)));
        }

        /// <summary>Validates that the value of the <see cref="ENCAPIPARAM_BITRATE_MODE" /> property is correct.</summary>
        [Test]
        public static void ENCAPIPARAM_BITRATE_MODETest()
        {
            Assert.That(ENCAPIPARAM_BITRATE_MODE, Is.EqualTo(new Guid(0xee5fb25c, 0xc713, 0x40d1, 0x9d, 0x58, 0xc0, 0xd7, 0x24, 0x1e, 0x25, 0xf)));
        }

        /// <summary>Validates that the value of the <see cref="ENCAPIPARAM_SAP_MODE" /> property is correct.</summary>
        [Test]
        public static void ENCAPIPARAM_SAP_MODETest()
        {
            Assert.That(ENCAPIPARAM_SAP_MODE, Is.EqualTo(new Guid(0xc0171db, 0xfefc, 0x4af7, 0x99, 0x91, 0xa5, 0x65, 0x7c, 0x19, 0x1c, 0xd1)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_CHANGELISTS" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_CHANGELISTSTest()
        {
            Assert.That(CODECAPI_CHANGELISTS, Is.EqualTo(new Guid(0x62b12acf, 0xf6b0, 0x47d9, 0x94, 0x56, 0x96, 0xf2, 0x2c, 0x4e, 0x0b, 0x9d)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_VIDEO_ENCODER" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_VIDEO_ENCODERTest()
        {
            Assert.That(CODECAPI_VIDEO_ENCODER, Is.EqualTo(new Guid(0x7112e8e1, 0x3d03, 0x47ef, 0x8e, 0x60, 0x03, 0xf1, 0xcf, 0x53, 0x73, 0x01)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_AUDIO_ENCODER" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_AUDIO_ENCODERTest()
        {
            Assert.That(CODECAPI_AUDIO_ENCODER, Is.EqualTo(new Guid(0xb9d19a3e, 0xf897, 0x429c, 0xbc, 0x46, 0x81, 0x38, 0xb7, 0x27, 0x2b, 0x2d)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_SETALLDEFAULTS" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_SETALLDEFAULTSTest()
        {
            Assert.That(CODECAPI_SETALLDEFAULTS, Is.EqualTo(new Guid(0x6c5e6a7c, 0xacf8, 0x4f55, 0xa9, 0x99, 0x1a, 0x62, 0x81, 0x09, 0x05, 0x1b)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_ALLSETTINGS" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_ALLSETTINGSTest()
        {
            Assert.That(CODECAPI_ALLSETTINGS, Is.EqualTo(new Guid(0x6a577e92, 0x83e1, 0x4113, 0xad, 0xc2, 0x4f, 0xce, 0xc3, 0x2f, 0x83, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_SUPPORTSEVENTS" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_SUPPORTSEVENTSTest()
        {
            Assert.That(CODECAPI_SUPPORTSEVENTS, Is.EqualTo(new Guid(0x0581af97, 0x7693, 0x4dbd, 0x9d, 0xca, 0x3f, 0x9e, 0xbd, 0x65, 0x85, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_CURRENTCHANGELIST" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_CURRENTCHANGELISTTest()
        {
            Assert.That(CODECAPI_CURRENTCHANGELIST, Is.EqualTo(new Guid(0x1cb14e83, 0x7d72, 0x4657, 0x83, 0xfd, 0x47, 0xa2, 0xc5, 0xb9, 0xd1, 0x3d)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SBE2MediaTypeProfile" /> property is correct.</summary>
        [Test]
        public static void CLSID_SBE2MediaTypeProfileTest()
        {
            Assert.That(CLSID_SBE2MediaTypeProfile, Is.EqualTo(new Guid(0x1f26a602, 0x2b5c, 0x4b63, 0xb8, 0xe8, 0x9e, 0xa5, 0xc1, 0xa7, 0xdc, 0x2e)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_SBE2FileScan" /> property is correct.</summary>
        [Test]
        public static void CLSID_SBE2FileScanTest()
        {
            Assert.That(CLSID_SBE2FileScan, Is.EqualTo(new Guid(0x3e458037, 0xca6, 0x41aa, 0xa5, 0x94, 0x2a, 0xa6, 0xc0, 0x2d, 0x70, 0x9b)));
        }

        /// <summary>Validates that the value of the <see cref="CODECAPI_AVDecMmcssClass" /> property is correct.</summary>
        [Test]
        public static void CODECAPI_AVDecMmcssClassTest()
        {
            Assert.That(CODECAPI_AVDecMmcssClass, Is.EqualTo(new Guid(0xe0ad4828, 0xdf66, 0x4893, 0x9f, 0x33, 0x78, 0x8a, 0xa4, 0xec, 0x40, 0x82)));
        }
    }
}
