// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static unsafe partial class WindowsTests
    {
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

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_MULTIPLEXED_MANAGER" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_MULTIPLEXED_MANAGERTest()
        {
            Assert.That(MFSampleExtension_MULTIPLEXED_MANAGER, Is.EqualTo(new Guid(0x8dcdee79, 0x6b5a, 0x4c45, 0x8d, 0xb9, 0x20, 0xb3, 0x95, 0xf0, 0x2f, 0xcf)));
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
    }
}
