// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static unsafe partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="MFPKEY_SourceOpenMonitor" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_SourceOpenMonitorTest()
        {
            Assert.That(MFPKEY_SourceOpenMonitor.fmtid, Is.EqualTo(new Guid(0x074d4637, 0xb5ae, 0x465d, 0xaf, 0x17, 0x1a, 0x53, 0x8d, 0x28, 0x59, 0xdd)));
            Assert.That(MFPKEY_SourceOpenMonitor.pid, Is.EqualTo(0x02));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_ASFMediaSource_ApproxSeek" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_ASFMediaSource_ApproxSeekTest()
        {
            Assert.That(MFPKEY_ASFMediaSource_ApproxSeek.fmtid, Is.EqualTo(new Guid(0xb4cd270f, 0x244d, 0x4969, 0xbb, 0x92, 0x3f, 0x0f, 0xb8, 0x31, 0x6f, 0x10)));
            Assert.That(MFPKEY_ASFMediaSource_ApproxSeek.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_ASFMediaSource_IterativeSeekIfNoIndexTest()
        {
            Assert.That(MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex.fmtid, Is.EqualTo(new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c)));
            Assert.That(MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_ASFMediaSource_IterativeSeek_Max_Count" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_ASFMediaSource_IterativeSeek_Max_CountTest()
        {
            Assert.That(MFPKEY_ASFMediaSource_IterativeSeek_Max_Count.fmtid, Is.EqualTo(new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c)));
            Assert.That(MFPKEY_ASFMediaSource_IterativeSeek_Max_Count.pid, Is.EqualTo(0x02));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecondTest()
        {
            Assert.That(MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond.fmtid, Is.EqualTo(new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c)));
            Assert.That(MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond.pid, Is.EqualTo(0x03));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_Content_DLNA_Profile_ID" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_Content_DLNA_Profile_IDTest()
        {
            Assert.That(MFPKEY_Content_DLNA_Profile_ID.fmtid, Is.EqualTo(new Guid(0xcfa31b45, 0x525d, 0x4998, 0xbb, 0x44, 0x3f, 0x7d, 0x81, 0x54, 0x2f, 0xa4)));
            Assert.That(MFPKEY_Content_DLNA_Profile_ID.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_MediaSource_DisableReadAhead" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_MediaSource_DisableReadAheadTest()
        {
            Assert.That(MFPKEY_MediaSource_DisableReadAhead.fmtid, Is.EqualTo(new Guid(0x26366c14, 0xc5bf, 0x4c76, 0x88, 0x7b, 0x9f, 0x17, 0x54, 0xdb, 0x5f, 0x9)));
            Assert.That(MFPKEY_MediaSource_DisableReadAhead.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_SBESourceMode" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_SBESourceModeTest()
        {
            Assert.That(MFPKEY_SBESourceMode.fmtid, Is.EqualTo(new Guid(0x3fae10bb, 0xf859, 0x4192, 0xb5, 0x62, 0x18, 0x68, 0xd3, 0xda, 0x3a, 0x02)));
            Assert.That(MFPKEY_SBESourceMode.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_PMP_Creation_Callback" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_PMP_Creation_CallbackTest()
        {
            Assert.That(MFPKEY_PMP_Creation_Callback.fmtid, Is.EqualTo(new Guid(0x28bb4de2, 0x26a2, 0x4870, 0xb7, 0x20, 0xd2, 0x6b, 0xbe, 0xb1, 0x49, 0x42)));
            Assert.That(MFPKEY_PMP_Creation_Callback.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Enable_Urlmon" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Enable_UrlmonTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Enable_Urlmon.fmtid, Is.EqualTo(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)));
            Assert.That(MFPKEY_HTTP_ByteStream_Enable_Urlmon.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Urlmon_Bind_FlagsTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags.fmtid, Is.EqualTo(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)));
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags.pid, Is.EqualTo(0x02));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Urlmon_Security_Id" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Urlmon_Security_IdTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Security_Id.fmtid, Is.EqualTo(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)));
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Security_Id.pid, Is.EqualTo(0x03));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Urlmon_Window" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Urlmon_WindowTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Window.fmtid, Is.EqualTo(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)));
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Window.pid, Is.EqualTo(0x04));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryServiceTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService.fmtid, Is.EqualTo(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)));
            Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService.pid, Is.EqualTo(0x05));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_MediaProtectionSystemId" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_MediaProtectionSystemIdTest()
        {
            Assert.That(MFPKEY_MediaProtectionSystemId.fmtid, Is.EqualTo(new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd)));
            Assert.That(MFPKEY_MediaProtectionSystemId.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_MediaProtectionSystemContext" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_MediaProtectionSystemContextTest()
        {
            Assert.That(MFPKEY_MediaProtectionSystemContext.fmtid, Is.EqualTo(new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd)));
            Assert.That(MFPKEY_MediaProtectionSystemContext.pid, Is.EqualTo(0x02));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_MediaProtectionSystemIdMapping" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_MediaProtectionSystemIdMappingTest()
        {
            Assert.That(MFPKEY_MediaProtectionSystemIdMapping.fmtid, Is.EqualTo(new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd)));
            Assert.That(MFPKEY_MediaProtectionSystemIdMapping.pid, Is.EqualTo(0x03));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_MediaProtectionContainerGuid" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_MediaProtectionContainerGuidTest()
        {
            Assert.That(MFPKEY_MediaProtectionContainerGuid.fmtid, Is.EqualTo(new Guid(0x42af3d7c, 0xcf, 0x4a0f, 0x81, 0xf0, 0xad, 0xf5, 0x24, 0xa5, 0xa5, 0xb5)));
            Assert.That(MFPKEY_MediaProtectionContainerGuid.pid, Is.EqualTo(0x1));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_MediaProtectionSystemContextsPerTrack" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_MediaProtectionSystemContextsPerTrackTest()
        {
            Assert.That(MFPKEY_MediaProtectionSystemContextsPerTrack.fmtid, Is.EqualTo(new Guid(0x4454b092, 0xd3da, 0x49b0, 0x84, 0x52, 0x68, 0x50, 0xc7, 0xdb, 0x76, 0x4d)));
            Assert.That(MFPKEY_MediaProtectionSystemContextsPerTrack.pid, Is.EqualTo(0x03));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Download_Mode" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Download_ModeTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Download_Mode.fmtid, Is.EqualTo(new Guid(0x817f11b7, 0xa982, 0x46ec, 0xa4, 0x49, 0xef, 0x58, 0xae, 0xd5, 0x3c, 0xa8)));
            Assert.That(MFPKEY_HTTP_ByteStream_Download_Mode.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Caching_Mode" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Caching_ModeTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Caching_Mode.fmtid, Is.EqualTo(new Guid(0x86a2403e, 0xc78b, 0x44d7, 0x8b, 0xc8, 0xff, 0x72, 0x58, 0x11, 0x75, 0x08)));
            Assert.That(MFPKEY_HTTP_ByteStream_Caching_Mode.pid, Is.EqualTo(0x01));
        }

        /// <summary>Validates that the value of the <see cref="MFPKEY_HTTP_ByteStream_Cache_Limit" /> property is correct.</summary>
        [Test]
        public static void MFPKEY_HTTP_ByteStream_Cache_LimitTest()
        {
            Assert.That(MFPKEY_HTTP_ByteStream_Cache_Limit.fmtid, Is.EqualTo(new Guid(0x86a2403e, 0xc78b, 0x44d7, 0x8b, 0xc8, 0xff, 0x72, 0x58, 0x11, 0x75, 0x08)));
            Assert.That(MFPKEY_HTTP_ByteStream_Cache_Limit.pid, Is.EqualTo(0x02));
        }

        /// <summary>Validates that the value of the <see cref="MFENABLETYPE_WMDRMV1_LicenseAcquisition" /> property is correct.</summary>
        [Test]
        public static void MFENABLETYPE_WMDRMV1_LicenseAcquisitionTest()
        {
            Assert.That(MFENABLETYPE_WMDRMV1_LicenseAcquisition, Is.EqualTo(new Guid(0x4ff6eeaf, 0xb43, 0x4797, 0x9b, 0x85, 0xab, 0xf3, 0x18, 0x15, 0xe7, 0xb0)));
        }

        /// <summary>Validates that the value of the <see cref="MFENABLETYPE_WMDRMV7_LicenseAcquisition" /> property is correct.</summary>
        [Test]
        public static void MFENABLETYPE_WMDRMV7_LicenseAcquisitionTest()
        {
            Assert.That(MFENABLETYPE_WMDRMV7_LicenseAcquisition, Is.EqualTo(new Guid(0x3306df, 0x4a06, 0x4884, 0xa0, 0x97, 0xef, 0x6d, 0x22, 0xec, 0x84, 0xa3)));
        }

        /// <summary>Validates that the value of the <see cref="MFENABLETYPE_WMDRMV7_Individualization" /> property is correct.</summary>
        [Test]
        public static void MFENABLETYPE_WMDRMV7_IndividualizationTest()
        {
            Assert.That(MFENABLETYPE_WMDRMV7_Individualization, Is.EqualTo(new Guid(0xacd2c84a, 0xb303, 0x4f65, 0xbc, 0x2c, 0x2c, 0x84, 0x8d, 0x1, 0xa9, 0x89)));
        }

        /// <summary>Validates that the value of the <see cref="MFENABLETYPE_MF_UpdateRevocationInformation" /> property is correct.</summary>
        [Test]
        public static void MFENABLETYPE_MF_UpdateRevocationInformationTest()
        {
            Assert.That(MFENABLETYPE_MF_UpdateRevocationInformation, Is.EqualTo(new Guid(0xe558b0b5, 0xb3c4, 0x44a0, 0x92, 0x4c, 0x50, 0xd1, 0x78, 0x93, 0x23, 0x85)));
        }

        /// <summary>Validates that the value of the <see cref="MFENABLETYPE_MF_UpdateUntrustedComponent" /> property is correct.</summary>
        [Test]
        public static void MFENABLETYPE_MF_UpdateUntrustedComponentTest()
        {
            Assert.That(MFENABLETYPE_MF_UpdateUntrustedComponent, Is.EqualTo(new Guid(0x9879f3d6, 0xcee2, 0x48e6, 0xb5, 0x73, 0x97, 0x67, 0xab, 0x17, 0x2f, 0x16)));
        }

        /// <summary>Validates that the value of the <see cref="MFENABLETYPE_MF_RebootRequired" /> property is correct.</summary>
        [Test]
        public static void MFENABLETYPE_MF_RebootRequiredTest()
        {
            Assert.That(MFENABLETYPE_MF_RebootRequired, Is.EqualTo(new Guid(0x6d4d3d4b, 0x0ece, 0x4652, 0x8b, 0x3a, 0xf2, 0xd2, 0x42, 0x60, 0xd8, 0x87)));
        }

        /// <summary>Validates that the value of the <see cref="MR_POLICY_VOLUME_SERVICE" /> property is correct.</summary>
        [Test]
        public static void MR_POLICY_VOLUME_SERVICETest()
        {
            Assert.That(MR_POLICY_VOLUME_SERVICE, Is.EqualTo(new Guid(0x1abaa2ac, 0x9d3b, 0x47c6, 0xab, 0x48, 0xc5, 0x95, 0x6, 0xde, 0x78, 0x4d)));
        }

        /// <summary>Validates that the value of the <see cref="MR_CAPTURE_POLICY_VOLUME_SERVICE" /> property is correct.</summary>
        [Test]
        public static void MR_CAPTURE_POLICY_VOLUME_SERVICETest()
        {
            Assert.That(MR_CAPTURE_POLICY_VOLUME_SERVICE, Is.EqualTo(new Guid(0x24030acd, 0x107a, 0x4265, 0x97, 0x5c, 0x41, 0x4e, 0x33, 0xe6, 0x5f, 0x2a)));
        }

        /// <summary>Validates that the value of the <see cref="MR_STREAM_VOLUME_SERVICE" /> property is correct.</summary>
        [Test]
        public static void MR_STREAM_VOLUME_SERVICETest()
        {
            Assert.That(MR_STREAM_VOLUME_SERVICE, Is.EqualTo(new Guid(0xf8b5fa2f, 0x32ef, 0x46f5, 0xb1, 0x72, 0x13, 0x21, 0x21, 0x2f, 0xb2, 0xc4)));
        }

        /// <summary>Validates that the value of the <see cref="MR_AUDIO_POLICY_SERVICE" /> property is correct.</summary>
        [Test]
        public static void MR_AUDIO_POLICY_SERVICETest()
        {
            Assert.That(MR_AUDIO_POLICY_SERVICE, Is.EqualTo(new Guid(0x911fd737, 0x6775, 0x4ab0, 0xa6, 0x14, 0x29, 0x78, 0x62, 0xfd, 0xac, 0x88)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_SSLCERTIFICATE_MANAGER" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_SSLCERTIFICATE_MANAGERTest()
        {
            Assert.That(MFNETSOURCE_SSLCERTIFICATE_MANAGER, Is.EqualTo(new Guid(0x55e6cb27, 0xe69b, 0x4267, 0x94, 0x0c, 0x2d, 0x7e, 0xc5, 0xbb, 0x8a, 0x0f)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_RESOURCE_FILTER" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_RESOURCE_FILTERTest()
        {
            Assert.That(MFNETSOURCE_RESOURCE_FILTER, Is.EqualTo(new Guid(0x815d0ff6, 0x265a, 0x4477, 0x9e, 0x46, 0x7b, 0x80, 0xad, 0x80, 0xb5, 0xfb)));
        }

        /// <summary>Validates that the value of the <see cref="MFNET_SAVEJOB_SERVICE" /> property is correct.</summary>
        [Test]
        public static void MFNET_SAVEJOB_SERVICETest()
        {
            Assert.That(MFNET_SAVEJOB_SERVICE, Is.EqualTo(new Guid(0xb85a587f, 0x3d02, 0x4e52, 0x95, 0x65, 0x55, 0xd3, 0xec, 0x1e, 0x7f, 0xf7)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_STATISTICS_SERVICE" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_STATISTICS_SERVICETest()
        {
            Assert.That(MFNETSOURCE_STATISTICS_SERVICE, Is.EqualTo(new Guid(0x3cb1f275, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_STATISTICS" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_STATISTICSTest()
        {
            Assert.That(MFNETSOURCE_STATISTICS, Is.EqualTo(new Guid(0x3cb1f274, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_BUFFERINGTIME" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_BUFFERINGTIMETest()
        {
            Assert.That(MFNETSOURCE_BUFFERINGTIME, Is.EqualTo(new Guid(0x3cb1f276, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ACCELERATEDSTREAMINGDURATION" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ACCELERATEDSTREAMINGDURATIONTest()
        {
            Assert.That(MFNETSOURCE_ACCELERATEDSTREAMINGDURATION, Is.EqualTo(new Guid(0x3cb1f277, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATIONTest()
        {
            Assert.That(MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION, Is.EqualTo(new Guid(0x4aab2879, 0xbbe1, 0x4994, 0x9f, 0xf0, 0x54, 0x95, 0xbd, 0x25, 0x1, 0x29)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_MAXBUFFERTIMEMS" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_MAXBUFFERTIMEMSTest()
        {
            Assert.That(MFNETSOURCE_MAXBUFFERTIMEMS, Is.EqualTo(new Guid(0x408b24e6, 0x4038, 0x4401, 0xb5, 0xb2, 0xfe, 0x70, 0x1a, 0x9e, 0xbf, 0x10)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_CONNECTIONBANDWIDTH" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_CONNECTIONBANDWIDTHTest()
        {
            Assert.That(MFNETSOURCE_CONNECTIONBANDWIDTH, Is.EqualTo(new Guid(0x3cb1f278, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_CACHEENABLED" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_CACHEENABLEDTest()
        {
            Assert.That(MFNETSOURCE_CACHEENABLED, Is.EqualTo(new Guid(0x3cb1f279, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_AUTORECONNECTLIMIT" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_AUTORECONNECTLIMITTest()
        {
            Assert.That(MFNETSOURCE_AUTORECONNECTLIMIT, Is.EqualTo(new Guid(0x3cb1f27a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_RESENDSENABLED" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_RESENDSENABLEDTest()
        {
            Assert.That(MFNETSOURCE_RESENDSENABLED, Is.EqualTo(new Guid(0x3cb1f27b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_THINNINGENABLED" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_THINNINGENABLEDTest()
        {
            Assert.That(MFNETSOURCE_THINNINGENABLED, Is.EqualTo(new Guid(0x3cb1f27c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROTOCOL" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROTOCOLTest()
        {
            Assert.That(MFNETSOURCE_PROTOCOL, Is.EqualTo(new Guid(0x3cb1f27d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_TRANSPORT" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_TRANSPORTTest()
        {
            Assert.That(MFNETSOURCE_TRANSPORT, Is.EqualTo(new Guid(0x3cb1f27e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PREVIEWMODEENABLED" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PREVIEWMODEENABLEDTest()
        {
            Assert.That(MFNETSOURCE_PREVIEWMODEENABLED, Is.EqualTo(new Guid(0x3cb1f27f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_CREDENTIAL_MANAGER" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_CREDENTIAL_MANAGERTest()
        {
            Assert.That(MFNETSOURCE_CREDENTIAL_MANAGER, Is.EqualTo(new Guid(0x3cb1f280, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PPBANDWIDTH" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PPBANDWIDTHTest()
        {
            Assert.That(MFNETSOURCE_PPBANDWIDTH, Is.EqualTo(new Guid(0x3cb1f281, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_AUTORECONNECTPROGRESS" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_AUTORECONNECTPROGRESSTest()
        {
            Assert.That(MFNETSOURCE_AUTORECONNECTPROGRESS, Is.EqualTo(new Guid(0x3cb1f282, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYLOCATORFACTORY" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYLOCATORFACTORYTest()
        {
            Assert.That(MFNETSOURCE_PROXYLOCATORFACTORY, Is.EqualTo(new Guid(0x3cb1f283, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_BROWSERUSERAGENT" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_BROWSERUSERAGENTTest()
        {
            Assert.That(MFNETSOURCE_BROWSERUSERAGENT, Is.EqualTo(new Guid(0x3cb1f28b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_BROWSERWEBPAGE" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_BROWSERWEBPAGETest()
        {
            Assert.That(MFNETSOURCE_BROWSERWEBPAGE, Is.EqualTo(new Guid(0x3cb1f28c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PLAYERVERSION" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PLAYERVERSIONTest()
        {
            Assert.That(MFNETSOURCE_PLAYERVERSION, Is.EqualTo(new Guid(0x3cb1f28d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PLAYERID" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PLAYERIDTest()
        {
            Assert.That(MFNETSOURCE_PLAYERID, Is.EqualTo(new Guid(0x3cb1f28e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_HOSTEXE" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_HOSTEXETest()
        {
            Assert.That(MFNETSOURCE_HOSTEXE, Is.EqualTo(new Guid(0x3cb1f28f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_HOSTVERSION" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_HOSTVERSIONTest()
        {
            Assert.That(MFNETSOURCE_HOSTVERSION, Is.EqualTo(new Guid(0x3cb1f291, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PLAYERUSERAGENT" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PLAYERUSERAGENTTest()
        {
            Assert.That(MFNETSOURCE_PLAYERUSERAGENT, Is.EqualTo(new Guid(0x3cb1f292, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_CLIENTGUID" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_CLIENTGUIDTest()
        {
            Assert.That(MFNETSOURCE_CLIENTGUID, Is.EqualTo(new Guid(0x60a2c4a6, 0xf197, 0x4c14, 0xa5, 0xbf, 0x88, 0x83, 0xd, 0x24, 0x58, 0xaf)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_LOGURL" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_LOGURLTest()
        {
            Assert.That(MFNETSOURCE_LOGURL, Is.EqualTo(new Guid(0x3cb1f293, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_UDP" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_UDPTest()
        {
            Assert.That(MFNETSOURCE_ENABLE_UDP, Is.EqualTo(new Guid(0x3cb1f294, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_TCP" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_TCPTest()
        {
            Assert.That(MFNETSOURCE_ENABLE_TCP, Is.EqualTo(new Guid(0x3cb1f295, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_MSB" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_MSBTest()
        {
            Assert.That(MFNETSOURCE_ENABLE_MSB, Is.EqualTo(new Guid(0x3cb1f296, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_RTSP" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_RTSPTest()
        {
            Assert.That(MFNETSOURCE_ENABLE_RTSP, Is.EqualTo(new Guid(0x3cb1f298, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_HTTP" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_HTTPTest()
        {
            Assert.That(MFNETSOURCE_ENABLE_HTTP, Is.EqualTo(new Guid(0x3cb1f299, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_STREAMING" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_STREAMINGTest()
        {
            Assert.That(MFNETSOURCE_ENABLE_STREAMING, Is.EqualTo(new Guid(0x3cb1f29c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_DOWNLOAD" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_DOWNLOADTest()
        {
            Assert.That(MFNETSOURCE_ENABLE_DOWNLOAD, Is.EqualTo(new Guid(0x3cb1f29d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_ENABLE_PRIVATEMODE" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_ENABLE_PRIVATEMODETest()
        {
            Assert.That(MFNETSOURCE_ENABLE_PRIVATEMODE, Is.EqualTo(new Guid(0x824779d8, 0xf18b, 0x4405, 0x8c, 0xf1, 0x46, 0x4f, 0xb5, 0xaa, 0x8f, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_UDP_PORT_RANGE" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_UDP_PORT_RANGETest()
        {
            Assert.That(MFNETSOURCE_UDP_PORT_RANGE, Is.EqualTo(new Guid(0x3cb1f29a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYINFO" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYINFOTest()
        {
            Assert.That(MFNETSOURCE_PROXYINFO, Is.EqualTo(new Guid(0x3cb1f29b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_DRMNET_LICENSE_REPRESENTATIONTest()
        {
            Assert.That(MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION, Is.EqualTo(new Guid(0x47eae1bd, 0xbdfe, 0x42e2, 0x82, 0xf3, 0x54, 0xa4, 0x8c, 0x17, 0x96, 0x2d)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYSETTINGS" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYSETTINGSTest()
        {
            Assert.That(MFNETSOURCE_PROXYSETTINGS, Is.EqualTo(new Guid(0x3cb1f287, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYHOSTNAME" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYHOSTNAMETest()
        {
            Assert.That(MFNETSOURCE_PROXYHOSTNAME, Is.EqualTo(new Guid(0x3cb1f284, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYPORT" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYPORTTest()
        {
            Assert.That(MFNETSOURCE_PROXYPORT, Is.EqualTo(new Guid(0x3cb1f288, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYEXCEPTIONLIST" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYEXCEPTIONLISTTest()
        {
            Assert.That(MFNETSOURCE_PROXYEXCEPTIONLIST, Is.EqualTo(new Guid(0x3cb1f285, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYBYPASSFORLOCAL" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYBYPASSFORLOCALTest()
        {
            Assert.That(MFNETSOURCE_PROXYBYPASSFORLOCAL, Is.EqualTo(new Guid(0x3cb1f286, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PROXYRERUNAUTODETECTION" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PROXYRERUNAUTODETECTIONTest()
        {
            Assert.That(MFNETSOURCE_PROXYRERUNAUTODETECTION, Is.EqualTo(new Guid(0x3cb1f289, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_STREAM_LANGUAGE" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_STREAM_LANGUAGETest()
        {
            Assert.That(MFNETSOURCE_STREAM_LANGUAGE, Is.EqualTo(new Guid(0x9ab44318, 0xf7cd, 0x4f2d, 0x8d, 0x6d, 0xfa, 0x35, 0xb4, 0x92, 0xce, 0xcb)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_LOGPARAMS" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_LOGPARAMSTest()
        {
            Assert.That(MFNETSOURCE_LOGPARAMS, Is.EqualTo(new Guid(0x64936ae8, 0x9418, 0x453a, 0x8c, 0xda, 0x3e, 0xa, 0x66, 0x8b, 0x35, 0x3b)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_PEERMANAGER" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_PEERMANAGERTest()
        {
            Assert.That(MFNETSOURCE_PEERMANAGER, Is.EqualTo(new Guid(0x48b29adb, 0xfebf, 0x45ee, 0xa9, 0xbf, 0xef, 0xb8, 0x1c, 0x49, 0x2e, 0xfc)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_FRIENDLYNAME" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_FRIENDLYNAMETest()
        {
            Assert.That(MFNETSOURCE_FRIENDLYNAME, Is.EqualTo(new Guid(0x5b2a7757, 0xbc6b, 0x447e, 0xaa, 0x06, 0x0d, 0xda, 0x1c, 0x64, 0x6e, 0x2f)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_SPDIF" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_SPDIFTest()
        {
            Assert.That(MFCONNECTOR_SPDIF, Is.EqualTo(new Guid(0xb94a712, 0xad3e, 0x4cee, 0x83, 0xce, 0xce, 0x32, 0xe3, 0xdb, 0x65, 0x22)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_UNKNOWN" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_UNKNOWNTest()
        {
            Assert.That(MFCONNECTOR_UNKNOWN, Is.EqualTo(new Guid(0xac3aef5c, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_PCI" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_PCITest()
        {
            Assert.That(MFCONNECTOR_PCI, Is.EqualTo(new Guid(0xac3aef5d, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_PCIX" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_PCIXTest()
        {
            Assert.That(MFCONNECTOR_PCIX, Is.EqualTo(new Guid(0xac3aef5e, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_PCI_Express" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_PCI_ExpressTest()
        {
            Assert.That(MFCONNECTOR_PCI_Express, Is.EqualTo(new Guid(0xac3aef5f, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_AGP" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_AGPTest()
        {
            Assert.That(MFCONNECTOR_AGP, Is.EqualTo(new Guid(0xac3aef60, 0xce43, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_VGA" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_VGATest()
        {
            Assert.That(MFCONNECTOR_VGA, Is.EqualTo(new Guid(0x57cd5968, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_SVIDEO" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_SVIDEOTest()
        {
            Assert.That(MFCONNECTOR_SVIDEO, Is.EqualTo(new Guid(0x57cd5969, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_COMPOSITE" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_COMPOSITETest()
        {
            Assert.That(MFCONNECTOR_COMPOSITE, Is.EqualTo(new Guid(0x57cd596a, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_COMPONENT" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_COMPONENTTest()
        {
            Assert.That(MFCONNECTOR_COMPONENT, Is.EqualTo(new Guid(0x57cd596b, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_DVI" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_DVITest()
        {
            Assert.That(MFCONNECTOR_DVI, Is.EqualTo(new Guid(0x57cd596c, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_HDMI" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_HDMITest()
        {
            Assert.That(MFCONNECTOR_HDMI, Is.EqualTo(new Guid(0x57cd596d, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_LVDS" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_LVDSTest()
        {
            Assert.That(MFCONNECTOR_LVDS, Is.EqualTo(new Guid(0x57cd596e, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_D_JPN" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_D_JPNTest()
        {
            Assert.That(MFCONNECTOR_D_JPN, Is.EqualTo(new Guid(0x57cd5970, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_SDI" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_SDITest()
        {
            Assert.That(MFCONNECTOR_SDI, Is.EqualTo(new Guid(0x57cd5971, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_DISPLAYPORT_EXTERNAL" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_DISPLAYPORT_EXTERNALTest()
        {
            Assert.That(MFCONNECTOR_DISPLAYPORT_EXTERNAL, Is.EqualTo(new Guid(0x57cd5972, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_DISPLAYPORT_EMBEDDED" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_DISPLAYPORT_EMBEDDEDTest()
        {
            Assert.That(MFCONNECTOR_DISPLAYPORT_EMBEDDED, Is.EqualTo(new Guid(0x57cd5973, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_UDI_EXTERNAL" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_UDI_EXTERNALTest()
        {
            Assert.That(MFCONNECTOR_UDI_EXTERNAL, Is.EqualTo(new Guid(0x57cd5974, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_UDI_EMBEDDED" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_UDI_EMBEDDEDTest()
        {
            Assert.That(MFCONNECTOR_UDI_EMBEDDED, Is.EqualTo(new Guid(0x57cd5975, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_MIRACAST" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_MIRACASTTest()
        {
            Assert.That(MFCONNECTOR_MIRACAST, Is.EqualTo(new Guid(0x57cd5977, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_ATest()
        {
            Assert.That(MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_A, Is.EqualTo(new Guid(0x57cd5978, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B" /> property is correct.</summary>
        [Test]
        public static void MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_BTest()
        {
            Assert.That(MFCONNECTOR_TRANSPORT_AGNOSTIC_DIGITAL_MODE_B, Is.EqualTo(new Guid(0x57cd5979, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_DISABLE" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_DISABLETest()
        {
            Assert.That(MFPROTECTION_DISABLE, Is.EqualTo(new Guid(0x8cc6d81b, 0xfec6, 0x4d8f, 0x96, 0x4b, 0xcf, 0xba, 0x0b, 0x0d, 0xad, 0x0d)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_CONSTRICTVIDEO" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_CONSTRICTVIDEOTest()
        {
            Assert.That(MFPROTECTION_CONSTRICTVIDEO, Is.EqualTo(new Guid(0x193370ce, 0xc5e4, 0x4c3a, 0x8a, 0x66, 0x69, 0x59, 0xb4, 0xda, 0x44, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_CONSTRICTVIDEO_NOOPM" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_CONSTRICTVIDEO_NOOPMTest()
        {
            Assert.That(MFPROTECTION_CONSTRICTVIDEO_NOOPM, Is.EqualTo(new Guid(0xa580e8cd, 0xc247, 0x4957, 0xb9, 0x83, 0x3c, 0x2e, 0xeb, 0xd1, 0xff, 0x59)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_CONSTRICTAUDIO" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_CONSTRICTAUDIOTest()
        {
            Assert.That(MFPROTECTION_CONSTRICTAUDIO, Is.EqualTo(new Guid(0xffc99b44, 0xdf48, 0x4e16, 0x8e, 0x66, 0x09, 0x68, 0x92, 0xc1, 0x57, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_TRUSTEDAUDIODRIVERS" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_TRUSTEDAUDIODRIVERSTest()
        {
            Assert.That(MFPROTECTION_TRUSTEDAUDIODRIVERS, Is.EqualTo(new Guid(0x65bdf3d2, 0x0168, 0x4816, 0xa5, 0x33, 0x55, 0xd4, 0x7b, 0x02, 0x71, 0x01)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_HDCP" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_HDCPTest()
        {
            Assert.That(MFPROTECTION_HDCP, Is.EqualTo(new Guid(0xAE7CC03D, 0xC828, 0x4021, 0xac, 0xb7, 0xd5, 0x78, 0xd2, 0x7a, 0xaf, 0x13)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_CGMSA" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_CGMSATest()
        {
            Assert.That(MFPROTECTION_CGMSA, Is.EqualTo(new Guid(0xE57E69E9, 0x226B, 0x4d31, 0xB4, 0xE3, 0xD3, 0xDB, 0x00, 0x87, 0x36, 0xDD)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_ACP" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_ACPTest()
        {
            Assert.That(MFPROTECTION_ACP, Is.EqualTo(new Guid(0xc3fd11c6, 0xf8b7, 0x4d20, 0xb0, 0x08, 0x1d, 0xb1, 0x7d, 0x61, 0xf2, 0xda)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_WMDRMOTA" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_WMDRMOTATest()
        {
            Assert.That(MFPROTECTION_WMDRMOTA, Is.EqualTo(new Guid(0xa267a6a1, 0x362e, 0x47d0, 0x88, 0x05, 0x46, 0x28, 0x59, 0x8a, 0x23, 0xe4)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_FFT" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_FFTTest()
        {
            Assert.That(MFPROTECTION_FFT, Is.EqualTo(new Guid(0x462a56b2, 0x2866, 0x4bb6, 0x98, 0x0d, 0x6d, 0x8d, 0x9e, 0xdb, 0x1a, 0x8c)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_PROTECTED_SURFACE" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_PROTECTED_SURFACETest()
        {
            Assert.That(MFPROTECTION_PROTECTED_SURFACE, Is.EqualTo(new Guid(0x4f5d9566, 0xe742, 0x4a25, 0x8d, 0x1f, 0xd2, 0x87, 0xb5, 0xfa, 0x0a, 0xde)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_DISABLE_SCREEN_SCRAPE" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_DISABLE_SCREEN_SCRAPETest()
        {
            Assert.That(MFPROTECTION_DISABLE_SCREEN_SCRAPE, Is.EqualTo(new Guid(0xa21179a4, 0xb7cd, 0x40d8, 0x96, 0x14, 0x8e, 0xf2, 0x37, 0x1b, 0xa7, 0x8d)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_VIDEO_FRAMES" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_VIDEO_FRAMESTest()
        {
            Assert.That(MFPROTECTION_VIDEO_FRAMES, Is.EqualTo(new Guid(0x36a59cbc, 0x7401, 0x4a8c, 0xbc, 0x20, 0x46, 0xa7, 0xc9, 0xe5, 0x97, 0xf0)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_HARDWARE" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_HARDWARETest()
        {
            Assert.That(MFPROTECTION_HARDWARE, Is.EqualTo(new Guid(0x4ee7f0c1, 0x9ed7, 0x424f, 0xb6, 0xbe, 0x99, 0x6b, 0x33, 0x52, 0x88, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENT" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENTTest()
        {
            Assert.That(MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENT, Is.EqualTo(new Guid(0xa4a585e8, 0xed60, 0x442d, 0x81, 0x4d, 0xdb, 0x4d, 0x42, 0x20, 0xa0, 0x6d)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTIONATTRIBUTE_BEST_EFFORT" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTIONATTRIBUTE_BEST_EFFORTTest()
        {
            Assert.That(MFPROTECTIONATTRIBUTE_BEST_EFFORT, Is.EqualTo(new Guid(0xc8e06331, 0x75f0, 0x4ec1, 0x8e, 0x77, 0x17, 0x57, 0x8f, 0x77, 0x3b, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTIONATTRIBUTE_FAIL_OVER" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTIONATTRIBUTE_FAIL_OVERTest()
        {
            Assert.That(MFPROTECTIONATTRIBUTE_FAIL_OVER, Is.EqualTo(new Guid(0x8536abc5, 0x38f1, 0x4151, 0x9c, 0xce, 0xf5, 0x5d, 0x94, 0x12, 0x29, 0xac)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTIONTest()
        {
            Assert.That(MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION, Is.EqualTo(new Guid(0xc873de64, 0xd8a5, 0x49e6, 0x88, 0xbb, 0xfb, 0x96, 0x3f, 0xd3, 0xd4, 0xce)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZETest()
        {
            Assert.That(MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE, Is.EqualTo(new Guid(0x8476fc, 0x4b58, 0x4d80, 0xa7, 0x90, 0xe7, 0x29, 0x76, 0x73, 0x16, 0x1d)));
        }

        /// <summary>Validates that the value of the <see cref="MFPROTECTIONATTRIBUTE_HDCP_SRM" /> property is correct.</summary>
        [Test]
        public static void MFPROTECTIONATTRIBUTE_HDCP_SRMTest()
        {
            Assert.That(MFPROTECTIONATTRIBUTE_HDCP_SRM, Is.EqualTo(new Guid(0x6f302107, 0x3477, 0x4468, 0x8a, 0x8, 0xee, 0xf9, 0xdb, 0x10, 0xe2, 0xf)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_ASF" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_ASFTest()
        {
            Assert.That(MFTranscodeContainerType_ASF, Is.EqualTo(new Guid(0x430f6f6e, 0xb6bf, 0x4fc1, 0xa0, 0xbd, 0x9e, 0xe4, 0x6e, 0xee, 0x2a, 0xfb)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_MPEG4" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_MPEG4Test()
        {
            Assert.That(MFTranscodeContainerType_MPEG4, Is.EqualTo(new Guid(0xdc6cd05d, 0xb9d0, 0x40ef, 0xbd, 0x35, 0xfa, 0x62, 0x2c, 0x1a, 0xb2, 0x8a)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_MP3" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_MP3Test()
        {
            Assert.That(MFTranscodeContainerType_MP3, Is.EqualTo(new Guid(0xe438b912, 0x83f1, 0x4de6, 0x9e, 0x3a, 0x9f, 0xfb, 0xc6, 0xdd, 0x24, 0xd1)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_FLAC" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_FLACTest()
        {
            Assert.That(MFTranscodeContainerType_FLAC, Is.EqualTo(new Guid(0x31344aa3, 0x05a9, 0x42b5, 0x90, 0x1b, 0x8e, 0x9d, 0x42, 0x57, 0xf7, 0x5e)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_3GP" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_3GPTest()
        {
            Assert.That(MFTranscodeContainerType_3GP, Is.EqualTo(new Guid(0x34c50167, 0x4472, 0x4f34, 0x9e, 0xa0, 0xc4, 0x9f, 0xba, 0xcf, 0x03, 0x7d)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_AC3" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_AC3Test()
        {
            Assert.That(MFTranscodeContainerType_AC3, Is.EqualTo(new Guid(0x6d8d91c3, 0x8c91, 0x4ed1, 0x87, 0x42, 0x8c, 0x34, 0x7d, 0x5b, 0x44, 0xd0)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_ADTS" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_ADTSTest()
        {
            Assert.That(MFTranscodeContainerType_ADTS, Is.EqualTo(new Guid(0x132fd27d, 0x0f02, 0x43de, 0xa3, 0x01, 0x38, 0xfb, 0xbb, 0xb3, 0x83, 0x4e)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_MPEG2" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_MPEG2Test()
        {
            Assert.That(MFTranscodeContainerType_MPEG2, Is.EqualTo(new Guid(0xbfc2dbf9, 0x7bb4, 0x4f8f, 0xaf, 0xde, 0xe1, 0x12, 0xc4, 0x4b, 0xa8, 0x82)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_WAVE" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_WAVETest()
        {
            Assert.That(MFTranscodeContainerType_WAVE, Is.EqualTo(new Guid(0x64c3453c, 0x0f26, 0x4741, 0xbe, 0x63, 0x87, 0xbd, 0xf8, 0xbb, 0x93, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_AVI" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_AVITest()
        {
            Assert.That(MFTranscodeContainerType_AVI, Is.EqualTo(new Guid(0x7edfe8af, 0x402f, 0x4d76, 0xa3, 0x3c, 0x61, 0x9f, 0xd1, 0x57, 0xd0, 0xf1)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_FMPEG4" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_FMPEG4Test()
        {
            Assert.That(MFTranscodeContainerType_FMPEG4, Is.EqualTo(new Guid(0x9ba876f1, 0x419f, 0x4b77, 0xa1, 0xe0, 0x35, 0x95, 0x9d, 0x9d, 0x40, 0x4)));
        }

        /// <summary>Validates that the value of the <see cref="MFTranscodeContainerType_AMR" /> property is correct.</summary>
        [Test]
        public static void MFTranscodeContainerType_AMRTest()
        {
            Assert.That(MFTranscodeContainerType_AMR, Is.EqualTo(new Guid(0x25d5ad3, 0x621a, 0x475b, 0x96, 0x4d, 0x66, 0xb1, 0xc8, 0x24, 0xf0, 0x79)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_DeviceTimestamp" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_DeviceTimestampTest()
        {
            Assert.That(MFSampleExtension_DeviceTimestamp, Is.EqualTo(new Guid(0x8f3e35e7, 0x2dcd, 0x4887, 0x86, 0x22, 0x2a, 0x58, 0xba, 0xa6, 0x52, 0xb0)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Spatial_CameraViewTransform" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Spatial_CameraViewTransformTest()
        {
            Assert.That(MFSampleExtension_Spatial_CameraViewTransform, Is.EqualTo(new Guid(0x4e251fa4, 0x830f, 0x4770, 0x85, 0x9a, 0x4b, 0x8d, 0x99, 0xaa, 0x80, 0x9b)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Spatial_CameraCoordinateSystem" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Spatial_CameraCoordinateSystemTest()
        {
            Assert.That(MFSampleExtension_Spatial_CameraCoordinateSystem, Is.EqualTo(new Guid(0x9d13c82f, 0x2199, 0x4e67, 0x91, 0xcd, 0xd1, 0xa4, 0x18, 0x1f, 0x25, 0x34)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_Spatial_CameraProjectionTransform" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_Spatial_CameraProjectionTransformTest()
        {
            Assert.That(MFSampleExtension_Spatial_CameraProjectionTransform, Is.EqualTo(new Guid(0x47f9fcb5, 0x2a02, 0x4f26, 0xa4, 0x77, 0x79, 0x2f, 0xdf, 0x95, 0x88, 0x6a)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_CROSS_ORIGIN_SUPPORT" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_CROSS_ORIGIN_SUPPORTTest()
        {
            Assert.That(MFNETSOURCE_CROSS_ORIGIN_SUPPORT, Is.EqualTo(new Guid(0x9842207c, 0xb02c, 0x4271, 0xa2, 0xfc, 0x72, 0xe4, 0x93, 0x8, 0xe5, 0xc2)));
        }

        /// <summary>Validates that the value of the <see cref="MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDER" /> property is correct.</summary>
        [Test]
        public static void MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDERTest()
        {
            Assert.That(MFNETSOURCE_HTTP_DOWNLOAD_SESSION_PROVIDER, Is.EqualTo(new Guid(0x7d55081e, 0x307d, 0x4d6d, 0xa6, 0x63, 0xa9, 0x3b, 0xe9, 0x7c, 0x4b, 0x5c)));
        }

        /// <summary>Validates that the value of the <see cref="MFStreamExtension_ExtendedCameraIntrinsics" /> property is correct.</summary>
        [Test]
        public static void MFStreamExtension_ExtendedCameraIntrinsicsTest()
        {
            Assert.That(MFStreamExtension_ExtendedCameraIntrinsics, Is.EqualTo(new Guid(0xaa74b3df, 0x9a2c, 0x48d6, 0x83, 0x93, 0x5b, 0xd1, 0xc1, 0xa8, 0x1e, 0x6e)));
        }

        /// <summary>Validates that the value of the <see cref="MFSampleExtension_ExtendedCameraIntrinsics" /> property is correct.</summary>
        [Test]
        public static void MFSampleExtension_ExtendedCameraIntrinsicsTest()
        {
            Assert.That(MFSampleExtension_ExtendedCameraIntrinsics, Is.EqualTo(new Guid(0x560bc4a5, 0x4de0, 0x4113, 0x9c, 0xdc, 0x83, 0x2d, 0xb9, 0x74, 0xf, 0x3d)));
        }
    }
}
