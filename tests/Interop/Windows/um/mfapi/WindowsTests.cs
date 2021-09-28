// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static unsafe partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="MF_EVENT_SESSIONCAPS" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SESSIONCAPSTest()
        {
            Assert.That(MF_EVENT_SESSIONCAPS, Is.EqualTo(new Guid(0x7e5ebcd0, 0x11b8, 0x4abe, 0xaf, 0xad, 0x10, 0xf6, 0x59, 0x9a, 0x7f, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SESSIONCAPS_DELTA" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SESSIONCAPS_DELTATest()
        {
            Assert.That(MF_EVENT_SESSIONCAPS_DELTA, Is.EqualTo(new Guid(0x7e5ebcd1, 0x11b8, 0x4abe, 0xaf, 0xad, 0x10, 0xf6, 0x59, 0x9a, 0x7f, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_TOPOLOGY_STATUS" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_TOPOLOGY_STATUSTest()
        {
            Assert.That(MF_EVENT_TOPOLOGY_STATUS, Is.EqualTo(new Guid(0x30c5018d, 0x9a53, 0x454b, 0xad, 0x9e, 0x6d, 0x5f, 0x8f, 0xa7, 0xc4, 0x3b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_START_PRESENTATION_TIME" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_START_PRESENTATION_TIMETest()
        {
            Assert.That(MF_EVENT_START_PRESENTATION_TIME, Is.EqualTo(new Guid(0x5ad914d0, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_PRESENTATION_TIME_OFFSET" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_PRESENTATION_TIME_OFFSETTest()
        {
            Assert.That(MF_EVENT_PRESENTATION_TIME_OFFSET, Is.EqualTo(new Guid(0x5ad914d1, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUTTest()
        {
            Assert.That(MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT, Is.EqualTo(new Guid(0x5ad914d2, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SOURCE_FAKE_START" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SOURCE_FAKE_STARTTest()
        {
            Assert.That(MF_EVENT_SOURCE_FAKE_START, Is.EqualTo(new Guid(0xa8cc55a7, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SOURCE_PROJECTSTART" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SOURCE_PROJECTSTARTTest()
        {
            Assert.That(MF_EVENT_SOURCE_PROJECTSTART, Is.EqualTo(new Guid(0xa8cc55a8, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SOURCE_ACTUAL_START" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SOURCE_ACTUAL_STARTTest()
        {
            Assert.That(MF_EVENT_SOURCE_ACTUAL_START, Is.EqualTo(new Guid(0xa8cc55a9, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SOURCE_TOPOLOGY_CANCELED" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SOURCE_TOPOLOGY_CANCELEDTest()
        {
            Assert.That(MF_EVENT_SOURCE_TOPOLOGY_CANCELED, Is.EqualTo(new Guid(0xdb62f650, 0x9a5e, 0x4704, 0xac, 0xf3, 0x56, 0x3b, 0xc6, 0xa7, 0x33, 0x64)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SOURCE_CHARACTERISTICS" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SOURCE_CHARACTERISTICSTest()
        {
            Assert.That(MF_EVENT_SOURCE_CHARACTERISTICS, Is.EqualTo(new Guid(0x47db8490, 0x8b22, 0x4f52, 0xaf, 0xda, 0x9c, 0xe1, 0xb2, 0xd3, 0xcf, 0xa8)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SOURCE_CHARACTERISTICS_OLD" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SOURCE_CHARACTERISTICS_OLDTest()
        {
            Assert.That(MF_EVENT_SOURCE_CHARACTERISTICS_OLD, Is.EqualTo(new Guid(0x47db8491, 0x8b22, 0x4f52, 0xaf, 0xda, 0x9c, 0xe1, 0xb2, 0xd3, 0xcf, 0xa8)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_DO_THINNING" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_DO_THINNINGTest()
        {
            Assert.That(MF_EVENT_DO_THINNING, Is.EqualTo(new Guid(0x321ea6fb, 0xdad9, 0x46e4, 0xb3, 0x1d, 0xd2, 0xea, 0xe7, 0x9, 0xe, 0x30)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_SCRUBSAMPLE_TIME" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_SCRUBSAMPLE_TIMETest()
        {
            Assert.That(MF_EVENT_SCRUBSAMPLE_TIME, Is.EqualTo(new Guid(0x9ac712b3, 0xdcb8, 0x44d5, 0x8d, 0xc, 0x37, 0x45, 0x5a, 0x27, 0x82, 0xe3)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_OUTPUT_NODE" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_OUTPUT_NODETest()
        {
            Assert.That(MF_EVENT_OUTPUT_NODE, Is.EqualTo(new Guid(0x830f1a8b, 0xc060, 0x46dd, 0xa8, 0x01, 0x1c, 0x95, 0xde, 0xc9, 0xb1, 0x07)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_MFT_INPUT_STREAM_ID" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_MFT_INPUT_STREAM_IDTest()
        {
            Assert.That(MF_EVENT_MFT_INPUT_STREAM_ID, Is.EqualTo(new Guid(0xf29c2cca, 0x7ae6, 0x42d2, 0xb2, 0x84, 0xbf, 0x83, 0x7c, 0xc8, 0x74, 0xe2)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_MFT_CONTEXT" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_MFT_CONTEXTTest()
        {
            Assert.That(MF_EVENT_MFT_CONTEXT, Is.EqualTo(new Guid(0xb7cd31f1, 0x899e, 0x4b41, 0x80, 0xc9, 0x26, 0xa8, 0x96, 0xd3, 0x29, 0x77)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_STREAM_METADATA_KEYDATA" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_STREAM_METADATA_KEYDATATest()
        {
            Assert.That(MF_EVENT_STREAM_METADATA_KEYDATA, Is.EqualTo(new Guid(0xcd59a4a1, 0x4a3b, 0x4bbd, 0x86, 0x65, 0x72, 0xa4, 0xf, 0xbe, 0xa7, 0x76)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_STREAM_METADATA_CONTENT_KEYIDS" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_STREAM_METADATA_CONTENT_KEYIDSTest()
        {
            Assert.That(MF_EVENT_STREAM_METADATA_CONTENT_KEYIDS, Is.EqualTo(new Guid(0x5063449d, 0xcc29, 0x4fc6, 0xa7, 0x5a, 0xd2, 0x47, 0xb3, 0x5a, 0xf8, 0x5c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_EVENT_STREAM_METADATA_SYSTEMID" /> property is correct.</summary>
        [Test]
        public static void MF_EVENT_STREAM_METADATA_SYSTEMIDTest()
        {
            Assert.That(MF_EVENT_STREAM_METADATA_SYSTEMID, Is.EqualTo(new Guid(0x1ea2ef64, 0xba16, 0x4a36, 0x87, 0x19, 0xfe, 0x75, 0x60, 0xba, 0x32, 0xad)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_MaxDecodeFrameSize" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_MaxDecodeFrameSizeTest()
        {
            Assert.That(MFSampleExtension_MaxDecodeFrameSize, Is.EqualTo(new Guid(0xd3cc654f, 0xf9f3, 0x4a13, 0x88, 0x9f, 0xf0, 0x4e, 0xb2, 0xb5, 0xb9, 0x57)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_AccumulatedNonRefPicPercent" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_AccumulatedNonRefPicPercentTest()
        {
            Assert.That(MFSampleExtension_AccumulatedNonRefPicPercent, Is.EqualTo(new Guid(0x79ea74df, 0xa740, 0x445b, 0xbc, 0x98, 0xc9, 0xed, 0x1f, 0x26, 0xe, 0xee)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_ProtectionScheme" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_ProtectionSchemeTest()
        {
            Assert.That(MFSampleExtension_Encryption_ProtectionScheme, Is.EqualTo(new Guid(0xd054d096, 0x28bb, 0x45da, 0x87, 0xec, 0x74, 0xf3, 0x51, 0x87, 0x14, 0x6)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_CryptByteBlock" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_CryptByteBlockTest()
        {
            Assert.That(MFSampleExtension_Encryption_CryptByteBlock, Is.EqualTo(new Guid(0x9d84289b, 0xc7f, 0x4713, 0xab, 0x95, 0x10, 0x8a, 0xb4, 0x2a, 0xd8, 0x1)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_SkipByteBlock" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_SkipByteBlockTest()
        {
            Assert.That(MFSampleExtension_Encryption_SkipByteBlock, Is.EqualTo(new Guid(0xd550548, 0x8317, 0x4ab1, 0x84, 0x5f, 0xd0, 0x63, 0x6, 0xe2, 0x93, 0xe3)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_SubSample_Mapping" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_SubSample_MappingTest()
        {
            Assert.That(MFSampleExtension_Encryption_SubSample_Mapping, Is.EqualTo(new Guid(0x8444F27A, 0x69A1, 0x48DA, 0xBD, 0x08, 0x11, 0xCE, 0xF3, 0x68, 0x30, 0xD2)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_ClearSliceHeaderData" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_ClearSliceHeaderDataTest()
        {
            Assert.That(MFSampleExtension_Encryption_ClearSliceHeaderData, Is.EqualTo(new Guid(0x5509a4f4, 0x320d, 0x4e6c, 0x8d, 0x1a, 0x94, 0xc6, 0x6d, 0xd2, 0xc, 0xb0)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_HardwareProtection_KeyInfoID" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_HardwareProtection_KeyInfoIDTest()
        {
            Assert.That(MFSampleExtension_Encryption_HardwareProtection_KeyInfoID, Is.EqualTo(new Guid(0x8cbfcceb, 0x94a5, 0x4de1, 0x82, 0x31, 0xa8, 0x5e, 0x47, 0xcf, 0x81, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_HardwareProtection_KeyInfo" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_HardwareProtection_KeyInfoTest()
        {
            Assert.That(MFSampleExtension_Encryption_HardwareProtection_KeyInfo, Is.EqualTo(new Guid(0xb2372080, 0x455b, 0x4dd7, 0x99, 0x89, 0x1a, 0x95, 0x57, 0x84, 0xb7, 0x54)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContext" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContextTest()
        {
            Assert.That(MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContext, Is.EqualTo(new Guid(0x693470c8, 0xe837, 0x47a0, 0x88, 0xcb, 0x53, 0x5b, 0x90, 0x5e, 0x35, 0x82)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_Opaque_Data" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_Opaque_DataTest()
        {
            Assert.That(MFSampleExtension_Encryption_Opaque_Data, Is.EqualTo(new Guid(0x224d77e5, 0x1391, 0x4ffb, 0x9f, 0x41, 0xb4, 0x32, 0xf6, 0x8c, 0x61, 0x1d)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_NALULengthInfo" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_NALULengthInfoTest()
        {
            Assert.That(MFSampleExtension_NALULengthInfo, Is.EqualTo(new Guid(0x19124E7C, 0xAD4B, 0x465F, 0xBB, 0x18, 0x20, 0x18, 0x62, 0x87, 0xB6, 0xAF)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_ResumeVideoOutput" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_ResumeVideoOutputTest()
        {
            Assert.That(MFSampleExtension_Encryption_ResumeVideoOutput, Is.EqualTo(new Guid(0xa435aba5, 0xafde, 0x4cf5, 0xbc, 0x1c, 0xf6, 0xac, 0xaf, 0x13, 0x94, 0x9d)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_NALUTypes" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_NALUTypesTest()
        {
            Assert.That(MFSampleExtension_Encryption_NALUTypes, Is.EqualTo(new Guid(0xb0f067c7, 0x714c, 0x416c, 0x8d, 0x59, 0x5f, 0x4d, 0xdf, 0x89, 0x13, 0xb6)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_SPSPPSData" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_SPSPPSDataTest()
        {
            Assert.That(MFSampleExtension_Encryption_SPSPPSData, Is.EqualTo(new Guid(0xaede0fa2, 0xe0c, 0x453c, 0xb7, 0xf3, 0xde, 0x86, 0x93, 0x36, 0x4d, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_SEIData" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_SEIDataTest()
        {
            Assert.That(MFSampleExtension_Encryption_SEIData, Is.EqualTo(new Guid(0x3cf0e972, 0x4542, 0x4687, 0x99, 0x99, 0x58, 0x5f, 0x56, 0x5f, 0xba, 0x7d)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_HardwareProtection" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_HardwareProtectionTest()
        {
            Assert.That(MFSampleExtension_Encryption_HardwareProtection, Is.EqualTo(new Guid(0x9a2b2d2b, 0x8270, 0x43e3, 0x84, 0x48, 0x99, 0x4f, 0x42, 0x6e, 0x88, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_CleanPoint" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_CleanPointTest()
        {
            Assert.That(MFSampleExtension_CleanPoint, Is.EqualTo(new Guid(0x9cdf01d8, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Discontinuity" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_DiscontinuityTest()
        {
            Assert.That(MFSampleExtension_Discontinuity, Is.EqualTo(new Guid(0x9cdf01d9, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Token" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_TokenTest()
        {
            Assert.That(MFSampleExtension_Token, Is.EqualTo(new Guid(0x8294da66, 0xf328, 0x4805, 0xb5, 0x51, 0x00, 0xde, 0xb4, 0xc5, 0x7a, 0x61)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_ClosedCaption_CEA708" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_ClosedCaption_CEA708Test()
        {
            Assert.That(MFSampleExtension_ClosedCaption_CEA708, Is.EqualTo(new Guid(0x26f09068, 0xe744, 0x47dc, 0xaa, 0x03, 0xdb, 0xf2, 0x04, 0x03, 0xbd, 0xe6)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_DecodeTimestamp" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_DecodeTimestampTest()
        {
            Assert.That(MFSampleExtension_DecodeTimestamp, Is.EqualTo(new Guid(0x73a954d4, 0x9e2, 0x4861, 0xbe, 0xfc, 0x94, 0xbd, 0x97, 0xc0, 0x8e, 0x6e)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_VideoEncodeQP" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_VideoEncodeQPTest()
        {
            Assert.That(MFSampleExtension_VideoEncodeQP, Is.EqualTo(new Guid(0xb2efe478, 0xf979, 0x4c66, 0xb9, 0x5e, 0xee, 0x2b, 0x82, 0xc8, 0x2f, 0x36)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_VideoEncodePictureType" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_VideoEncodePictureTypeTest()
        {
            Assert.That(MFSampleExtension_VideoEncodePictureType, Is.EqualTo(new Guid(0x973704e6, 0xcd14, 0x483c, 0x8f, 0x20, 0xc9, 0xfc, 0x9, 0x28, 0xba, 0xd5)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_FrameCorruption" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_FrameCorruptionTest()
        {
            Assert.That(MFSampleExtension_FrameCorruption, Is.EqualTo(new Guid(0xb4dd4a8c, 0xbeb, 0x44c4, 0x8b, 0x75, 0xb0, 0x2b, 0x91, 0x3b, 0x4, 0xf0)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_DirtyRects" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_DirtyRectsTest()
        {
            Assert.That(MFSampleExtension_DirtyRects, Is.EqualTo(new Guid(0x9ba70225, 0xb342, 0x4e97, 0x91, 0x26, 0x0b, 0x56, 0x6a, 0xb7, 0xea, 0x7e)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_MoveRegions" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_MoveRegionsTest()
        {
            Assert.That(MFSampleExtension_MoveRegions, Is.EqualTo(new Guid(0xe2a6c693, 0x3a8b, 0x4b8d, 0x95, 0xd0, 0xf6, 0x02, 0x81, 0xa1, 0x2f, 0xb7)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_HDCP_OptionalHeader" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_HDCP_OptionalHeaderTest()
        {
            Assert.That(MFSampleExtension_HDCP_OptionalHeader, Is.EqualTo(new Guid(0x9a2e7390, 0x121f, 0x455f, 0x83, 0x76, 0xc9, 0x74, 0x28, 0xe0, 0xb5, 0x40)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_HDCP_FrameCounter" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_HDCP_FrameCounterTest()
        {
            Assert.That(MFSampleExtension_HDCP_FrameCounter, Is.EqualTo(new Guid(0x9d389c60, 0xf507, 0x4aa6, 0xa4, 0xa, 0x71, 0x2, 0x7a, 0x2, 0xf3, 0xde)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_HDCP_StreamID" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_HDCP_StreamIDTest()
        {
            Assert.That(MFSampleExtension_HDCP_StreamID, Is.EqualTo(new Guid(0x177e5d74, 0xc370, 0x4a7a, 0x95, 0xa2, 0x36, 0x83, 0x3c, 0x01, 0xd0, 0xaf)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Timestamp" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_TimestampTest()
        {
            Assert.That(MFSampleExtension_Timestamp, Is.EqualTo(new Guid(0x1e436999, 0x69be, 0x4c7a, 0x93, 0x69, 0x70, 0x06, 0x8c, 0x02, 0x60, 0xcb)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_RepeatFrame" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_RepeatFrameTest()
        {
            Assert.That(MFSampleExtension_RepeatFrame, Is.EqualTo(new Guid(0x88be738f, 0x711, 0x4f42, 0xb4, 0x58, 0x34, 0x4a, 0xed, 0x42, 0xec, 0x2f)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_ENCODER_ERROR" /> property is correct.</summary>
        [Test]
        public static void MFT_ENCODER_ERRORTest()
        {
            Assert.That(MFT_ENCODER_ERROR, Is.EqualTo(new Guid(0xc8d1eda4, 0x98e4, 0x41d5, 0x92, 0x97, 0x44, 0xf5, 0x38, 0x52, 0xf9, 0x0e)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_GFX_DRIVER_VERSION_ID_Attribute" /> property is correct.</summary>
        [Test]
        public static void MFT_GFX_DRIVER_VERSION_ID_AttributeTest()
        {
            Assert.That(MFT_GFX_DRIVER_VERSION_ID_Attribute, Is.EqualTo(new Guid(0xf34b9093, 0x05e0, 0x4b16, 0x99, 0x3d, 0x3e, 0x2a, 0x2c, 0xde, 0x6a, 0xd3)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_DescrambleData" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_DescrambleDataTest()
        {
            Assert.That(MFSampleExtension_DescrambleData, Is.EqualTo(new Guid(0x43483be6, 0x4903, 0x4314, 0xb0, 0x32, 0x29, 0x51, 0x36, 0x59, 0x36, 0xfc)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_SampleKeyID" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_SampleKeyIDTest()
        {
            Assert.That(MFSampleExtension_SampleKeyID, Is.EqualTo(new Guid(0x9ed713c8, 0x9b87, 0x4b26, 0x82, 0x97, 0xa9, 0x3b, 0x0c, 0x5a, 0x8a, 0xcc)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_GenKeyFunc" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_GenKeyFuncTest()
        {
            Assert.That(MFSampleExtension_GenKeyFunc, Is.EqualTo(new Guid(0x441ca1ee, 0x6b1f, 0x4501, 0x90, 0x3a, 0xde, 0x87, 0xdf, 0x42, 0xf6, 0xed)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_GenKeyCtx" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_GenKeyCtxTest()
        {
            Assert.That(MFSampleExtension_GenKeyCtx, Is.EqualTo(new Guid(0x188120cb, 0xd7da, 0x4b59, 0x9b, 0x3e, 0x92, 0x52, 0xfd, 0x37, 0x30, 0x1c)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_PacketCrossOffsets" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_PacketCrossOffsetsTest()
        {
            Assert.That(MFSampleExtension_PacketCrossOffsets, Is.EqualTo(new Guid(0x2789671d, 0x389f, 0x40bb, 0x90, 0xd9, 0xc2, 0x82, 0xf7, 0x7f, 0x9a, 0xbd)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_SampleID" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_SampleIDTest()
        {
            Assert.That(MFSampleExtension_Encryption_SampleID, Is.EqualTo(new Guid(0x6698b84e, 0x0afa, 0x4330, 0xae, 0xb2, 0x1c, 0x0a, 0x98, 0xd7, 0xa4, 0x4d)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_KeyID" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_KeyIDTest()
        {
            Assert.That(MFSampleExtension_Encryption_KeyID, Is.EqualTo(new Guid(0x76376591, 0x795f, 0x4da1, 0x86, 0xed, 0x9d, 0x46, 0xec, 0xa1, 0x09, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Content_KeyID" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Content_KeyIDTest()
        {
            Assert.That(MFSampleExtension_Content_KeyID, Is.EqualTo(new Guid(0xc6c7f5b0, 0xacca, 0x415b, 0x87, 0xd9, 0x10, 0x44, 0x14, 0x69, 0xef, 0xc6)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Encryption_SubSampleMappingSplit" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Encryption_SubSampleMappingSplitTest()
        {
            Assert.That(MFSampleExtension_Encryption_SubSampleMappingSplit, Is.EqualTo(new Guid(0xfe0254b9, 0x2aa5, 0x4edc, 0x99, 0xf7, 0x17, 0xe8, 0x9d, 0xbf, 0x91, 0x74)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Interlaced" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_InterlacedTest()
        {
            Assert.That(MFSampleExtension_Interlaced, Is.EqualTo(new Guid(0xb1d5830a, 0xdeb8, 0x40e3, 0x90, 0xfa, 0x38, 0x99, 0x43, 0x71, 0x64, 0x61)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_BottomFieldFirst" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_BottomFieldFirstTest()
        {
            Assert.That(MFSampleExtension_BottomFieldFirst, Is.EqualTo(new Guid(0x941ce0a3, 0x6ae3, 0x4dda, 0x9a, 0x08, 0xa6, 0x42, 0x98, 0x34, 0x06, 0x17)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_RepeatFirstField" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_RepeatFirstFieldTest()
        {
            Assert.That(MFSampleExtension_RepeatFirstField, Is.EqualTo(new Guid(0x304d257c, 0x7493, 0x4fbd, 0xb1, 0x49, 0x92, 0x28, 0xde, 0x8d, 0x9a, 0x99)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_SingleField" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_SingleFieldTest()
        {
            Assert.That(MFSampleExtension_SingleField, Is.EqualTo(new Guid(0x9d85f816, 0x658b, 0x455a, 0xbd, 0xe0, 0x9f, 0xa7, 0xe1, 0x5a, 0xb8, 0xf9)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_DerivedFromTopField" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_DerivedFromTopFieldTest()
        {
            Assert.That(MFSampleExtension_DerivedFromTopField, Is.EqualTo(new Guid(0x6852465a, 0xae1c, 0x4553, 0x8e, 0x9b, 0xc3, 0x42, 0x0f, 0xcb, 0x16, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_MeanAbsoluteDifference" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_MeanAbsoluteDifferenceTest()
        {
            Assert.That(MFSampleExtension_MeanAbsoluteDifference, Is.EqualTo(new Guid(0x1cdbde11, 0x08b4, 0x4311, 0xa6, 0xdd, 0x0f, 0x9f, 0x37, 0x19, 0x07, 0xaa)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_LongTermReferenceFrameInfo" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_LongTermReferenceFrameInfoTest()
        {
            Assert.That(MFSampleExtension_LongTermReferenceFrameInfo, Is.EqualTo(new Guid(0x9154733f, 0xe1bd, 0x41bf, 0x81, 0xd3, 0xfc, 0xd9, 0x18, 0xf7, 0x13, 0x32)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_ROIRectangle" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_ROIRectangleTest()
        {
            Assert.That(MFSampleExtension_ROIRectangle, Is.EqualTo(new Guid(0x3414a438, 0x4998, 0x4d2c, 0xbe, 0x82, 0xbe, 0x3c, 0xa0, 0xb2, 0x4d, 0x43)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_LastSlice" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_LastSliceTest()
        {
            Assert.That(MFSampleExtension_LastSlice, Is.EqualTo(new Guid(0x2b5d5457, 0x5547, 0x4f07, 0xb8, 0xc8, 0xb4, 0xa3, 0xa9, 0xa1, 0xda, 0xac)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_FeatureMap" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_FeatureMapTest()
        {
            Assert.That(MFSampleExtension_FeatureMap, Is.EqualTo(new Guid(0xa032d165, 0x46fc, 0x400a, 0xb4, 0x49, 0x49, 0xde, 0x53, 0xe6, 0x2a, 0x6e)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_ChromaOnly" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_ChromaOnlyTest()
        {
            Assert.That(MFSampleExtension_ChromaOnly, Is.EqualTo(new Guid(0x1eb9179c, 0xa01f, 0x4845, 0x8c, 0x04, 0x0e, 0x65, 0xa2, 0x6e, 0xb0, 0x4f)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_PhotoThumbnail" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_PhotoThumbnailTest()
        {
            Assert.That(MFSampleExtension_PhotoThumbnail, Is.EqualTo(new Guid(0x74BBC85C, 0xC8BB, 0x42DC, 0xB5, 0x86, 0xDA, 0x17, 0xFF, 0xD3, 0x5D, 0xCC)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_PhotoThumbnailMediaType" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_PhotoThumbnailMediaTypeTest()
        {
            Assert.That(MFSampleExtension_PhotoThumbnailMediaType, Is.EqualTo(new Guid(0x61AD5420, 0xEBF8, 0x4143, 0x89, 0xAF, 0x6B, 0xF2, 0x5F, 0x67, 0x2D, 0xEF)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_CaptureMetadata" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_CaptureMetadataTest()
        {
            Assert.That(MFSampleExtension_CaptureMetadata, Is.EqualTo(new Guid(0x2EBE23A8, 0xFAF5, 0x444A, 0xA6, 0xA2, 0xEB, 0x81, 0x08, 0x80, 0xAB, 0x5D)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_MDLCacheCookie" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_MDLCacheCookieTest()
        {
            Assert.That(MFSampleExtension_MDLCacheCookie, Is.EqualTo(new Guid(0x5F002AF9, 0xD8F9, 0x41A3, 0xB6, 0xC3, 0xA2, 0xAD, 0x43, 0xF6, 0x47, 0xAD)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_PHOTO_FRAME_FLASH" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_PHOTO_FRAME_FLASHTest()
        {
            Assert.That(MF_CAPTURE_METADATA_PHOTO_FRAME_FLASH, Is.EqualTo(new Guid(0x0F9DD6C6, 0x6003, 0x45D8, 0xBD, 0x59, 0xF1, 0xF5, 0x3E, 0x3D, 0x04, 0xE8)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FRAME_RAWSTREAM" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FRAME_RAWSTREAMTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FRAME_RAWSTREAM, Is.EqualTo(new Guid(0x9252077B, 0x2680, 0x49B9, 0xAE, 0x02, 0xB1, 0x90, 0x75, 0x97, 0x3B, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FOCUSSTATE" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FOCUSSTATETest()
        {
            Assert.That(MF_CAPTURE_METADATA_FOCUSSTATE, Is.EqualTo(new Guid(0xa87ee154, 0x997f, 0x465d, 0xb9, 0x1f, 0x29, 0xd5, 0x3b, 0x98, 0x2b, 0x88)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_REQUESTED_FRAME_SETTING_ID" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_REQUESTED_FRAME_SETTING_IDTest()
        {
            Assert.That(MF_CAPTURE_METADATA_REQUESTED_FRAME_SETTING_ID, Is.EqualTo(new Guid(0xbb3716d9, 0x8a61, 0x47a4, 0x81, 0x97, 0x45, 0x9c, 0x7f, 0xf1, 0x74, 0xd5)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_EXPOSURE_TIME" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_EXPOSURE_TIMETest()
        {
            Assert.That(MF_CAPTURE_METADATA_EXPOSURE_TIME, Is.EqualTo(new Guid(0x16b9ae99, 0xcd84, 0x4063, 0x87, 0x9d, 0xa2, 0x8c, 0x76, 0x33, 0x72, 0x9e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_EXPOSURE_COMPENSATION" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_EXPOSURE_COMPENSATIONTest()
        {
            Assert.That(MF_CAPTURE_METADATA_EXPOSURE_COMPENSATION, Is.EqualTo(new Guid(0xd198aa75, 0x4b62, 0x4345, 0xab, 0xf3, 0x3c, 0x31, 0xfa, 0x12, 0xc2, 0x99)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_ISO_SPEED" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_ISO_SPEEDTest()
        {
            Assert.That(MF_CAPTURE_METADATA_ISO_SPEED, Is.EqualTo(new Guid(0xe528a68f, 0xb2e3, 0x44fe, 0x8b, 0x65, 0x7, 0xbf, 0x4b, 0x5a, 0x13, 0xff)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_LENS_POSITION" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_LENS_POSITIONTest()
        {
            Assert.That(MF_CAPTURE_METADATA_LENS_POSITION, Is.EqualTo(new Guid(0xb5fc8e86, 0x11d1, 0x4e70, 0x81, 0x9b, 0x72, 0x3a, 0x89, 0xfa, 0x45, 0x20)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_SCENE_MODE" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_SCENE_MODETest()
        {
            Assert.That(MF_CAPTURE_METADATA_SCENE_MODE, Is.EqualTo(new Guid(0x9cc3b54d, 0x5ed3, 0x4bae, 0xb3, 0x88, 0x76, 0x70, 0xae, 0xf5, 0x9e, 0x13)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FLASH" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FLASHTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FLASH, Is.EqualTo(new Guid(0x4a51520b, 0xfb36, 0x446c, 0x9d, 0xf2, 0x68, 0x17, 0x1b, 0x9a, 0x3, 0x89)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FLASH_POWER" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FLASH_POWERTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FLASH_POWER, Is.EqualTo(new Guid(0x9c0e0d49, 0x205, 0x491a, 0xbc, 0x9d, 0x2d, 0x6e, 0x1f, 0x4d, 0x56, 0x84)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_WHITEBALANCE" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_WHITEBALANCETest()
        {
            Assert.That(MF_CAPTURE_METADATA_WHITEBALANCE, Is.EqualTo(new Guid(0xc736fd77, 0xfb9, 0x4e2e, 0x97, 0xa2, 0xfc, 0xd4, 0x90, 0x73, 0x9e, 0xe9)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_ZOOMFACTOR" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_ZOOMFACTORTest()
        {
            Assert.That(MF_CAPTURE_METADATA_ZOOMFACTOR, Is.EqualTo(new Guid(0xe50b0b81, 0xe501, 0x42c2, 0xab, 0xf2, 0x85, 0x7e, 0xcb, 0x13, 0xfa, 0x5c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FACEROIS" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FACEROISTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FACEROIS, Is.EqualTo(new Guid(0x864f25a6, 0x349f, 0x46b1, 0xa3, 0xe, 0x54, 0xcc, 0x22, 0x92, 0x8a, 0x47)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FACEROITIMESTAMPS" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FACEROITIMESTAMPSTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FACEROITIMESTAMPS, Is.EqualTo(new Guid(0xe94d50cc, 0x3da0, 0x44d4, 0xbb, 0x34, 0x83, 0x19, 0x8a, 0x74, 0x18, 0x68)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FACEROICHARACTERIZATIONS" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FACEROICHARACTERIZATIONSTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FACEROICHARACTERIZATIONS, Is.EqualTo(new Guid(0xb927a1a8, 0x18ef, 0x46d3, 0xb3, 0xaf, 0x69, 0x37, 0x2f, 0x94, 0xd9, 0xb2)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_ISO_GAINS" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_ISO_GAINSTest()
        {
            Assert.That(MF_CAPTURE_METADATA_ISO_GAINS, Is.EqualTo(new Guid(0x5802ac9, 0xe1d, 0x41c7, 0xa8, 0xc8, 0x7e, 0x73, 0x69, 0xf8, 0x4e, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_SENSORFRAMERATE" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_SENSORFRAMERATETest()
        {
            Assert.That(MF_CAPTURE_METADATA_SENSORFRAMERATE, Is.EqualTo(new Guid(0xdb51357e, 0x9d3d, 0x4962, 0xb0, 0x6d, 0x7, 0xce, 0x65, 0xd, 0x9a, 0xa)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_WHITEBALANCE_GAINS" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_WHITEBALANCE_GAINSTest()
        {
            Assert.That(MF_CAPTURE_METADATA_WHITEBALANCE_GAINS, Is.EqualTo(new Guid(0xe7570c8f, 0x2dcb, 0x4c7c, 0xaa, 0xce, 0x22, 0xec, 0xe7, 0xcc, 0xe6, 0x47)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_HISTOGRAM" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_HISTOGRAMTest()
        {
            Assert.That(MF_CAPTURE_METADATA_HISTOGRAM, Is.EqualTo(new Guid(0x85358432, 0x2ef6, 0x4ba9, 0xa3, 0xfb, 0x6, 0xd8, 0x29, 0x74, 0xb8, 0x95)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_EXIF" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_EXIFTest()
        {
            Assert.That(MF_CAPTURE_METADATA_EXIF, Is.EqualTo(new Guid(0x2e9575b8, 0x8c31, 0x4a02, 0x85, 0x75, 0x42, 0xb1, 0x97, 0xb7, 0x15, 0x92)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FRAME_ILLUMINATION" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FRAME_ILLUMINATIONTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FRAME_ILLUMINATION, Is.EqualTo(new Guid(0x6D688FFC, 0x63D3, 0x46FE, 0xBA, 0xDA, 0x5B, 0x94, 0x7D, 0xB0, 0xD0, 0x80)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_UVC_PAYLOADHEADER" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_UVC_PAYLOADHEADERTest()
        {
            Assert.That(MF_CAPTURE_METADATA_UVC_PAYLOADHEADER, Is.EqualTo(new Guid(0xf9f88a87, 0xe1dd, 0x441e, 0x95, 0xcb, 0x42, 0xe2, 0x1a, 0x64, 0xf1, 0xd9)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Depth_MinReliableDepth" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Depth_MinReliableDepthTest()
        {
            Assert.That(MFSampleExtension_Depth_MinReliableDepth, Is.EqualTo(new Guid(0x5f8582b2, 0xe36b, 0x47c8, 0x9b, 0x87, 0xfe, 0xe1, 0xca, 0x72, 0xc5, 0xb0)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Depth_MaxReliableDepth" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Depth_MaxReliableDepthTest()
        {
            Assert.That(MFSampleExtension_Depth_MaxReliableDepth, Is.EqualTo(new Guid(0xe45545d1, 0x1f0f, 0x4a32, 0xa8, 0xa7, 0x61, 0x1, 0xa2, 0x4e, 0xa8, 0xbe)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_FIRST_SCANLINE_START_TIME_QPC" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_FIRST_SCANLINE_START_TIME_QPCTest()
        {
            Assert.That(MF_CAPTURE_METADATA_FIRST_SCANLINE_START_TIME_QPC, Is.EqualTo(new Guid(0x6a2c49f1, 0xe052, 0x46b6, 0xb2, 0xd9, 0x73, 0xc1, 0x55, 0x87, 0x09, 0xaf)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_LAST_SCANLINE_END_TIME_QPC" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_LAST_SCANLINE_END_TIME_QPCTest()
        {
            Assert.That(MF_CAPTURE_METADATA_LAST_SCANLINE_END_TIME_QPC, Is.EqualTo(new Guid(0xdccadecb, 0xc4d4, 0x400d, 0xb4, 0x18, 0x10, 0xe8, 0x85, 0x25, 0xe1, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_SCANLINE_TIME_QPC_ACCURACY" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_SCANLINE_TIME_QPC_ACCURACYTest()
        {
            Assert.That(MF_CAPTURE_METADATA_SCANLINE_TIME_QPC_ACCURACY, Is.EqualTo(new Guid(0x4cd79c51, 0xf765, 0x4b09, 0xb1, 0xe1, 0x27, 0xd1, 0xf7, 0xeb, 0xea, 0x09)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_SCANLINE_DIRECTION" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_SCANLINE_DIRECTIONTest()
        {
            Assert.That(MF_CAPTURE_METADATA_SCANLINE_DIRECTION, Is.EqualTo(new Guid(0x6496a3ba, 0x1907, 0x49e6, 0xb0, 0xc3, 0x12, 0x37, 0x95, 0xf3, 0x80, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="MF_CAPTURE_METADATA_DIGITALWINDOW" /> property is correct.</summary>
        [Test]
        public static void MF_CAPTURE_METADATA_DIGITALWINDOWTest()
        {
            Assert.That(MF_CAPTURE_METADATA_DIGITALWINDOW, Is.EqualTo(new Guid(0x276f72a2, 0x59c8, 0x4f69, 0x97, 0xb4, 0x6, 0x8b, 0x8c, 0xe, 0xc0, 0x44)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_VIDEO_DECODER" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_VIDEO_DECODERTest()
        {
            Assert.That(MFT_CATEGORY_VIDEO_DECODER, Is.EqualTo(new Guid(0xd6c02d4b, 0x6833, 0x45b4, 0x97, 0x1a, 0x05, 0xa4, 0xb0, 0x4b, 0xab, 0x91)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_VIDEO_ENCODER" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_VIDEO_ENCODERTest()
        {
            Assert.That(MFT_CATEGORY_VIDEO_ENCODER, Is.EqualTo(new Guid(0xf79eac7d, 0xe545, 0x4387, 0xbd, 0xee, 0xd6, 0x47, 0xd7, 0xbd, 0xe4, 0x2a)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_VIDEO_EFFECT" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_VIDEO_EFFECTTest()
        {
            Assert.That(MFT_CATEGORY_VIDEO_EFFECT, Is.EqualTo(new Guid(0x12e17c21, 0x532c, 0x4a6e, 0x8a, 0x1c, 0x40, 0x82, 0x5a, 0x73, 0x63, 0x97)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_MULTIPLEXER" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_MULTIPLEXERTest()
        {
            Assert.That(MFT_CATEGORY_MULTIPLEXER, Is.EqualTo(new Guid(0x059c561e, 0x05ae, 0x4b61, 0xb6, 0x9d, 0x55, 0xb6, 0x1e, 0xe5, 0x4a, 0x7b)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_DEMULTIPLEXER" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_DEMULTIPLEXERTest()
        {
            Assert.That(MFT_CATEGORY_DEMULTIPLEXER, Is.EqualTo(new Guid(0xa8700a7a, 0x939b, 0x44c5, 0x99, 0xd7, 0x76, 0x22, 0x6b, 0x23, 0xb3, 0xf1)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_AUDIO_DECODER" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_AUDIO_DECODERTest()
        {
            Assert.That(MFT_CATEGORY_AUDIO_DECODER, Is.EqualTo(new Guid(0x9ea73fb4, 0xef7a, 0x4559, 0x8d, 0x5d, 0x71, 0x9d, 0x8f, 0x04, 0x26, 0xc7)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_AUDIO_ENCODER" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_AUDIO_ENCODERTest()
        {
            Assert.That(MFT_CATEGORY_AUDIO_ENCODER, Is.EqualTo(new Guid(0x91c64bd0, 0xf91e, 0x4d8c, 0x92, 0x76, 0xdb, 0x24, 0x82, 0x79, 0xd9, 0x75)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_AUDIO_EFFECT" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_AUDIO_EFFECTTest()
        {
            Assert.That(MFT_CATEGORY_AUDIO_EFFECT, Is.EqualTo(new Guid(0x11064c48, 0x3648, 0x4ed0, 0x93, 0x2e, 0x05, 0xce, 0x8a, 0xc8, 0x11, 0xb7)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_VIDEO_PROCESSOR" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_VIDEO_PROCESSORTest()
        {
            Assert.That(MFT_CATEGORY_VIDEO_PROCESSOR, Is.EqualTo(new Guid(0x302ea3fc, 0xaa5f, 0x47f9, 0x9f, 0x7a, 0xc2, 0x18, 0x8b, 0xb1, 0x63, 0x2)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_OTHER" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_OTHERTest()
        {
            Assert.That(MFT_CATEGORY_OTHER, Is.EqualTo(new Guid(0x90175d57, 0xb7ea, 0x4901, 0xae, 0xb3, 0x93, 0x3a, 0x87, 0x47, 0x75, 0x6f)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_ENCRYPTOR" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_ENCRYPTORTest()
        {
            Assert.That(MFT_CATEGORY_ENCRYPTOR, Is.EqualTo(new Guid(0xb0c687be, 0x01cd, 0x44b5, 0xb8, 0xb2, 0x7c, 0x1d, 0x7e, 0x05, 0x8b, 0x1f)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_CATEGORY_VIDEO_RENDERER_EFFECT" /> property is correct.</summary>
        [Test]
        public static void MFT_CATEGORY_VIDEO_RENDERER_EFFECTTest()
        {
            Assert.That(MFT_CATEGORY_VIDEO_RENDERER_EFFECT, Is.EqualTo(new Guid(0x145cd8b4, 0x92f4, 0x4b23, 0x8a, 0xe7, 0xe0, 0xdf, 0x6, 0xc2, 0xda, 0x95)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILE" /> property is correct.</summary>
        [Test]
        public static void MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILETest()
        {
            Assert.That(MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILE, Is.EqualTo(new Guid(0x62c56928, 0x9a4e, 0x443b, 0xb9, 0xdc, 0xca, 0xc8, 0x30, 0xc2, 0x41, 0x0)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_ENUM_ADAPTER_LUID" /> property is correct.</summary>
        [Test]
        public static void MFT_ENUM_ADAPTER_LUIDTest()
        {
            Assert.That(MFT_ENUM_ADAPTER_LUID, Is.EqualTo(new Guid(0x1d39518c, 0xe220, 0x4da8, 0xa0, 0x7f, 0xba, 0x17, 0x25, 0x52, 0xd6, 0xb1)));
        }

        /// <summary>Validates that the value of the <see cref="MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE" /> property is correct.</summary>
        [Test]
        public static void MFT_SUPPORT_DYNAMIC_FORMAT_CHANGETest()
        {
            Assert.That(MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE, Is.EqualTo(new Guid(0x53476a11, 0x3f13, 0x49fb, 0xac, 0x42, 0xee, 0x27, 0x33, 0xc9, 0x67, 0x41)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Base" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_BaseTest()
        {
            Assert.That(MFVideoFormat_Base, Is.EqualTo(new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_RGB32" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_RGB32Test()
        {
            Assert.That(MFVideoFormat_RGB32, Is.EqualTo(new Guid(22, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_ARGB32" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_ARGB32Test()
        {
            Assert.That(MFVideoFormat_ARGB32, Is.EqualTo(new Guid(21, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_RGB24" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_RGB24Test()
        {
            Assert.That(MFVideoFormat_RGB24, Is.EqualTo(new Guid(20, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_RGB555" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_RGB555Test()
        {
            Assert.That(MFVideoFormat_RGB555, Is.EqualTo(new Guid(24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_RGB565" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_RGB565Test()
        {
            Assert.That(MFVideoFormat_RGB565, Is.EqualTo(new Guid(23, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_RGB8" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_RGB8Test()
        {
            Assert.That(MFVideoFormat_RGB8, Is.EqualTo(new Guid(41, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_L8" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_L8Test()
        {
            Assert.That(MFVideoFormat_L8, Is.EqualTo(new Guid(50, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_L16" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_L16Test()
        {
            Assert.That(MFVideoFormat_L16, Is.EqualTo(new Guid(81, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_D16" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_D16Test()
        {
            Assert.That(MFVideoFormat_D16, Is.EqualTo(new Guid(80, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_AI44" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_AI44Test()
        {
            Assert.That(MFVideoFormat_AI44, Is.EqualTo(new Guid(unchecked((((uint)(0x41493434) & 0xFF) << 24) | (((uint)(0x41493434) & 0xFF00) << 8) | (((uint)(0x41493434) & 0xFF0000) >> 8) | (((uint)(0x41493434) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_AYUV" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_AYUVTest()
        {
            Assert.That(MFVideoFormat_AYUV, Is.EqualTo(new Guid(unchecked((((uint)(0x41595556) & 0xFF) << 24) | (((uint)(0x41595556) & 0xFF00) << 8) | (((uint)(0x41595556) & 0xFF0000) >> 8) | (((uint)(0x41595556) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_YUY2" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_YUY2Test()
        {
            Assert.That(MFVideoFormat_YUY2, Is.EqualTo(new Guid(unchecked((((uint)(0x59555932) & 0xFF) << 24) | (((uint)(0x59555932) & 0xFF00) << 8) | (((uint)(0x59555932) & 0xFF0000) >> 8) | (((uint)(0x59555932) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_YVYU" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_YVYUTest()
        {
            Assert.That(MFVideoFormat_YVYU, Is.EqualTo(new Guid(unchecked((((uint)(0x59565955) & 0xFF) << 24) | (((uint)(0x59565955) & 0xFF00) << 8) | (((uint)(0x59565955) & 0xFF0000) >> 8) | (((uint)(0x59565955) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_YVU9" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_YVU9Test()
        {
            Assert.That(MFVideoFormat_YVU9, Is.EqualTo(new Guid(unchecked((((uint)(0x59565539) & 0xFF) << 24) | (((uint)(0x59565539) & 0xFF00) << 8) | (((uint)(0x59565539) & 0xFF0000) >> 8) | (((uint)(0x59565539) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_UYVY" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_UYVYTest()
        {
            Assert.That(MFVideoFormat_UYVY, Is.EqualTo(new Guid(unchecked((((uint)(0x55595659) & 0xFF) << 24) | (((uint)(0x55595659) & 0xFF00) << 8) | (((uint)(0x55595659) & 0xFF0000) >> 8) | (((uint)(0x55595659) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_NV11" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_NV11Test()
        {
            Assert.That(MFVideoFormat_NV11, Is.EqualTo(new Guid(unchecked((((uint)(0x4E563131) & 0xFF) << 24) | (((uint)(0x4E563131) & 0xFF00) << 8) | (((uint)(0x4E563131) & 0xFF0000) >> 8) | (((uint)(0x4E563131) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_NV12" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_NV12Test()
        {
            Assert.That(MFVideoFormat_NV12, Is.EqualTo(new Guid(unchecked((((uint)(0x4E563132) & 0xFF) << 24) | (((uint)(0x4E563132) & 0xFF00) << 8) | (((uint)(0x4E563132) & 0xFF0000) >> 8) | (((uint)(0x4E563132) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_YV12" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_YV12Test()
        {
            Assert.That(MFVideoFormat_YV12, Is.EqualTo(new Guid(unchecked((((uint)(0x59563132) & 0xFF) << 24) | (((uint)(0x59563132) & 0xFF00) << 8) | (((uint)(0x59563132) & 0xFF0000) >> 8) | (((uint)(0x59563132) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_I420" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_I420Test()
        {
            Assert.That(MFVideoFormat_I420, Is.EqualTo(new Guid(unchecked((((uint)(0x49343230) & 0xFF) << 24) | (((uint)(0x49343230) & 0xFF00) << 8) | (((uint)(0x49343230) & 0xFF0000) >> 8) | (((uint)(0x49343230) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_IYUV" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_IYUVTest()
        {
            Assert.That(MFVideoFormat_IYUV, Is.EqualTo(new Guid(unchecked((((uint)(0x49595556) & 0xFF) << 24) | (((uint)(0x49595556) & 0xFF00) << 8) | (((uint)(0x49595556) & 0xFF0000) >> 8) | (((uint)(0x49595556) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Y210" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Y210Test()
        {
            Assert.That(MFVideoFormat_Y210, Is.EqualTo(new Guid(unchecked((((uint)(0x59323130) & 0xFF) << 24) | (((uint)(0x59323130) & 0xFF00) << 8) | (((uint)(0x59323130) & 0xFF0000) >> 8) | (((uint)(0x59323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Y216" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Y216Test()
        {
            Assert.That(MFVideoFormat_Y216, Is.EqualTo(new Guid(unchecked((((uint)(0x59323136) & 0xFF) << 24) | (((uint)(0x59323136) & 0xFF00) << 8) | (((uint)(0x59323136) & 0xFF0000) >> 8) | (((uint)(0x59323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Y410" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Y410Test()
        {
            Assert.That(MFVideoFormat_Y410, Is.EqualTo(new Guid(unchecked((((uint)(0x59343130) & 0xFF) << 24) | (((uint)(0x59343130) & 0xFF00) << 8) | (((uint)(0x59343130) & 0xFF0000) >> 8) | (((uint)(0x59343130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Y416" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Y416Test()
        {
            Assert.That(MFVideoFormat_Y416, Is.EqualTo(new Guid(unchecked((((uint)(0x59343136) & 0xFF) << 24) | (((uint)(0x59343136) & 0xFF00) << 8) | (((uint)(0x59343136) & 0xFF0000) >> 8) | (((uint)(0x59343136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Y41P" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Y41PTest()
        {
            Assert.That(MFVideoFormat_Y41P, Is.EqualTo(new Guid(unchecked((((uint)(0x59343150) & 0xFF) << 24) | (((uint)(0x59343150) & 0xFF00) << 8) | (((uint)(0x59343150) & 0xFF0000) >> 8) | (((uint)(0x59343150) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Y41T" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Y41TTest()
        {
            Assert.That(MFVideoFormat_Y41T, Is.EqualTo(new Guid(unchecked((((uint)(0x59343154) & 0xFF) << 24) | (((uint)(0x59343154) & 0xFF00) << 8) | (((uint)(0x59343154) & 0xFF0000) >> 8) | (((uint)(0x59343154) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Y42T" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Y42TTest()
        {
            Assert.That(MFVideoFormat_Y42T, Is.EqualTo(new Guid(unchecked((((uint)(0x59343254) & 0xFF) << 24) | (((uint)(0x59343254) & 0xFF00) << 8) | (((uint)(0x59343254) & 0xFF0000) >> 8) | (((uint)(0x59343254) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_P210" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_P210Test()
        {
            Assert.That(MFVideoFormat_P210, Is.EqualTo(new Guid(unchecked((((uint)(0x50323130) & 0xFF) << 24) | (((uint)(0x50323130) & 0xFF00) << 8) | (((uint)(0x50323130) & 0xFF0000) >> 8) | (((uint)(0x50323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_P216" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_P216Test()
        {
            Assert.That(MFVideoFormat_P216, Is.EqualTo(new Guid(unchecked((((uint)(0x50323136) & 0xFF) << 24) | (((uint)(0x50323136) & 0xFF00) << 8) | (((uint)(0x50323136) & 0xFF0000) >> 8) | (((uint)(0x50323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_P010" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_P010Test()
        {
            Assert.That(MFVideoFormat_P010, Is.EqualTo(new Guid(unchecked((((uint)(0x50303130) & 0xFF) << 24) | (((uint)(0x50303130) & 0xFF00) << 8) | (((uint)(0x50303130) & 0xFF0000) >> 8) | (((uint)(0x50303130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_P016" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_P016Test()
        {
            Assert.That(MFVideoFormat_P016, Is.EqualTo(new Guid(unchecked((((uint)(0x50303136) & 0xFF) << 24) | (((uint)(0x50303136) & 0xFF00) << 8) | (((uint)(0x50303136) & 0xFF0000) >> 8) | (((uint)(0x50303136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_v210" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_v210Test()
        {
            Assert.That(MFVideoFormat_v210, Is.EqualTo(new Guid(unchecked((((uint)(0x76323130) & 0xFF) << 24) | (((uint)(0x76323130) & 0xFF00) << 8) | (((uint)(0x76323130) & 0xFF0000) >> 8) | (((uint)(0x76323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_v216" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_v216Test()
        {
            Assert.That(MFVideoFormat_v216, Is.EqualTo(new Guid(unchecked((((uint)(0x76323136) & 0xFF) << 24) | (((uint)(0x76323136) & 0xFF00) << 8) | (((uint)(0x76323136) & 0xFF0000) >> 8) | (((uint)(0x76323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_v410" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_v410Test()
        {
            Assert.That(MFVideoFormat_v410, Is.EqualTo(new Guid(unchecked((((uint)(0x76343130) & 0xFF) << 24) | (((uint)(0x76343130) & 0xFF00) << 8) | (((uint)(0x76343130) & 0xFF0000) >> 8) | (((uint)(0x76343130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MP43" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MP43Test()
        {
            Assert.That(MFVideoFormat_MP43, Is.EqualTo(new Guid(unchecked((((uint)(0x4D503433) & 0xFF) << 24) | (((uint)(0x4D503433) & 0xFF00) << 8) | (((uint)(0x4D503433) & 0xFF0000) >> 8) | (((uint)(0x4D503433) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MP4S" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MP4STest()
        {
            Assert.That(MFVideoFormat_MP4S, Is.EqualTo(new Guid(unchecked((((uint)(0x4D503453) & 0xFF) << 24) | (((uint)(0x4D503453) & 0xFF00) << 8) | (((uint)(0x4D503453) & 0xFF0000) >> 8) | (((uint)(0x4D503453) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_M4S2" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_M4S2Test()
        {
            Assert.That(MFVideoFormat_M4S2, Is.EqualTo(new Guid(unchecked((((uint)(0x4D345332) & 0xFF) << 24) | (((uint)(0x4D345332) & 0xFF00) << 8) | (((uint)(0x4D345332) & 0xFF0000) >> 8) | (((uint)(0x4D345332) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MP4V" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MP4VTest()
        {
            Assert.That(MFVideoFormat_MP4V, Is.EqualTo(new Guid(unchecked((((uint)(0x4D503456) & 0xFF) << 24) | (((uint)(0x4D503456) & 0xFF00) << 8) | (((uint)(0x4D503456) & 0xFF0000) >> 8) | (((uint)(0x4D503456) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_WMV1" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_WMV1Test()
        {
            Assert.That(MFVideoFormat_WMV1, Is.EqualTo(new Guid(unchecked((((uint)(0x574D5631) & 0xFF) << 24) | (((uint)(0x574D5631) & 0xFF00) << 8) | (((uint)(0x574D5631) & 0xFF0000) >> 8) | (((uint)(0x574D5631) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_WMV2" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_WMV2Test()
        {
            Assert.That(MFVideoFormat_WMV2, Is.EqualTo(new Guid(unchecked((((uint)(0x574D5632) & 0xFF) << 24) | (((uint)(0x574D5632) & 0xFF00) << 8) | (((uint)(0x574D5632) & 0xFF0000) >> 8) | (((uint)(0x574D5632) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_WMV3" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_WMV3Test()
        {
            Assert.That(MFVideoFormat_WMV3, Is.EqualTo(new Guid(unchecked((((uint)(0x574D5633) & 0xFF) << 24) | (((uint)(0x574D5633) & 0xFF00) << 8) | (((uint)(0x574D5633) & 0xFF0000) >> 8) | (((uint)(0x574D5633) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_WVC1" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_WVC1Test()
        {
            Assert.That(MFVideoFormat_WVC1, Is.EqualTo(new Guid(unchecked((((uint)(0x57564331) & 0xFF) << 24) | (((uint)(0x57564331) & 0xFF00) << 8) | (((uint)(0x57564331) & 0xFF0000) >> 8) | (((uint)(0x57564331) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MSS1" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MSS1Test()
        {
            Assert.That(MFVideoFormat_MSS1, Is.EqualTo(new Guid(unchecked((((uint)(0x4D535331) & 0xFF) << 24) | (((uint)(0x4D535331) & 0xFF00) << 8) | (((uint)(0x4D535331) & 0xFF0000) >> 8) | (((uint)(0x4D535331) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MSS2" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MSS2Test()
        {
            Assert.That(MFVideoFormat_MSS2, Is.EqualTo(new Guid(unchecked((((uint)(0x4D535332) & 0xFF) << 24) | (((uint)(0x4D535332) & 0xFF00) << 8) | (((uint)(0x4D535332) & 0xFF0000) >> 8) | (((uint)(0x4D535332) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MPG1" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MPG1Test()
        {
            Assert.That(MFVideoFormat_MPG1, Is.EqualTo(new Guid(unchecked((((uint)(0x4D504731) & 0xFF) << 24) | (((uint)(0x4D504731) & 0xFF00) << 8) | (((uint)(0x4D504731) & 0xFF0000) >> 8) | (((uint)(0x4D504731) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_DVSL" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_DVSLTest()
        {
            Assert.That(MFVideoFormat_DVSL, Is.EqualTo(new Guid(unchecked((((uint)(0x6476736C) & 0xFF) << 24) | (((uint)(0x6476736C) & 0xFF00) << 8) | (((uint)(0x6476736C) & 0xFF0000) >> 8) | (((uint)(0x6476736C) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_DVSD" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_DVSDTest()
        {
            Assert.That(MFVideoFormat_DVSD, Is.EqualTo(new Guid(unchecked((((uint)(0x64767364) & 0xFF) << 24) | (((uint)(0x64767364) & 0xFF00) << 8) | (((uint)(0x64767364) & 0xFF0000) >> 8) | (((uint)(0x64767364) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_DVHD" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_DVHDTest()
        {
            Assert.That(MFVideoFormat_DVHD, Is.EqualTo(new Guid(unchecked((((uint)(0x64766864) & 0xFF) << 24) | (((uint)(0x64766864) & 0xFF00) << 8) | (((uint)(0x64766864) & 0xFF0000) >> 8) | (((uint)(0x64766864) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_DV25" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_DV25Test()
        {
            Assert.That(MFVideoFormat_DV25, Is.EqualTo(new Guid(unchecked((((uint)(0x64763235) & 0xFF) << 24) | (((uint)(0x64763235) & 0xFF00) << 8) | (((uint)(0x64763235) & 0xFF0000) >> 8) | (((uint)(0x64763235) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_DV50" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_DV50Test()
        {
            Assert.That(MFVideoFormat_DV50, Is.EqualTo(new Guid(unchecked((((uint)(0x64763530) & 0xFF) << 24) | (((uint)(0x64763530) & 0xFF00) << 8) | (((uint)(0x64763530) & 0xFF0000) >> 8) | (((uint)(0x64763530) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_DVH1" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_DVH1Test()
        {
            Assert.That(MFVideoFormat_DVH1, Is.EqualTo(new Guid(unchecked((((uint)(0x64766831) & 0xFF) << 24) | (((uint)(0x64766831) & 0xFF00) << 8) | (((uint)(0x64766831) & 0xFF0000) >> 8) | (((uint)(0x64766831) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_DVC" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_DVCTest()
        {
            Assert.That(MFVideoFormat_DVC, Is.EqualTo(new Guid(unchecked((((uint)(0x64766320) & 0xFF) << 24) | (((uint)(0x64766320) & 0xFF00) << 8) | (((uint)(0x64766320) & 0xFF0000) >> 8) | (((uint)(0x64766320) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_H264" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_H264Test()
        {
            Assert.That(MFVideoFormat_H264, Is.EqualTo(new Guid(unchecked((((uint)(0x48323634) & 0xFF) << 24) | (((uint)(0x48323634) & 0xFF00) << 8) | (((uint)(0x48323634) & 0xFF0000) >> 8) | (((uint)(0x48323634) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_H265" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_H265Test()
        {
            Assert.That(MFVideoFormat_H265, Is.EqualTo(new Guid(unchecked((((uint)(0x48323635) & 0xFF) << 24) | (((uint)(0x48323635) & 0xFF00) << 8) | (((uint)(0x48323635) & 0xFF0000) >> 8) | (((uint)(0x48323635) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MJPG" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MJPGTest()
        {
            Assert.That(MFVideoFormat_MJPG, Is.EqualTo(new Guid(unchecked((((uint)(0x4D4A5047) & 0xFF) << 24) | (((uint)(0x4D4A5047) & 0xFF00) << 8) | (((uint)(0x4D4A5047) & 0xFF0000) >> 8) | (((uint)(0x4D4A5047) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_420O" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_420OTest()
        {
            Assert.That(MFVideoFormat_420O, Is.EqualTo(new Guid(unchecked((((uint)(0x3432304F) & 0xFF) << 24) | (((uint)(0x3432304F) & 0xFF00) << 8) | (((uint)(0x3432304F) & 0xFF0000) >> 8) | (((uint)(0x3432304F) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_HEVC" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_HEVCTest()
        {
            Assert.That(MFVideoFormat_HEVC, Is.EqualTo(new Guid(unchecked((((uint)(0x48455643) & 0xFF) << 24) | (((uint)(0x48455643) & 0xFF00) << 8) | (((uint)(0x48455643) & 0xFF0000) >> 8) | (((uint)(0x48455643) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_HEVC_ES" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_HEVC_ESTest()
        {
            Assert.That(MFVideoFormat_HEVC_ES, Is.EqualTo(new Guid(unchecked((((uint)(0x48455653) & 0xFF) << 24) | (((uint)(0x48455653) & 0xFF00) << 8) | (((uint)(0x48455653) & 0xFF0000) >> 8) | (((uint)(0x48455653) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_VP80" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_VP80Test()
        {
            Assert.That(MFVideoFormat_VP80, Is.EqualTo(new Guid(unchecked((((uint)(0x56503830) & 0xFF) << 24) | (((uint)(0x56503830) & 0xFF00) << 8) | (((uint)(0x56503830) & 0xFF0000) >> 8) | (((uint)(0x56503830) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_VP90" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_VP90Test()
        {
            Assert.That(MFVideoFormat_VP90, Is.EqualTo(new Guid(unchecked((((uint)(0x56503930) & 0xFF) << 24) | (((uint)(0x56503930) & 0xFF00) << 8) | (((uint)(0x56503930) & 0xFF0000) >> 8) | (((uint)(0x56503930) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_ORAW" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_ORAWTest()
        {
            Assert.That(MFVideoFormat_ORAW, Is.EqualTo(new Guid(unchecked((((uint)(0x4F524157) & 0xFF) << 24) | (((uint)(0x4F524157) & 0xFF00) << 8) | (((uint)(0x4F524157) & 0xFF0000) >> 8) | (((uint)(0x4F524157) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_H263" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_H263Test()
        {
            Assert.That(MFVideoFormat_H263, Is.EqualTo(new Guid(unchecked((((uint)(0x48323633) & 0xFF) << 24) | (((uint)(0x48323633) & 0xFF00) << 8) | (((uint)(0x48323633) & 0xFF0000) >> 8) | (((uint)(0x48323633) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_A2R10G10B10" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_A2R10G10B10Test()
        {
            Assert.That(MFVideoFormat_A2R10G10B10, Is.EqualTo(new Guid(31, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_A16B16G16R16F" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_A16B16G16R16FTest()
        {
            Assert.That(MFVideoFormat_A16B16G16R16F, Is.EqualTo(new Guid(113, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_VP10" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_VP10Test()
        {
            Assert.That(MFVideoFormat_VP10, Is.EqualTo(new Guid(unchecked((((uint)(0x56503130) & 0xFF) << 24) | (((uint)(0x56503130) & 0xFF00) << 8) | (((uint)(0x56503130) & 0xFF0000) >> 8) | (((uint)(0x56503130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_AV1" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_AV1Test()
        {
            Assert.That(MFVideoFormat_AV1, Is.EqualTo(new Guid(unchecked((((uint)(0x41563031) & 0xFF) << 24) | (((uint)(0x41563031) & 0xFF00) << 8) | (((uint)(0x41563031) & 0xFF0000) >> 8) | (((uint)(0x41563031) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Theora" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_TheoraTest()
        {
            Assert.That(MFVideoFormat_Theora, Is.EqualTo(new Guid(unchecked((((uint)(0x7468656F) & 0xFF) << 24) | (((uint)(0x7468656F) & 0xFF00) << 8) | (((uint)(0x7468656F) & 0xFF0000) >> 8) | (((uint)(0x7468656F) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_H264_ES" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_H264_ESTest()
        {
            Assert.That(MFVideoFormat_H264_ES, Is.EqualTo(new Guid(0x3f40f4f0, 0x5622, 0x4ff8, 0xb6, 0xd8, 0xa1, 0x7a, 0x58, 0x4b, 0xee, 0x5e)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_MPEG2" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_MPEG2Test()
        {
            Assert.That(MFVideoFormat_MPEG2, Is.EqualTo(new Guid(0xe06d8026, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Base" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_BaseTest()
        {
            Assert.That(MFAudioFormat_Base, Is.EqualTo(new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_PCM" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_PCMTest()
        {
            Assert.That(MFAudioFormat_PCM, Is.EqualTo(new Guid(1, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Float" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_FloatTest()
        {
            Assert.That(MFAudioFormat_Float, Is.EqualTo(new Guid(0x0003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DTS" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DTSTest()
        {
            Assert.That(MFAudioFormat_DTS, Is.EqualTo(new Guid(0x0008, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC3_SPDIF" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC3_SPDIFTest()
        {
            Assert.That(MFAudioFormat_Dolby_AC3_SPDIF, Is.EqualTo(new Guid(0x0092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DRM" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DRMTest()
        {
            Assert.That(MFAudioFormat_DRM, Is.EqualTo(new Guid(0x0009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_WMAudioV8" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_WMAudioV8Test()
        {
            Assert.That(MFAudioFormat_WMAudioV8, Is.EqualTo(new Guid(0x0161, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_WMAudioV9" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_WMAudioV9Test()
        {
            Assert.That(MFAudioFormat_WMAudioV9, Is.EqualTo(new Guid(0x0162, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_WMAudio_Lossless" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_WMAudio_LosslessTest()
        {
            Assert.That(MFAudioFormat_WMAudio_Lossless, Is.EqualTo(new Guid(0x0163, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_WMASPDIF" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_WMASPDIFTest()
        {
            Assert.That(MFAudioFormat_WMASPDIF, Is.EqualTo(new Guid(0x0164, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_MSP1" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_MSP1Test()
        {
            Assert.That(MFAudioFormat_MSP1, Is.EqualTo(new Guid(0x000A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_MP3" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_MP3Test()
        {
            Assert.That(MFAudioFormat_MP3, Is.EqualTo(new Guid(0x0055, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_MPEG" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_MPEGTest()
        {
            Assert.That(MFAudioFormat_MPEG, Is.EqualTo(new Guid(0x0050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_AAC" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_AACTest()
        {
            Assert.That(MFAudioFormat_AAC, Is.EqualTo(new Guid(0x1610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_ADTS" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_ADTSTest()
        {
            Assert.That(MFAudioFormat_ADTS, Is.EqualTo(new Guid(0x1600, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_AMR_NB" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_AMR_NBTest()
        {
            Assert.That(MFAudioFormat_AMR_NB, Is.EqualTo(new Guid(0x7361, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_AMR_WB" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_AMR_WBTest()
        {
            Assert.That(MFAudioFormat_AMR_WB, Is.EqualTo(new Guid(0x7362, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_AMR_WP" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_AMR_WPTest()
        {
            Assert.That(MFAudioFormat_AMR_WP, Is.EqualTo(new Guid(0x7363, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_FLAC" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_FLACTest()
        {
            Assert.That(MFAudioFormat_FLAC, Is.EqualTo(new Guid(0xF1AC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_ALAC" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_ALACTest()
        {
            Assert.That(MFAudioFormat_ALAC, Is.EqualTo(new Guid(0x6C61, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Opus" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_OpusTest()
        {
            Assert.That(MFAudioFormat_Opus, Is.EqualTo(new Guid(0x704F, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC4" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC4Test()
        {
            Assert.That(MFAudioFormat_Dolby_AC4, Is.EqualTo(new Guid(0xAC40, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC3" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC3Test()
        {
            Assert.That(MFAudioFormat_Dolby_AC3, Is.EqualTo(new Guid(0xe06d802c, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_DDPlus" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_DDPlusTest()
        {
            Assert.That(MFAudioFormat_Dolby_DDPlus, Is.EqualTo(new Guid(0xa7fb87af, 0x2d02, 0x42fb, 0xa4, 0xd4, 0x5, 0xcd, 0x93, 0x84, 0x3b, 0xdd)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC4_V1" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC4_V1Test()
        {
            Assert.That(MFAudioFormat_Dolby_AC4_V1, Is.EqualTo(new Guid(0x36b7927c, 0x3d87, 0x4a2a, 0x91, 0x96, 0xa2, 0x1a, 0xd9, 0xe9, 0x35, 0xe6)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC4_V2" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC4_V2Test()
        {
            Assert.That(MFAudioFormat_Dolby_AC4_V2, Is.EqualTo(new Guid(0x7998b2a0, 0x17dd, 0x49b6, 0x8d, 0xfa, 0x9b, 0x27, 0x85, 0x52, 0xa2, 0xac)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC4_V1_ES" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC4_V1_ESTest()
        {
            Assert.That(MFAudioFormat_Dolby_AC4_V1_ES, Is.EqualTo(new Guid(0x9d8dccc6, 0xd156, 0x4fb8, 0x97, 0x9c, 0xa8, 0x5b, 0xe7, 0xd2, 0x1d, 0xfa)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC4_V2_ES" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC4_V2_ESTest()
        {
            Assert.That(MFAudioFormat_Dolby_AC4_V2_ES, Is.EqualTo(new Guid(0x7e58c9f9, 0xb070, 0x45f4, 0x8c, 0xcd, 0xa9, 0x9a, 0x04, 0x17, 0xc1, 0xac)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Vorbis" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_VorbisTest()
        {
            Assert.That(MFAudioFormat_Vorbis, Is.EqualTo(new Guid(0x8D2FD10B, 0x5841, 0x4a6b, 0x89, 0x05, 0x58, 0x8F, 0xEC, 0x1A, 0xDE, 0xD9)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DTS_RAW" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DTS_RAWTest()
        {
            Assert.That(MFAudioFormat_DTS_RAW, Is.EqualTo(new Guid(0xE06D8033, 0xDB46, 0x11CF, 0xB4, 0xD1, 0x00, 0x80, 0x5F, 0x6C, 0xBB, 0xEA)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DTS_HD" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DTS_HDTest()
        {
            Assert.That(MFAudioFormat_DTS_HD, Is.EqualTo(new Guid(0xA2E58EB7, 0x0FA9, 0x48BB, 0xA4, 0x0C, 0xFA, 0x0E, 0x15, 0x6D, 0x06, 0x45)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DTS_XLL" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DTS_XLLTest()
        {
            Assert.That(MFAudioFormat_DTS_XLL, Is.EqualTo(new Guid(0x45B37C1B, 0x8C70, 0x4E59, 0xA7, 0xBE, 0xA1, 0xE4, 0x2C, 0x81, 0xC8, 0x0D)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DTS_LBR" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DTS_LBRTest()
        {
            Assert.That(MFAudioFormat_DTS_LBR, Is.EqualTo(new Guid(0xC2FE6F0A, 0x4E3C, 0x4DF1, 0x9B, 0x60, 0x50, 0x86, 0x30, 0x91, 0xE4, 0xB9)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DTS_UHD" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DTS_UHDTest()
        {
            Assert.That(MFAudioFormat_DTS_UHD, Is.EqualTo(new Guid(0x87020117, 0xACE3, 0x42DE, 0xB7, 0x3E, 0xC6, 0x56, 0x70, 0x62, 0x63, 0xF8)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_DTS_UHDY" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_DTS_UHDYTest()
        {
            Assert.That(MFAudioFormat_DTS_UHDY, Is.EqualTo(new Guid(0x9B9CCA00, 0x91B9, 0x4CCC, 0x88, 0x3A, 0x8F, 0x78, 0x7A, 0xC3, 0xCC, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Float_SpatialObjects" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Float_SpatialObjectsTest()
        {
            Assert.That(MFAudioFormat_Float_SpatialObjects, Is.EqualTo(new Guid(0xfa39cd94, 0xbc64, 0x4ab1, 0x9b, 0x71, 0xdc, 0xd0, 0x9d, 0x5a, 0x7e, 0x7a)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_LPCM" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_LPCMTest()
        {
            Assert.That(MFAudioFormat_LPCM, Is.EqualTo(new Guid(0xe06d8032, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_PCM_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_PCM_HDCPTest()
        {
            Assert.That(MFAudioFormat_PCM_HDCP, Is.EqualTo(new Guid(0xa5e7ff01, 0x8411, 0x4acc, 0xa8, 0x65, 0x5f, 0x49, 0x41, 0x28, 0x8d, 0x80)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Dolby_AC3_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Dolby_AC3_HDCPTest()
        {
            Assert.That(MFAudioFormat_Dolby_AC3_HDCP, Is.EqualTo(new Guid(0x97663a80, 0x8ffb, 0x4445, 0xa6, 0xba, 0x79, 0x2d, 0x90, 0x8f, 0x49, 0x7f)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_AAC_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_AAC_HDCPTest()
        {
            Assert.That(MFAudioFormat_AAC_HDCP, Is.EqualTo(new Guid(0x419bce76, 0x8b72, 0x400f, 0xad, 0xeb, 0x84, 0xb5, 0x7d, 0x63, 0x48, 0x4d)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_ADTS_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_ADTS_HDCPTest()
        {
            Assert.That(MFAudioFormat_ADTS_HDCP, Is.EqualTo(new Guid(0xda4963a3, 0x14d8, 0x4dcf, 0x92, 0xb7, 0x19, 0x3e, 0xb8, 0x43, 0x63, 0xdb)));
        }

        /// <summary>Validates that the value of the <see cref="MFAudioFormat_Base_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFAudioFormat_Base_HDCPTest()
        {
            Assert.That(MFAudioFormat_Base_HDCP, Is.EqualTo(new Guid(0x3884b5bc, 0xe277, 0x43fd, 0x98, 0x3d, 0x03, 0x8a, 0xa8, 0xd9, 0xb6, 0x05)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_H264_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_H264_HDCPTest()
        {
            Assert.That(MFVideoFormat_H264_HDCP, Is.EqualTo(new Guid(0x5d0ce9dd, 0x9817, 0x49da, 0xbd, 0xfd, 0xf5, 0xf5, 0xb9, 0x8f, 0x18, 0xa6)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_HEVC_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_HEVC_HDCPTest()
        {
            Assert.That(MFVideoFormat_HEVC_HDCP, Is.EqualTo(new Guid(0x3cfe0fe6, 0x05c4, 0x47dc, 0x9d, 0x70, 0x4b, 0xdb, 0x29, 0x59, 0x72, 0x0f)));
        }

        /// <summary>Validates that the value of the <see cref="MFVideoFormat_Base_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFVideoFormat_Base_HDCPTest()
        {
            Assert.That(MFVideoFormat_Base_HDCP, Is.EqualTo(new Guid(0xeac3b9d5, 0xbd14, 0x4237, 0x8f, 0x1f, 0xba, 0xb4, 0x28, 0xe4, 0x93, 0x12)));
        }

        /// <summary>Validates that the value of the <see cref="MFMPEG4Format_Base" /> property is correct.</summary>
        [Test]
        public static void MFMPEG4Format_BaseTest()
        {
            Assert.That(MFMPEG4Format_Base, Is.EqualTo(new Guid(0x00000000, 0x767a, 0x494d, 0xb4, 0x78, 0xf2, 0x9d, 0x25, 0xdc, 0x90, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_XML" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_XMLTest()
        {
            Assert.That(MFSubtitleFormat_XML, Is.EqualTo(new Guid(0x2006f94f, 0x29ca, 0x4195, 0xb8, 0xdb, 0x00, 0xde, 0xd8, 0xff, 0x0c, 0x97)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_TTML" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_TTMLTest()
        {
            Assert.That(MFSubtitleFormat_TTML, Is.EqualTo(new Guid(0x73e73992, 0x9a10, 0x4356, 0x95, 0x57, 0x71, 0x94, 0xe9, 0x1e, 0x3e, 0x54)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_ATSC" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_ATSCTest()
        {
            Assert.That(MFSubtitleFormat_ATSC, Is.EqualTo(new Guid(0x7fa7faa3, 0xfeae, 0x4e16, 0xae, 0xdf, 0x36, 0xb9, 0xac, 0xfb, 0xb0, 0x99)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_WebVTT" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_WebVTTTest()
        {
            Assert.That(MFSubtitleFormat_WebVTT, Is.EqualTo(new Guid(0xc886d215, 0xf485, 0x40bb, 0x8d, 0xb6, 0xfa, 0xdb, 0xc6, 0x19, 0xa4, 0x5d)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_SRT" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_SRTTest()
        {
            Assert.That(MFSubtitleFormat_SRT, Is.EqualTo(new Guid(0x5e467f2e, 0x77ca, 0x4ca5, 0x83, 0x91, 0xd1, 0x42, 0xed, 0x4b, 0x76, 0xc8)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_SSA" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_SSATest()
        {
            Assert.That(MFSubtitleFormat_SSA, Is.EqualTo(new Guid(0x57176a1b, 0x1a9e, 0x4eea, 0xab, 0xef, 0xc6, 0x17, 0x60, 0x19, 0x8a, 0xc4)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_CustomUserData" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_CustomUserDataTest()
        {
            Assert.That(MFSubtitleFormat_CustomUserData, Is.EqualTo(new Guid(0x1bb3d849, 0x6614, 0x4d80, 0x88, 0x82, 0xed, 0x24, 0xaa, 0x82, 0xda, 0x92)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_PGS" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_PGSTest()
        {
            Assert.That(MFSubtitleFormat_PGS, Is.EqualTo(new Guid(0x71f40e4a, 0x1278, 0x4442, 0xb3, 0x0d, 0x39, 0xdd, 0x1d, 0x77, 0x22, 0xbc)));
        }

        /// <summary>Validates that the value of the <see cref="MFSubtitleFormat_VobSub" /> property is correct.</summary>
        [Test]
        public static void MFSubtitleFormat_VobSubTest()
        {
            Assert.That(MFSubtitleFormat_VobSub, Is.EqualTo(new Guid(0x6b8e40f4, 0x8d2c, 0x4ced, 0xad, 0x91, 0x59, 0x60, 0xe4, 0x5b, 0x44, 0x33)));
        }

        /// <summary>Validates that the value of the <see cref="MFBinaryFormat_Base" /> property is correct.</summary>
        [Test]
        public static void MFBinaryFormat_BaseTest()
        {
            Assert.That(MFBinaryFormat_Base, Is.EqualTo(new Guid(0x00000000, 0xbf10, 0x48b4, 0xbc, 0x18, 0x59, 0x3d, 0xc1, 0xdb, 0x95, 0xf)));
        }

        /// <summary>Validates that the value of the <see cref="MFBinaryFormat_GPMD" /> property is correct.</summary>
        [Test]
        public static void MFBinaryFormat_GPMDTest()
        {
            Assert.That(MFBinaryFormat_GPMD, Is.EqualTo(new Guid(0x67706D64, 0xbf10, 0x48b4, 0xbc, 0x18, 0x59, 0x3d, 0xc1, 0xdb, 0x95, 0xf)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MAJOR_TYPE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MAJOR_TYPETest()
        {
            Assert.That(MF_MT_MAJOR_TYPE, Is.EqualTo(new Guid(0x48eba18e, 0xf8c9, 0x4687, 0xbf, 0x11, 0x0a, 0x74, 0xc9, 0xf9, 0x6a, 0x8f)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SUBTYPE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SUBTYPETest()
        {
            Assert.That(MF_MT_SUBTYPE, Is.EqualTo(new Guid(0xf7e34c9a, 0x42e8, 0x4714, 0xb7, 0x4b, 0xcb, 0x29, 0xd7, 0x2c, 0x35, 0xe5)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_ALL_SAMPLES_INDEPENDENT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_ALL_SAMPLES_INDEPENDENTTest()
        {
            Assert.That(MF_MT_ALL_SAMPLES_INDEPENDENT, Is.EqualTo(new Guid(0xc9173739, 0x5e56, 0x461c, 0xb7, 0x13, 0x46, 0xfb, 0x99, 0x5c, 0xb9, 0x5f)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_FIXED_SIZE_SAMPLES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_FIXED_SIZE_SAMPLESTest()
        {
            Assert.That(MF_MT_FIXED_SIZE_SAMPLES, Is.EqualTo(new Guid(0xb8ebefaf, 0xb718, 0x4e04, 0xb0, 0xa9, 0x11, 0x67, 0x75, 0xe3, 0x32, 0x1b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_COMPRESSED" /> property is correct.</summary>
        [Test]
        public static void MF_MT_COMPRESSEDTest()
        {
            Assert.That(MF_MT_COMPRESSED, Is.EqualTo(new Guid(0x3afd0cee, 0x18f2, 0x4ba5, 0xa1, 0x10, 0x8b, 0xea, 0x50, 0x2e, 0x1f, 0x92)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SAMPLE_SIZE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SAMPLE_SIZETest()
        {
            Assert.That(MF_MT_SAMPLE_SIZE, Is.EqualTo(new Guid(0xdad3ab78, 0x1990, 0x408b, 0xbc, 0xe2, 0xeb, 0xa6, 0x73, 0xda, 0xcc, 0x10)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_WRAPPED_TYPE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_WRAPPED_TYPETest()
        {
            Assert.That(MF_MT_WRAPPED_TYPE, Is.EqualTo(new Guid(0x4d3f7b23, 0xd02f, 0x4e6c, 0x9b, 0xee, 0xe4, 0xbf, 0x2c, 0x6c, 0x69, 0x5d)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_3D" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_3DTest()
        {
            Assert.That(MF_MT_VIDEO_3D, Is.EqualTo(new Guid(0xcb5e88cf, 0x7b5b, 0x476b, 0x85, 0xaa, 0x1c, 0xa5, 0xae, 0x18, 0x75, 0x55)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_3D_FORMAT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_3D_FORMATTest()
        {
            Assert.That(MF_MT_VIDEO_3D_FORMAT, Is.EqualTo(new Guid(0x5315d8a0, 0x87c5, 0x4697, 0xb7, 0x93, 0x66, 0x6, 0xc6, 0x7c, 0x4, 0x9b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_3D_NUM_VIEWS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_3D_NUM_VIEWSTest()
        {
            Assert.That(MF_MT_VIDEO_3D_NUM_VIEWS, Is.EqualTo(new Guid(0xbb077e8a, 0xdcbf, 0x42eb, 0xaf, 0x60, 0x41, 0x8d, 0xf9, 0x8a, 0xa4, 0x95)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_3D_LEFT_IS_BASE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_3D_LEFT_IS_BASETest()
        {
            Assert.That(MF_MT_VIDEO_3D_LEFT_IS_BASE, Is.EqualTo(new Guid(0x6d4b7bff, 0x5629, 0x4404, 0x94, 0x8c, 0xc6, 0x34, 0xf4, 0xce, 0x26, 0xd4)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_3D_FIRST_IS_LEFT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_3D_FIRST_IS_LEFTTest()
        {
            Assert.That(MF_MT_VIDEO_3D_FIRST_IS_LEFT, Is.EqualTo(new Guid(0xec298493, 0xada, 0x4ea1, 0xa4, 0xfe, 0xcb, 0xbd, 0x36, 0xce, 0x93, 0x31)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_3DVideo" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_3DVideoTest()
        {
            Assert.That(MFSampleExtension_3DVideo, Is.EqualTo(new Guid(0xf86f97a4, 0xdd54, 0x4e2e, 0x9a, 0x5e, 0x55, 0xfc, 0x2d, 0x74, 0xa0, 0x05)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_3DVideo_SampleFormat" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_3DVideo_SampleFormatTest()
        {
            Assert.That(MFSampleExtension_3DVideo_SampleFormat, Is.EqualTo(new Guid(0x8671772, 0xe36f, 0x4cff, 0x97, 0xb3, 0xd7, 0x2e, 0x20, 0x98, 0x7a, 0x48)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_ROTATION" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_ROTATIONTest()
        {
            Assert.That(MF_MT_VIDEO_ROTATION, Is.EqualTo(new Guid(0xc380465d, 0x2271, 0x428c, 0x9b, 0x83, 0xec, 0xea, 0x3b, 0x4a, 0x85, 0xc1)));
        }

        /// <summary>Validates that the value of the <see cref="MF_DEVICESTREAM_MULTIPLEXED_MANAGER" /> property is correct.</summary>
        [Test]
        public static void MF_DEVICESTREAM_MULTIPLEXED_MANAGERTest()
        {
            Assert.That(MF_DEVICESTREAM_MULTIPLEXED_MANAGER, Is.EqualTo(new Guid(0x6ea542b0, 0x281f, 0x4231, 0xa4, 0x64, 0xfe, 0x2f, 0x50, 0x22, 0x50, 0x1c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MEDIATYPE_MULTIPLEXED_MANAGER" /> property is correct.</summary>
        [Test]
        public static void MF_MEDIATYPE_MULTIPLEXED_MANAGERTest()
        {
            Assert.That(MF_MEDIATYPE_MULTIPLEXED_MANAGER, Is.EqualTo(new Guid(0x13c78fb5, 0xf275, 0x4ea0, 0xbb, 0x5f, 0x2, 0x49, 0x83, 0x2b, 0xd, 0x6e)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_MULTIPLEXED_MANAGER" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_MULTIPLEXED_MANAGERTest()
        {
            Assert.That(MFSampleExtension_MULTIPLEXED_MANAGER, Is.EqualTo(new Guid(0x8dcdee79, 0x6b5a, 0x4c45, 0x8d, 0xb9, 0x20, 0xb3, 0x95, 0xf0, 0x2f, 0xcf)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SECURE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SECURETest()
        {
            Assert.That(MF_MT_SECURE, Is.EqualTo(new Guid(0xc5acc4fd, 0x0304, 0x4ecf, 0x80, 0x9f, 0x47, 0xbc, 0x97, 0xff, 0x63, 0xbd)));
        }

        /// <summary>Validates that the value of the <see cref="MF_DEVICESTREAM_ATTRIBUTE_FRAMESOURCE_TYPES" /> property is correct.</summary>
        [Test]
        public static void MF_DEVICESTREAM_ATTRIBUTE_FRAMESOURCE_TYPESTest()
        {
            Assert.That(MF_DEVICESTREAM_ATTRIBUTE_FRAMESOURCE_TYPES, Is.EqualTo(new Guid(0x17145fd1, 0x1b2b, 0x423c, 0x80, 0x1, 0x2b, 0x68, 0x33, 0xed, 0x35, 0x88)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_ALPHA_MODE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_ALPHA_MODETest()
        {
            Assert.That(MF_MT_ALPHA_MODE, Is.EqualTo(new Guid(0x5D959B0D, 0x4CBF, 0x4D04, 0x91, 0x9F, 0x3F, 0x5F, 0x7F, 0x28, 0x42, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DEPTH_MEASUREMENT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DEPTH_MEASUREMENTTest()
        {
            Assert.That(MF_MT_DEPTH_MEASUREMENT, Is.EqualTo(new Guid(0xfd5ac489, 0x917, 0x4bb6, 0x9d, 0x54, 0x31, 0x22, 0xbf, 0x70, 0x14, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DEPTH_VALUE_UNIT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DEPTH_VALUE_UNITTest()
        {
            Assert.That(MF_MT_DEPTH_VALUE_UNIT, Is.EqualTo(new Guid(0x21a800f5, 0x3189, 0x4797, 0xbe, 0xba, 0xf1, 0x3c, 0xd9, 0xa3, 0x1a, 0x5e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_NO_FRAME_ORDERING" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_NO_FRAME_ORDERINGTest()
        {
            Assert.That(MF_MT_VIDEO_NO_FRAME_ORDERING, Is.EqualTo(new Guid(0x3f5b106f, 0x6bc2, 0x4ee3, 0xb7, 0xed, 0x89, 0x2, 0xc1, 0x8f, 0x53, 0x51)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_H264_NO_FMOASO" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_H264_NO_FMOASOTest()
        {
            Assert.That(MF_MT_VIDEO_H264_NO_FMOASO, Is.EqualTo(new Guid(0xed461cd6, 0xec9f, 0x416a, 0xa8, 0xa3, 0x26, 0xd7, 0xd3, 0x10, 0x18, 0xd7)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_ForwardedDecodeUnits" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_ForwardedDecodeUnitsTest()
        {
            Assert.That(MFSampleExtension_ForwardedDecodeUnits, Is.EqualTo(new Guid(0x424c754c, 0x97c8, 0x48d6, 0x87, 0x77, 0xfc, 0x41, 0xf7, 0xb6, 0x8, 0x79)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_TargetGlobalLuminance" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_TargetGlobalLuminanceTest()
        {
            Assert.That(MFSampleExtension_TargetGlobalLuminance, Is.EqualTo(new Guid(0x3f60ef36, 0x31ef, 0x4daf, 0x83, 0x60, 0x94, 0x3, 0x97, 0xe4, 0x1e, 0xf3)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_ForwardedDecodeUnitType" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_ForwardedDecodeUnitTypeTest()
        {
            Assert.That(MFSampleExtension_ForwardedDecodeUnitType, Is.EqualTo(new Guid(0x89e57c7, 0x47d3, 0x4a26, 0xbf, 0x9c, 0x4b, 0x64, 0xfa, 0xfb, 0x5d, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_FORWARD_CUSTOM_NALU" /> property is correct.</summary>
        [Test]
        public static void MF_MT_FORWARD_CUSTOM_NALUTest()
        {
            Assert.That(MF_MT_FORWARD_CUSTOM_NALU, Is.EqualTo(new Guid(0xed336efd, 0x244f, 0x428d, 0x91, 0x53, 0x28, 0xf3, 0x99, 0x45, 0x88, 0x90)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_FORWARD_CUSTOM_SEI" /> property is correct.</summary>
        [Test]
        public static void MF_MT_FORWARD_CUSTOM_SEITest()
        {
            Assert.That(MF_MT_FORWARD_CUSTOM_SEI, Is.EqualTo(new Guid(0xe27362f1, 0xb136, 0x41d1, 0x95, 0x94, 0x3a, 0x7e, 0x4f, 0xeb, 0xf2, 0xd1)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_RENDERER_EXTENSION_PROFILE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_RENDERER_EXTENSION_PROFILETest()
        {
            Assert.That(MF_MT_VIDEO_RENDERER_EXTENSION_PROFILE, Is.EqualTo(new Guid(0x8437d4b9, 0xd448, 0x4fcd, 0x9b, 0x6b, 0x83, 0x9b, 0xf9, 0x6c, 0x77, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MF_DECODER_FWD_CUSTOM_SEI_DECODE_ORDER" /> property is correct.</summary>
        [Test]
        public static void MF_DECODER_FWD_CUSTOM_SEI_DECODE_ORDERTest()
        {
            Assert.That(MF_DECODER_FWD_CUSTOM_SEI_DECODE_ORDER, Is.EqualTo(new Guid(0xf13bbe3c, 0x36d4, 0x410a, 0xb9, 0x85, 0x7a, 0x95, 0x1a, 0x1e, 0x62, 0x94)));
        }

        /// <summary>Validates that the value of the <see cref="MF_VIDEO_RENDERER_EFFECT_APP_SERVICE_NAME" /> property is correct.</summary>
        [Test]
        public static void MF_VIDEO_RENDERER_EFFECT_APP_SERVICE_NAMETest()
        {
            Assert.That(MF_VIDEO_RENDERER_EFFECT_APP_SERVICE_NAME, Is.EqualTo(new Guid(0xc6052a80, 0x6d9c, 0x40a3, 0x9d, 0xb8, 0xf0, 0x27, 0xa2, 0x5c, 0x9a, 0xb9)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_NUM_CHANNELS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_NUM_CHANNELSTest()
        {
            Assert.That(MF_MT_AUDIO_NUM_CHANNELS, Is.EqualTo(new Guid(0x37e48bf5, 0x645e, 0x4c5b, 0x89, 0xde, 0xad, 0xa9, 0xe2, 0x9b, 0x69, 0x6a)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_SAMPLES_PER_SECOND" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_SAMPLES_PER_SECONDTest()
        {
            Assert.That(MF_MT_AUDIO_SAMPLES_PER_SECOND, Is.EqualTo(new Guid(0x5faeeae7, 0x0290, 0x4c31, 0x9e, 0x8a, 0xc5, 0x34, 0xf6, 0x8d, 0x9d, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECOND" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECONDTest()
        {
            Assert.That(MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECOND, Is.EqualTo(new Guid(0xfb3b724a, 0xcfb5, 0x4319, 0xae, 0xfe, 0x6e, 0x42, 0xb2, 0x40, 0x61, 0x32)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_AVG_BYTES_PER_SECOND" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_AVG_BYTES_PER_SECONDTest()
        {
            Assert.That(MF_MT_AUDIO_AVG_BYTES_PER_SECOND, Is.EqualTo(new Guid(0x1aab75c8, 0xcfef, 0x451c, 0xab, 0x95, 0xac, 0x03, 0x4b, 0x8e, 0x17, 0x31)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_BLOCK_ALIGNMENT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_BLOCK_ALIGNMENTTest()
        {
            Assert.That(MF_MT_AUDIO_BLOCK_ALIGNMENT, Is.EqualTo(new Guid(0x322de230, 0x9eeb, 0x43bd, 0xab, 0x7a, 0xff, 0x41, 0x22, 0x51, 0x54, 0x1d)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_BITS_PER_SAMPLE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_BITS_PER_SAMPLETest()
        {
            Assert.That(MF_MT_AUDIO_BITS_PER_SAMPLE, Is.EqualTo(new Guid(0xf2deb57f, 0x40fa, 0x4764, 0xaa, 0x33, 0xed, 0x4f, 0x2d, 0x1f, 0xf6, 0x69)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_VALID_BITS_PER_SAMPLE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_VALID_BITS_PER_SAMPLETest()
        {
            Assert.That(MF_MT_AUDIO_VALID_BITS_PER_SAMPLE, Is.EqualTo(new Guid(0xd9bf8d6a, 0x9530, 0x4b7c, 0x9d, 0xdf, 0xff, 0x6f, 0xd5, 0x8b, 0xbd, 0x06)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_SAMPLES_PER_BLOCK" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_SAMPLES_PER_BLOCKTest()
        {
            Assert.That(MF_MT_AUDIO_SAMPLES_PER_BLOCK, Is.EqualTo(new Guid(0xaab15aac, 0xe13a, 0x4995, 0x92, 0x22, 0x50, 0x1e, 0xa1, 0x5c, 0x68, 0x77)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_CHANNEL_MASK" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_CHANNEL_MASKTest()
        {
            Assert.That(MF_MT_AUDIO_CHANNEL_MASK, Is.EqualTo(new Guid(0x55fb5765, 0x644a, 0x4caf, 0x84, 0x79, 0x93, 0x89, 0x83, 0xbb, 0x15, 0x88)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_FOLDDOWN_MATRIX" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_FOLDDOWN_MATRIXTest()
        {
            Assert.That(MF_MT_AUDIO_FOLDDOWN_MATRIX, Is.EqualTo(new Guid(0x9d62927c, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_WMADRC_PEAKREF" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_WMADRC_PEAKREFTest()
        {
            Assert.That(MF_MT_AUDIO_WMADRC_PEAKREF, Is.EqualTo(new Guid(0x9d62927d, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_WMADRC_PEAKTARGET" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_WMADRC_PEAKTARGETTest()
        {
            Assert.That(MF_MT_AUDIO_WMADRC_PEAKTARGET, Is.EqualTo(new Guid(0x9d62927e, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_WMADRC_AVGREF" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_WMADRC_AVGREFTest()
        {
            Assert.That(MF_MT_AUDIO_WMADRC_AVGREF, Is.EqualTo(new Guid(0x9d62927f, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_WMADRC_AVGTARGET" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_WMADRC_AVGTARGETTest()
        {
            Assert.That(MF_MT_AUDIO_WMADRC_AVGTARGET, Is.EqualTo(new Guid(0x9d629280, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_PREFER_WAVEFORMATEX" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_PREFER_WAVEFORMATEXTest()
        {
            Assert.That(MF_MT_AUDIO_PREFER_WAVEFORMATEX, Is.EqualTo(new Guid(0xa901aaba, 0xe037, 0x458a, 0xbd, 0xf6, 0x54, 0x5b, 0xe2, 0x07, 0x40, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AAC_PAYLOAD_TYPE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AAC_PAYLOAD_TYPETest()
        {
            Assert.That(MF_MT_AAC_PAYLOAD_TYPE, Is.EqualTo(new Guid(0xbfbabe79, 0x7434, 0x4d1c, 0x94, 0xf0, 0x72, 0xa3, 0xb9, 0xe1, 0x71, 0x88)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATIONTest()
        {
            Assert.That(MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION, Is.EqualTo(new Guid(0x7632f0e6, 0x9538, 0x4d61, 0xac, 0xda, 0xea, 0x29, 0xc8, 0xc1, 0x44, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AUDIO_FLAC_MAX_BLOCK_SIZE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AUDIO_FLAC_MAX_BLOCK_SIZETest()
        {
            Assert.That(MF_MT_AUDIO_FLAC_MAX_BLOCK_SIZE, Is.EqualTo(new Guid(0x8b81adae, 0x4b5a, 0x4d40, 0x80, 0x22, 0xf3, 0x8d, 0x9, 0xca, 0x3c, 0x5c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SPATIAL_AUDIO_MAX_DYNAMIC_OBJECTS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SPATIAL_AUDIO_MAX_DYNAMIC_OBJECTSTest()
        {
            Assert.That(MF_MT_SPATIAL_AUDIO_MAX_DYNAMIC_OBJECTS, Is.EqualTo(new Guid(0xdcfba24a, 0x2609, 0x4240, 0xa7, 0x21, 0x3f, 0xae, 0xa7, 0x6a, 0x4d, 0xf9)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_FORMAT_ID" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_FORMAT_IDTest()
        {
            Assert.That(MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_FORMAT_ID, Is.EqualTo(new Guid(0x2ab71bc0, 0x6223, 0x4ba7, 0xad, 0x64, 0x7b, 0x94, 0xb4, 0x7a, 0xe7, 0x92)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_LENGTH" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_LENGTHTest()
        {
            Assert.That(MF_MT_SPATIAL_AUDIO_OBJECT_METADATA_LENGTH, Is.EqualTo(new Guid(0x94ba8be, 0xd723, 0x489f, 0x92, 0xfa, 0x76, 0x67, 0x77, 0xb3, 0x47, 0x26)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SPATIAL_AUDIO_MAX_METADATA_ITEMS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SPATIAL_AUDIO_MAX_METADATA_ITEMSTest()
        {
            Assert.That(MF_MT_SPATIAL_AUDIO_MAX_METADATA_ITEMS, Is.EqualTo(new Guid(0x11aa80b4, 0xe0da, 0x47c6, 0x80, 0x60, 0x96, 0xc1, 0x25, 0x9a, 0xe5, 0xd)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SPATIAL_AUDIO_MIN_METADATA_ITEM_OFFSET_SPACING" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SPATIAL_AUDIO_MIN_METADATA_ITEM_OFFSET_SPACINGTest()
        {
            Assert.That(MF_MT_SPATIAL_AUDIO_MIN_METADATA_ITEM_OFFSET_SPACING, Is.EqualTo(new Guid(0x83e96ec9, 0x1184, 0x417e, 0x82, 0x54, 0x9f, 0x26, 0x91, 0x58, 0xfc, 0x6)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SPATIAL_AUDIO_DATA_PRESENT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SPATIAL_AUDIO_DATA_PRESENTTest()
        {
            Assert.That(MF_MT_SPATIAL_AUDIO_DATA_PRESENT, Is.EqualTo(new Guid(0x6842f6e7, 0xd43e, 0x4ebb, 0x9c, 0x9c, 0xc9, 0x6f, 0x41, 0x78, 0x48, 0x63)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_FRAME_SIZE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_FRAME_SIZETest()
        {
            Assert.That(MF_MT_FRAME_SIZE, Is.EqualTo(new Guid(0x1652c33d, 0xd6b2, 0x4012, 0xb8, 0x34, 0x72, 0x03, 0x08, 0x49, 0xa3, 0x7d)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_FRAME_RATE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_FRAME_RATETest()
        {
            Assert.That(MF_MT_FRAME_RATE, Is.EqualTo(new Guid(0xc459a2e8, 0x3d2c, 0x4e44, 0xb1, 0x32, 0xfe, 0xe5, 0x15, 0x6c, 0x7b, 0xb0)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_PIXEL_ASPECT_RATIO" /> property is correct.</summary>
        [Test]
        public static void MF_MT_PIXEL_ASPECT_RATIOTest()
        {
            Assert.That(MF_MT_PIXEL_ASPECT_RATIO, Is.EqualTo(new Guid(0xc6376a1e, 0x8d0a, 0x4027, 0xbe, 0x45, 0x6d, 0x9a, 0x0a, 0xd3, 0x9b, 0xb6)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DRM_FLAGS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DRM_FLAGSTest()
        {
            Assert.That(MF_MT_DRM_FLAGS, Is.EqualTo(new Guid(0x8772f323, 0x355a, 0x4cc7, 0xbb, 0x78, 0x6d, 0x61, 0xa0, 0x48, 0xae, 0x82)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_TIMESTAMP_CAN_BE_DTS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_TIMESTAMP_CAN_BE_DTSTest()
        {
            Assert.That(MF_MT_TIMESTAMP_CAN_BE_DTS, Is.EqualTo(new Guid(0x24974215, 0x1b7b, 0x41e4, 0x86, 0x25, 0xac, 0x46, 0x9f, 0x2d, 0xed, 0xaa)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_PAD_CONTROL_FLAGS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_PAD_CONTROL_FLAGSTest()
        {
            Assert.That(MF_MT_PAD_CONTROL_FLAGS, Is.EqualTo(new Guid(0x4d0e73e5, 0x80ea, 0x4354, 0xa9, 0xd0, 0x11, 0x76, 0xce, 0xb0, 0x28, 0xea)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_SOURCE_CONTENT_HINT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_SOURCE_CONTENT_HINTTest()
        {
            Assert.That(MF_MT_SOURCE_CONTENT_HINT, Is.EqualTo(new Guid(0x68aca3cc, 0x22d0, 0x44e6, 0x85, 0xf8, 0x28, 0x16, 0x71, 0x97, 0xfa, 0x38)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_CHROMA_SITING" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_CHROMA_SITINGTest()
        {
            Assert.That(MF_MT_VIDEO_CHROMA_SITING, Is.EqualTo(new Guid(0x65df2370, 0xc773, 0x4c33, 0xaa, 0x64, 0x84, 0x3e, 0x06, 0x8e, 0xfb, 0x0c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_INTERLACE_MODE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_INTERLACE_MODETest()
        {
            Assert.That(MF_MT_INTERLACE_MODE, Is.EqualTo(new Guid(0xe2724bb8, 0xe676, 0x4806, 0xb4, 0xb2, 0xa8, 0xd6, 0xef, 0xb4, 0x4c, 0xcd)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_TRANSFER_FUNCTION" /> property is correct.</summary>
        [Test]
        public static void MF_MT_TRANSFER_FUNCTIONTest()
        {
            Assert.That(MF_MT_TRANSFER_FUNCTION, Is.EqualTo(new Guid(0x5fb0fce9, 0xbe5c, 0x4935, 0xa8, 0x11, 0xec, 0x83, 0x8f, 0x8e, 0xed, 0x93)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_PRIMARIES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_PRIMARIESTest()
        {
            Assert.That(MF_MT_VIDEO_PRIMARIES, Is.EqualTo(new Guid(0xdbfbe4d7, 0x0740, 0x4ee0, 0x81, 0x92, 0x85, 0x0a, 0xb0, 0xe2, 0x19, 0x35)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MAX_LUMINANCE_LEVEL" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MAX_LUMINANCE_LEVELTest()
        {
            Assert.That(MF_MT_MAX_LUMINANCE_LEVEL, Is.EqualTo(new Guid(0x50253128, 0xc110, 0x4de4, 0x98, 0xae, 0x46, 0xa3, 0x24, 0xfa, 0xe6, 0xda)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MAX_FRAME_AVERAGE_LUMINANCE_LEVEL" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MAX_FRAME_AVERAGE_LUMINANCE_LEVELTest()
        {
            Assert.That(MF_MT_MAX_FRAME_AVERAGE_LUMINANCE_LEVEL, Is.EqualTo(new Guid(0x58d4bf57, 0x6f52, 0x4733, 0xa1, 0x95, 0xa9, 0xe2, 0x9e, 0xcf, 0x9e, 0x27)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MAX_MASTERING_LUMINANCE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MAX_MASTERING_LUMINANCETest()
        {
            Assert.That(MF_MT_MAX_MASTERING_LUMINANCE, Is.EqualTo(new Guid(0xd6c6b997, 0x272f, 0x4ca1, 0x8d, 0x0, 0x80, 0x42, 0x11, 0x1a, 0xf, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MIN_MASTERING_LUMINANCE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MIN_MASTERING_LUMINANCETest()
        {
            Assert.That(MF_MT_MIN_MASTERING_LUMINANCE, Is.EqualTo(new Guid(0x839a4460, 0x4e7e, 0x4b4f, 0xae, 0x79, 0xcc, 0x8, 0x90, 0x5c, 0x7b, 0x27)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DECODER_USE_MAX_RESOLUTION" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DECODER_USE_MAX_RESOLUTIONTest()
        {
            Assert.That(MF_MT_DECODER_USE_MAX_RESOLUTION, Is.EqualTo(new Guid(0x4c547c24, 0xaf9a, 0x4f38, 0x96, 0xad, 0x97, 0x87, 0x73, 0xcf, 0x53, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DECODER_MAX_DPB_COUNT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DECODER_MAX_DPB_COUNTTest()
        {
            Assert.That(MF_MT_DECODER_MAX_DPB_COUNT, Is.EqualTo(new Guid(0x67be144c, 0x88b7, 0x4ca9, 0x96, 0x28, 0xc8, 0x8, 0xd5, 0x26, 0x22, 0x17)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_CUSTOM_VIDEO_PRIMARIES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_CUSTOM_VIDEO_PRIMARIESTest()
        {
            Assert.That(MF_MT_CUSTOM_VIDEO_PRIMARIES, Is.EqualTo(new Guid(0x47537213, 0x8cfb, 0x4722, 0xaa, 0x34, 0xfb, 0xc9, 0xe2, 0x4d, 0x77, 0xb8)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_YUV_MATRIX" /> property is correct.</summary>
        [Test]
        public static void MF_MT_YUV_MATRIXTest()
        {
            Assert.That(MF_MT_YUV_MATRIX, Is.EqualTo(new Guid(0x3e23d450, 0x2c75, 0x4d25, 0xa0, 0x0e, 0xb9, 0x16, 0x70, 0xd1, 0x23, 0x27)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_LIGHTING" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_LIGHTINGTest()
        {
            Assert.That(MF_MT_VIDEO_LIGHTING, Is.EqualTo(new Guid(0x53a0529c, 0x890b, 0x4216, 0x8b, 0xf9, 0x59, 0x93, 0x67, 0xad, 0x6d, 0x20)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_NOMINAL_RANGE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_NOMINAL_RANGETest()
        {
            Assert.That(MF_MT_VIDEO_NOMINAL_RANGE, Is.EqualTo(new Guid(0xc21b8ee5, 0xb956, 0x4071, 0x8d, 0xaf, 0x32, 0x5e, 0xdf, 0x5c, 0xab, 0x11)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_GEOMETRIC_APERTURE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_GEOMETRIC_APERTURETest()
        {
            Assert.That(MF_MT_GEOMETRIC_APERTURE, Is.EqualTo(new Guid(0x66758743, 0x7e5f, 0x400d, 0x98, 0x0a, 0xaa, 0x85, 0x96, 0xc8, 0x56, 0x96)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MINIMUM_DISPLAY_APERTURE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MINIMUM_DISPLAY_APERTURETest()
        {
            Assert.That(MF_MT_MINIMUM_DISPLAY_APERTURE, Is.EqualTo(new Guid(0xd7388766, 0x18fe, 0x48c6, 0xa1, 0x77, 0xee, 0x89, 0x48, 0x67, 0xc8, 0xc4)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_PAN_SCAN_APERTURE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_PAN_SCAN_APERTURETest()
        {
            Assert.That(MF_MT_PAN_SCAN_APERTURE, Is.EqualTo(new Guid(0x79614dde, 0x9187, 0x48fb, 0xb8, 0xc7, 0x4d, 0x52, 0x68, 0x9d, 0xe6, 0x49)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_PAN_SCAN_ENABLED" /> property is correct.</summary>
        [Test]
        public static void MF_MT_PAN_SCAN_ENABLEDTest()
        {
            Assert.That(MF_MT_PAN_SCAN_ENABLED, Is.EqualTo(new Guid(0x4b7f6bc3, 0x8b13, 0x40b2, 0xa9, 0x93, 0xab, 0xf6, 0x30, 0xb8, 0x20, 0x4e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AVG_BITRATE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AVG_BITRATETest()
        {
            Assert.That(MF_MT_AVG_BITRATE, Is.EqualTo(new Guid(0x20332624, 0xfb0d, 0x4d9e, 0xbd, 0x0d, 0xcb, 0xf6, 0x78, 0x6c, 0x10, 0x2e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AVG_BIT_ERROR_RATE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AVG_BIT_ERROR_RATETest()
        {
            Assert.That(MF_MT_AVG_BIT_ERROR_RATE, Is.EqualTo(new Guid(0x799cabd6, 0x3508, 0x4db4, 0xa3, 0xc7, 0x56, 0x9c, 0xd5, 0x33, 0xde, 0xb1)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MAX_KEYFRAME_SPACING" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MAX_KEYFRAME_SPACINGTest()
        {
            Assert.That(MF_MT_MAX_KEYFRAME_SPACING, Is.EqualTo(new Guid(0xc16eb52b, 0x73a1, 0x476f, 0x8d, 0x62, 0x83, 0x9d, 0x6a, 0x02, 0x06, 0x52)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_USER_DATA" /> property is correct.</summary>
        [Test]
        public static void MF_MT_USER_DATATest()
        {
            Assert.That(MF_MT_USER_DATA, Is.EqualTo(new Guid(0xb6bc765f, 0x4c3b, 0x40a4, 0xbd, 0x51, 0x25, 0x35, 0xb6, 0x6f, 0xe0, 0x9d)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_OUTPUT_BUFFER_NUM" /> property is correct.</summary>
        [Test]
        public static void MF_MT_OUTPUT_BUFFER_NUMTest()
        {
            Assert.That(MF_MT_OUTPUT_BUFFER_NUM, Is.EqualTo(new Guid(0xa505d3ac, 0xf930, 0x436e, 0x8e, 0xde, 0x93, 0xa5, 0x09, 0xce, 0x23, 0xb2)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_REALTIME_CONTENT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_REALTIME_CONTENTTest()
        {
            Assert.That(MF_MT_REALTIME_CONTENT, Is.EqualTo(new Guid(0xbb12d222, 0x2bdb, 0x425e, 0x91, 0xec, 0x23, 0x08, 0xe1, 0x89, 0xa5, 0x8f)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DEFAULT_STRIDE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DEFAULT_STRIDETest()
        {
            Assert.That(MF_MT_DEFAULT_STRIDE, Is.EqualTo(new Guid(0x644b4e48, 0x1e02, 0x4516, 0xb0, 0xeb, 0xc0, 0x1c, 0xa9, 0xd4, 0x9a, 0xc6)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_PALETTE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_PALETTETest()
        {
            Assert.That(MF_MT_PALETTE, Is.EqualTo(new Guid(0x6d283f42, 0x9846, 0x4410, 0xaf, 0xd9, 0x65, 0x4d, 0x50, 0x3b, 0x1a, 0x54)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_AM_FORMAT_TYPE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_AM_FORMAT_TYPETest()
        {
            Assert.That(MF_MT_AM_FORMAT_TYPE, Is.EqualTo(new Guid(0x73d1072d, 0x1870, 0x4174, 0xa0, 0x63, 0x29, 0xff, 0x4f, 0xf6, 0xc1, 0x1e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_PROFILE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_PROFILETest()
        {
            Assert.That(MF_MT_VIDEO_PROFILE, Is.EqualTo(new Guid(0xad76a80b, 0x2d5c, 0x4e0b, 0xb3, 0x75, 0x64, 0xe5, 0x20, 0x13, 0x70, 0x36)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_VIDEO_LEVEL" /> property is correct.</summary>
        [Test]
        public static void MF_MT_VIDEO_LEVELTest()
        {
            Assert.That(MF_MT_VIDEO_LEVEL, Is.EqualTo(new Guid(0x96f66574, 0x11c5, 0x4015, 0x86, 0x66, 0xbf, 0xf5, 0x16, 0x43, 0x6d, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG_START_TIME_CODE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG_START_TIME_CODETest()
        {
            Assert.That(MF_MT_MPEG_START_TIME_CODE, Is.EqualTo(new Guid(0x91f67885, 0x4333, 0x4280, 0x97, 0xcd, 0xbd, 0x5a, 0x6c, 0x03, 0xa0, 0x6e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_PROFILE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_PROFILETest()
        {
            Assert.That(MF_MT_MPEG2_PROFILE, Is.EqualTo(new Guid(0xad76a80b, 0x2d5c, 0x4e0b, 0xb3, 0x75, 0x64, 0xe5, 0x20, 0x13, 0x70, 0x36)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_LEVEL" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_LEVELTest()
        {
            Assert.That(MF_MT_MPEG2_LEVEL, Is.EqualTo(new Guid(0x96f66574, 0x11c5, 0x4015, 0x86, 0x66, 0xbf, 0xf5, 0x16, 0x43, 0x6d, 0xa7)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_FLAGS" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_FLAGSTest()
        {
            Assert.That(MF_MT_MPEG2_FLAGS, Is.EqualTo(new Guid(0x31e3991d, 0xf701, 0x4b2f, 0xb4, 0x26, 0x8a, 0xe3, 0xbd, 0xa9, 0xe0, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG_SEQUENCE_HEADER" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG_SEQUENCE_HEADERTest()
        {
            Assert.That(MF_MT_MPEG_SEQUENCE_HEADER, Is.EqualTo(new Guid(0x3c036de7, 0x3ad0, 0x4c9e, 0x92, 0x16, 0xee, 0x6d, 0x6a, 0xc2, 0x1c, 0xb3)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_STANDARD" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_STANDARDTest()
        {
            Assert.That(MF_MT_MPEG2_STANDARD, Is.EqualTo(new Guid(0xa20af9e8, 0x928a, 0x4b26, 0xaa, 0xa9, 0xf0, 0x5c, 0x74, 0xca, 0xc4, 0x7c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_TIMECODE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_TIMECODETest()
        {
            Assert.That(MF_MT_MPEG2_TIMECODE, Is.EqualTo(new Guid(0x5229ba10, 0xe29d, 0x4f80, 0xa5, 0x9c, 0xdf, 0x4f, 0x18, 0x2, 0x7, 0xd2)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_CONTENT_PACKET" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_CONTENT_PACKETTest()
        {
            Assert.That(MF_MT_MPEG2_CONTENT_PACKET, Is.EqualTo(new Guid(0x825d55e4, 0x4f12, 0x4197, 0x9e, 0xb3, 0x59, 0xb6, 0xe4, 0x71, 0xf, 0x6)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_ONE_FRAME_PER_PACKET" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_ONE_FRAME_PER_PACKETTest()
        {
            Assert.That(MF_MT_MPEG2_ONE_FRAME_PER_PACKET, Is.EqualTo(new Guid(0x91a49eb5, 0x1d20, 0x4b42, 0xac, 0xe8, 0x80, 0x42, 0x69, 0xbf, 0x95, 0xed)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG2_HDCP" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG2_HDCPTest()
        {
            Assert.That(MF_MT_MPEG2_HDCP, Is.EqualTo(new Guid(0x168f1b4a, 0x3e91, 0x450f, 0xae, 0xa7, 0xe4, 0xba, 0xea, 0xda, 0xe5, 0xba)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_MAX_CODEC_CONFIG_DELAY" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_MAX_CODEC_CONFIG_DELAYTest()
        {
            Assert.That(MF_MT_H264_MAX_CODEC_CONFIG_DELAY, Is.EqualTo(new Guid(0xf5929986, 0x4c45, 0x4fbb, 0xbb, 0x49, 0x6c, 0xc5, 0x34, 0xd0, 0x5b, 0x9b)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_SUPPORTED_SLICE_MODES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_SUPPORTED_SLICE_MODESTest()
        {
            Assert.That(MF_MT_H264_SUPPORTED_SLICE_MODES, Is.EqualTo(new Guid(0xc8be1937, 0x4d64, 0x4549, 0x83, 0x43, 0xa8, 0x8, 0x6c, 0xb, 0xfd, 0xa5)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_SUPPORTED_SYNC_FRAME_TYPES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_SUPPORTED_SYNC_FRAME_TYPESTest()
        {
            Assert.That(MF_MT_H264_SUPPORTED_SYNC_FRAME_TYPES, Is.EqualTo(new Guid(0x89a52c01, 0xf282, 0x48d2, 0xb5, 0x22, 0x22, 0xe6, 0xae, 0x63, 0x31, 0x99)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_RESOLUTION_SCALING" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_RESOLUTION_SCALINGTest()
        {
            Assert.That(MF_MT_H264_RESOLUTION_SCALING, Is.EqualTo(new Guid(0xe3854272, 0xf715, 0x4757, 0xba, 0x90, 0x1b, 0x69, 0x6c, 0x77, 0x34, 0x57)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_SIMULCAST_SUPPORT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_SIMULCAST_SUPPORTTest()
        {
            Assert.That(MF_MT_H264_SIMULCAST_SUPPORT, Is.EqualTo(new Guid(0x9ea2d63d, 0x53f0, 0x4a34, 0xb9, 0x4e, 0x9d, 0xe4, 0x9a, 0x7, 0x8c, 0xb3)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_SUPPORTED_RATE_CONTROL_MODES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_SUPPORTED_RATE_CONTROL_MODESTest()
        {
            Assert.That(MF_MT_H264_SUPPORTED_RATE_CONTROL_MODES, Is.EqualTo(new Guid(0x6a8ac47e, 0x519c, 0x4f18, 0x9b, 0xb3, 0x7e, 0xea, 0xae, 0xa5, 0x59, 0x4d)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_MAX_MB_PER_SEC" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_MAX_MB_PER_SECTest()
        {
            Assert.That(MF_MT_H264_MAX_MB_PER_SEC, Is.EqualTo(new Guid(0x45256d30, 0x7215, 0x4576, 0x93, 0x36, 0xb0, 0xf1, 0xbc, 0xd5, 0x9b, 0xb2)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_SUPPORTED_USAGES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_SUPPORTED_USAGESTest()
        {
            Assert.That(MF_MT_H264_SUPPORTED_USAGES, Is.EqualTo(new Guid(0x60b1a998, 0xdc01, 0x40ce, 0x97, 0x36, 0xab, 0xa8, 0x45, 0xa2, 0xdb, 0xdc)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_CAPABILITIES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_CAPABILITIESTest()
        {
            Assert.That(MF_MT_H264_CAPABILITIES, Is.EqualTo(new Guid(0xbb3bd508, 0x490a, 0x11e0, 0x99, 0xe4, 0x13, 0x16, 0xdf, 0xd7, 0x20, 0x85)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_SVC_CAPABILITIES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_SVC_CAPABILITIESTest()
        {
            Assert.That(MF_MT_H264_SVC_CAPABILITIES, Is.EqualTo(new Guid(0xf8993abe, 0xd937, 0x4a8f, 0xbb, 0xca, 0x69, 0x66, 0xfe, 0x9e, 0x11, 0x52)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_USAGE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_USAGETest()
        {
            Assert.That(MF_MT_H264_USAGE, Is.EqualTo(new Guid(0x359ce3a5, 0xaf00, 0x49ca, 0xa2, 0xf4, 0x2a, 0xc9, 0x4c, 0xa8, 0x2b, 0x61)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_RATE_CONTROL_MODES" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_RATE_CONTROL_MODESTest()
        {
            Assert.That(MF_MT_H264_RATE_CONTROL_MODES, Is.EqualTo(new Guid(0x705177d8, 0x45cb, 0x11e0, 0xac, 0x7d, 0xb9, 0x1c, 0xe0, 0xd7, 0x20, 0x85)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_H264_LAYOUT_PER_STREAM" /> property is correct.</summary>
        [Test]
        public static void MF_MT_H264_LAYOUT_PER_STREAMTest()
        {
            Assert.That(MF_MT_H264_LAYOUT_PER_STREAM, Is.EqualTo(new Guid(0x85e299b2, 0x90e3, 0x4fe8, 0xb2, 0xf5, 0xc0, 0x67, 0xe0, 0xbf, 0xe5, 0x7a)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_IN_BAND_PARAMETER_SET" /> property is correct.</summary>
        [Test]
        public static void MF_MT_IN_BAND_PARAMETER_SETTest()
        {
            Assert.That(MF_MT_IN_BAND_PARAMETER_SET, Is.EqualTo(new Guid(0x75da5090, 0x910b, 0x4a03, 0x89, 0x6c, 0x7b, 0x89, 0x8f, 0xee, 0xa5, 0xaf)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG4_TRACK_TYPE" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG4_TRACK_TYPETest()
        {
            Assert.That(MF_MT_MPEG4_TRACK_TYPE, Is.EqualTo(new Guid(0x54f486dd, 0x9327, 0x4f6d, 0x80, 0xab, 0x6f, 0x70, 0x9e, 0xbb, 0x4c, 0xce)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_CONTAINER_RATE_SCALING" /> property is correct.</summary>
        [Test]
        public static void MF_MT_CONTAINER_RATE_SCALINGTest()
        {
            Assert.That(MF_MT_CONTAINER_RATE_SCALING, Is.EqualTo(new Guid(0x83877f5e, 0x444, 0x4e28, 0x84, 0x79, 0x6d, 0xb0, 0x98, 0x9b, 0x8c, 0x9)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DV_AAUX_SRC_PACK_0" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DV_AAUX_SRC_PACK_0Test()
        {
            Assert.That(MF_MT_DV_AAUX_SRC_PACK_0, Is.EqualTo(new Guid(0x84bd5d88, 0x0fb8, 0x4ac8, 0xbe, 0x4b, 0xa8, 0x84, 0x8b, 0xef, 0x98, 0xf3)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DV_AAUX_CTRL_PACK_0" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DV_AAUX_CTRL_PACK_0Test()
        {
            Assert.That(MF_MT_DV_AAUX_CTRL_PACK_0, Is.EqualTo(new Guid(0xf731004e, 0x1dd1, 0x4515, 0xaa, 0xbe, 0xf0, 0xc0, 0x6a, 0xa5, 0x36, 0xac)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DV_AAUX_SRC_PACK_1" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DV_AAUX_SRC_PACK_1Test()
        {
            Assert.That(MF_MT_DV_AAUX_SRC_PACK_1, Is.EqualTo(new Guid(0x720e6544, 0x0225, 0x4003, 0xa6, 0x51, 0x01, 0x96, 0x56, 0x3a, 0x95, 0x8e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DV_AAUX_CTRL_PACK_1" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DV_AAUX_CTRL_PACK_1Test()
        {
            Assert.That(MF_MT_DV_AAUX_CTRL_PACK_1, Is.EqualTo(new Guid(0xcd1f470d, 0x1f04, 0x4fe0, 0xbf, 0xb9, 0xd0, 0x7a, 0xe0, 0x38, 0x6a, 0xd8)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DV_VAUX_SRC_PACK" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DV_VAUX_SRC_PACKTest()
        {
            Assert.That(MF_MT_DV_VAUX_SRC_PACK, Is.EqualTo(new Guid(0x41402d9d, 0x7b57, 0x43c6, 0xb1, 0x29, 0x2c, 0xb9, 0x97, 0xf1, 0x50, 0x09)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_DV_VAUX_CTRL_PACK" /> property is correct.</summary>
        [Test]
        public static void MF_MT_DV_VAUX_CTRL_PACKTest()
        {
            Assert.That(MF_MT_DV_VAUX_CTRL_PACK, Is.EqualTo(new Guid(0x2f84e1c4, 0x0da1, 0x4788, 0x93, 0x8e, 0x0d, 0xfb, 0xfb, 0xb3, 0x4b, 0x48)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_ARBITRARY_HEADER" /> property is correct.</summary>
        [Test]
        public static void MF_MT_ARBITRARY_HEADERTest()
        {
            Assert.That(MF_MT_ARBITRARY_HEADER, Is.EqualTo(new Guid(0x9e6bd6f5, 0x109, 0x4f95, 0x84, 0xac, 0x93, 0x9, 0x15, 0x3a, 0x19, 0xfc)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_ARBITRARY_FORMAT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_ARBITRARY_FORMATTest()
        {
            Assert.That(MF_MT_ARBITRARY_FORMAT, Is.EqualTo(new Guid(0x5a75b249, 0xd7d, 0x49a1, 0xa1, 0xc3, 0xe0, 0xd8, 0x7f, 0xc, 0xad, 0xe5)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_IMAGE_LOSS_TOLERANT" /> property is correct.</summary>
        [Test]
        public static void MF_MT_IMAGE_LOSS_TOLERANTTest()
        {
            Assert.That(MF_MT_IMAGE_LOSS_TOLERANT, Is.EqualTo(new Guid(0xed062cf4, 0xe34e, 0x4922, 0xbe, 0x99, 0x93, 0x40, 0x32, 0x13, 0x3d, 0x7c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG4_SAMPLE_DESCRIPTION" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG4_SAMPLE_DESCRIPTIONTest()
        {
            Assert.That(MF_MT_MPEG4_SAMPLE_DESCRIPTION, Is.EqualTo(new Guid(0x261e9d83, 0x9529, 0x4b8f, 0xa1, 0x11, 0x8b, 0x9c, 0x95, 0x0a, 0x81, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_MPEG4_CURRENT_SAMPLE_ENTRY" /> property is correct.</summary>
        [Test]
        public static void MF_MT_MPEG4_CURRENT_SAMPLE_ENTRYTest()
        {
            Assert.That(MF_MT_MPEG4_CURRENT_SAMPLE_ENTRY, Is.EqualTo(new Guid(0x9aa7e155, 0xb64a, 0x4c1d, 0xa5, 0x00, 0x45, 0x5d, 0x60, 0x0b, 0x65, 0x60)));
        }

        /// <summary>Validates that the value of the <see cref="MF_SD_AMBISONICS_SAMPLE3D_DESCRIPTION" /> property is correct.</summary>
        [Test]
        public static void MF_SD_AMBISONICS_SAMPLE3D_DESCRIPTIONTest()
        {
            Assert.That(MF_SD_AMBISONICS_SAMPLE3D_DESCRIPTION, Is.EqualTo(new Guid(0xf715cf3e, 0xa964, 0x4c3f, 0x94, 0xae, 0x9d, 0x6b, 0xa7, 0x26, 0x46, 0x41)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_ORIGINAL_4CC" /> property is correct.</summary>
        [Test]
        public static void MF_MT_ORIGINAL_4CCTest()
        {
            Assert.That(MF_MT_ORIGINAL_4CC, Is.EqualTo(new Guid(0xd7be3fe0, 0x2bc7, 0x492d, 0xb8, 0x43, 0x61, 0xa1, 0x91, 0x9b, 0x70, 0xc3)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_ORIGINAL_WAVE_FORMAT_TAG" /> property is correct.</summary>
        [Test]
        public static void MF_MT_ORIGINAL_WAVE_FORMAT_TAGTest()
        {
            Assert.That(MF_MT_ORIGINAL_WAVE_FORMAT_TAG, Is.EqualTo(new Guid(0x8cbbc843, 0x9fd9, 0x49c2, 0x88, 0x2f, 0xa7, 0x25, 0x86, 0xc4, 0x08, 0xad)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_FRAME_RATE_RANGE_MIN" /> property is correct.</summary>
        [Test]
        public static void MF_MT_FRAME_RATE_RANGE_MINTest()
        {
            Assert.That(MF_MT_FRAME_RATE_RANGE_MIN, Is.EqualTo(new Guid(0xd2e7558c, 0xdc1f, 0x403f, 0x9a, 0x72, 0xd2, 0x8b, 0xb1, 0xeb, 0x3b, 0x5e)));
        }

        /// <summary>Validates that the value of the <see cref="MF_MT_FRAME_RATE_RANGE_MAX" /> property is correct.</summary>
        [Test]
        public static void MF_MT_FRAME_RATE_RANGE_MAXTest()
        {
            Assert.That(MF_MT_FRAME_RATE_RANGE_MAX, Is.EqualTo(new Guid(0xe3371d41, 0xb4cf, 0x4a05, 0xbd, 0x4e, 0x20, 0xb8, 0x8b, 0xb2, 0xc4, 0xd6)));
        }

        /// <summary>Validates that the value of the <see cref="MF_LOW_LATENCY" /> property is correct.</summary>
        [Test]
        public static void MF_LOW_LATENCYTest()
        {
            Assert.That(MF_LOW_LATENCY, Is.EqualTo(new Guid(0x9c27891a, 0xed7a, 0x40e1, 0x88, 0xe8, 0xb2, 0x27, 0x27, 0xa0, 0x24, 0xee)));
        }

        /// <summary>Validates that the value of the <see cref="MF_VIDEO_MAX_MB_PER_SEC" /> property is correct.</summary>
        [Test]
        public static void MF_VIDEO_MAX_MB_PER_SECTest()
        {
            Assert.That(MF_VIDEO_MAX_MB_PER_SEC, Is.EqualTo(new Guid(0xe3f2e203, 0xd445, 0x4b8c, 0x92, 0x11, 0xae, 0x39, 0xd, 0x3b, 0xa0, 0x17)));
        }

        /// <summary>Validates that the value of the <see cref="MF_DISABLE_FRAME_CORRUPTION_INFO" /> property is correct.</summary>
        [Test]
        public static void MF_DISABLE_FRAME_CORRUPTION_INFOTest()
        {
            Assert.That(MF_DISABLE_FRAME_CORRUPTION_INFO, Is.EqualTo(new Guid(0x7086e16c, 0x49c5, 0x4201, 0x88, 0x2a, 0x85, 0x38, 0xf3, 0x8c, 0xf1, 0x3a)));
        }

        /// <summary>Validates that the value of the <see cref="MFStreamExtension_CameraExtrinsics" /> property is correct.</summary>
        [Test]
        public static void MFStreamExtension_CameraExtrinsicsTest()
        {
            Assert.That(MFStreamExtension_CameraExtrinsics, Is.EqualTo(new Guid(0x686196d0, 0x13e2, 0x41d9, 0x96, 0x38, 0xef, 0x3, 0x2c, 0x27, 0x2a, 0x52)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_CameraExtrinsics" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_CameraExtrinsicsTest()
        {
            Assert.That(MFSampleExtension_CameraExtrinsics, Is.EqualTo(new Guid(0x6b761658, 0xb7ec, 0x4c3b, 0x82, 0x25, 0x86, 0x23, 0xca, 0xbe, 0xc3, 0x1d)));
        }

        /// <summary>Validates that the value of the <see cref="MFStreamExtension_PinholeCameraIntrinsics" /> property is correct.</summary>
        [Test]
        public static void MFStreamExtension_PinholeCameraIntrinsicsTest()
        {
            Assert.That(MFStreamExtension_PinholeCameraIntrinsics, Is.EqualTo(new Guid(0xdbac0455, 0xec8, 0x4aef, 0x9c, 0x32, 0x7a, 0x3e, 0xe3, 0x45, 0x6f, 0x53)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_PinholeCameraIntrinsics" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_PinholeCameraIntrinsicsTest()
        {
            Assert.That(MFSampleExtension_PinholeCameraIntrinsics, Is.EqualTo(new Guid(0x4ee3b6c5, 0x6a15, 0x4e72, 0x97, 0x61, 0x70, 0xc1, 0xdb, 0x8b, 0x9f, 0xe3)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Default" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_DefaultTest()
        {
            Assert.That(MFMediaType_Default, Is.EqualTo(new Guid(0x81A412E6, 0x8103, 0x4B06, 0x85, 0x7F, 0x18, 0x62, 0x78, 0x10, 0x24, 0xAC)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Audio" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_AudioTest()
        {
            Assert.That(MFMediaType_Audio, Is.EqualTo(new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Video" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_VideoTest()
        {
            Assert.That(MFMediaType_Video, Is.EqualTo(new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Protected" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_ProtectedTest()
        {
            Assert.That(MFMediaType_Protected, Is.EqualTo(new Guid(0x7b4b6fe6, 0x9d04, 0x4494, 0xbe, 0x14, 0x7e, 0x0b, 0xd0, 0x76, 0xc8, 0xe4)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_SAMI" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_SAMITest()
        {
            Assert.That(MFMediaType_SAMI, Is.EqualTo(new Guid(0xe69669a0, 0x3dcd, 0x40cb, 0x9e, 0x2e, 0x37, 0x08, 0x38, 0x7c, 0x06, 0x16)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Script" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_ScriptTest()
        {
            Assert.That(MFMediaType_Script, Is.EqualTo(new Guid(0x72178C22, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Image" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_ImageTest()
        {
            Assert.That(MFMediaType_Image, Is.EqualTo(new Guid(0x72178C23, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_HTML" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_HTMLTest()
        {
            Assert.That(MFMediaType_HTML, Is.EqualTo(new Guid(0x72178C24, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Binary" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_BinaryTest()
        {
            Assert.That(MFMediaType_Binary, Is.EqualTo(new Guid(0x72178C25, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_FileTransfer" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_FileTransferTest()
        {
            Assert.That(MFMediaType_FileTransfer, Is.EqualTo(new Guid(0x72178C26, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Stream" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_StreamTest()
        {
            Assert.That(MFMediaType_Stream, Is.EqualTo(new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_MultiplexedFrames" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_MultiplexedFramesTest()
        {
            Assert.That(MFMediaType_MultiplexedFrames, Is.EqualTo(new Guid(0x6ea542b0, 0x281f, 0x4231, 0xa4, 0x64, 0xfe, 0x2f, 0x50, 0x22, 0x50, 0x1c)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Subtitle" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_SubtitleTest()
        {
            Assert.That(MFMediaType_Subtitle, Is.EqualTo(new Guid(0xa6d13581, 0xed50, 0x4e65, 0xae, 0x08, 0x26, 0x06, 0x55, 0x76, 0xaa, 0xcc)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Perception" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_PerceptionTest()
        {
            Assert.That(MFMediaType_Perception, Is.EqualTo(new Guid(0x597ff6f9, 0x6ea2, 0x4670, 0x85, 0xb4, 0xea, 0x84, 0x7, 0x3f, 0xe9, 0x40)));
        }

        /// <summary>Validates that the value of the <see cref="MFImageFormat_JPEG" /> property is correct.</summary>
        [Test]
        public static void MFImageFormat_JPEGTest()
        {
            Assert.That(MFImageFormat_JPEG, Is.EqualTo(new Guid(0x19e4a5aa, 0x5662, 0x4fc5, 0xa0, 0xc0, 0x17, 0x58, 0x02, 0x8e, 0x10, 0x57)));
        }

        /// <summary>Validates that the value of the <see cref="MFImageFormat_RGB32" /> property is correct.</summary>
        [Test]
        public static void MFImageFormat_RGB32Test()
        {
            Assert.That(MFImageFormat_RGB32, Is.EqualTo(new Guid(0x00000016, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFStreamFormat_MPEG2Transport" /> property is correct.</summary>
        [Test]
        public static void MFStreamFormat_MPEG2TransportTest()
        {
            Assert.That(MFStreamFormat_MPEG2Transport, Is.EqualTo(new Guid(0xe06d8023, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea)));
        }

        /// <summary>Validates that the value of the <see cref="MFStreamFormat_MPEG2Program" /> property is correct.</summary>
        [Test]
        public static void MFStreamFormat_MPEG2ProgramTest()
        {
            Assert.That(MFStreamFormat_MPEG2Program, Is.EqualTo(new Guid(0x263067d1, 0xd330, 0x45dc, 0xb6, 0x69, 0x34, 0xd9, 0x86, 0xe4, 0xe3, 0xe1)));
        }

        /// <summary>Validates that the value of the <see cref="AM_MEDIA_TYPE_REPRESENTATION" /> property is correct.</summary>
        [Test]
        public static void AM_MEDIA_TYPE_REPRESENTATIONTest()
        {
            Assert.That(AM_MEDIA_TYPE_REPRESENTATION, Is.EqualTo(new Guid(0xe2e42ad2, 0x132c, 0x491e, 0xa2, 0x68, 0x3c, 0x7c, 0x2d, 0xca, 0x18, 0x1f)));
        }

        /// <summary>Validates that the value of the <see cref="FORMAT_MFVideoFormat" /> property is correct.</summary>
        [Test]
        public static void FORMAT_MFVideoFormatTest()
        {
            Assert.That(FORMAT_MFVideoFormat, Is.EqualTo(new Guid(0xaed4ab2d, 0x7326, 0x43cb, 0x94, 0x64, 0xc8, 0x79, 0xca, 0xb9, 0xc4, 0x3d)));
        }

        /// <summary>Validates that the value of the <see cref="MFMediaType_Metadata" /> property is correct.</summary>
        [Test]
        public static void MFMediaType_MetadataTest()
        {
            Assert.That(MFMediaType_Metadata, Is.EqualTo(new Guid(0x2c8fa20c, 0x82bb, 0x4782, 0x90, 0xa0, 0x98, 0xa2, 0xa5, 0xbd, 0x8e, 0xf8)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_MFSourceResolver" /> property is correct.</summary>
        [Test]
        public static void CLSID_MFSourceResolverTest()
        {
            Assert.That(CLSID_MFSourceResolver, Is.EqualTo(new Guid(0x90eab60f, 0xe43a, 0x4188, 0xbc, 0xc4, 0xe4, 0x7f, 0xdf, 0x04, 0x86, 0x8c)));
        }

        /// <summary>Validates that the value of the <see cref="MF_DEVICESTREAM_ATTRIBUTE_FACEAUTH_CAPABILITY" /> property is correct.</summary>
        [Test]
        public static void MF_DEVICESTREAM_ATTRIBUTE_FACEAUTH_CAPABILITYTest()
        {
            Assert.That(MF_DEVICESTREAM_ATTRIBUTE_FACEAUTH_CAPABILITY, Is.EqualTo(new Guid(0xCB6FD12A, 0x2248, 0x4E41, 0xAD, 0x46, 0xE7, 0x8B, 0xB9, 0x0A, 0xB9, 0xFC)));
        }

        /// <summary>Validates that the value of the <see cref="MF_DEVICESTREAM_ATTRIBUTE_SECURE_CAPABILITY" /> property is correct.</summary>
        [Test]
        public static void MF_DEVICESTREAM_ATTRIBUTE_SECURE_CAPABILITYTest()
        {
            Assert.That(MF_DEVICESTREAM_ATTRIBUTE_SECURE_CAPABILITY, Is.EqualTo(new Guid(0x940FD626, 0xEA6E, 0x4684, 0x98, 0x40, 0x36, 0xBD, 0x6E, 0xC9, 0xFB, 0xEF)));
        }
    }
}
