// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.MFVideoInterlaceMode;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int MEUnknown = 0;

        public const int MEError = 1;

        public const int MEExtendedType = 2;

        public const int MENonFatalError = 3;

        public const int MEGenericV1Anchor = MENonFatalError;

        public const int MESessionUnknown = 100;

        public const int MESessionTopologySet = 101;

        public const int MESessionTopologiesCleared = 102;

        public const int MESessionStarted = 103;

        public const int MESessionPaused = 104;

        public const int MESessionStopped = 105;

        public const int MESessionClosed = 106;

        public const int MESessionEnded = 107;

        public const int MESessionRateChanged = 108;

        public const int MESessionScrubSampleComplete = 109;

        public const int MESessionCapabilitiesChanged = 110;

        public const int MESessionTopologyStatus = 111;

        public const int MESessionNotifyPresentationTime = 112;

        public const int MENewPresentation = 113;

        public const int MELicenseAcquisitionStart = 114;

        public const int MELicenseAcquisitionCompleted = 115;

        public const int MEIndividualizationStart = 116;

        public const int MEIndividualizationCompleted = 117;

        public const int MEEnablerProgress = 118;

        public const int MEEnablerCompleted = 119;

        public const int MEPolicyError = 120;

        public const int MEPolicyReport = 121;

        public const int MEBufferingStarted = 122;

        public const int MEBufferingStopped = 123;

        public const int MEConnectStart = 124;

        public const int MEConnectEnd = 125;

        public const int MEReconnectStart = 126;

        public const int MEReconnectEnd = 127;

        public const int MERendererEvent = 128;

        public const int MESessionStreamSinkFormatChanged = 129;

        public const int MESessionV1Anchor = MESessionStreamSinkFormatChanged;

        public const int MESourceUnknown = 200;

        public const int MESourceStarted = 201;

        public const int MEStreamStarted = 202;

        public const int MESourceSeeked = 203;

        public const int MEStreamSeeked = 204;

        public const int MENewStream = 205;

        public const int MEUpdatedStream = 206;

        public const int MESourceStopped = 207;

        public const int MEStreamStopped = 208;

        public const int MESourcePaused = 209;

        public const int MEStreamPaused = 210;

        public const int MEEndOfPresentation = 211;

        public const int MEEndOfStream = 212;

        public const int MEMediaSample = 213;

        public const int MEStreamTick = 214;

        public const int MEStreamThinMode = 215;

        public const int MEStreamFormatChanged = 216;

        public const int MESourceRateChanged = 217;

        public const int MEEndOfPresentationSegment = 218;

        public const int MESourceCharacteristicsChanged = 219;

        public const int MESourceRateChangeRequested = 220;

        public const int MESourceMetadataChanged = 221;

        public const int MESequencerSourceTopologyUpdated = 222;

        public const int MESourceV1Anchor = MESequencerSourceTopologyUpdated;

        public const int MESinkUnknown = 300;

        public const int MEStreamSinkStarted = 301;

        public const int MEStreamSinkStopped = 302;

        public const int MEStreamSinkPaused = 303;

        public const int MEStreamSinkRateChanged = 304;

        public const int MEStreamSinkRequestSample = 305;

        public const int MEStreamSinkMarker = 306;

        public const int MEStreamSinkPrerolled = 307;

        public const int MEStreamSinkScrubSampleComplete = 308;

        public const int MEStreamSinkFormatChanged = 309;

        public const int MEStreamSinkDeviceChanged = 310;

        public const int MEQualityNotify = 311;

        public const int MESinkInvalidated = 312;

        public const int MEAudioSessionNameChanged = 313;

        public const int MEAudioSessionVolumeChanged = 314;

        public const int MEAudioSessionDeviceRemoved = 315;

        public const int MEAudioSessionServerShutdown = 316;

        public const int MEAudioSessionGroupingParamChanged = 317;

        public const int MEAudioSessionIconChanged = 318;

        public const int MEAudioSessionFormatChanged = 319;

        public const int MEAudioSessionDisconnected = 320;

        public const int MEAudioSessionExclusiveModeOverride = 321;

        public const int MESinkV1Anchor = MEAudioSessionExclusiveModeOverride;

        public const int MECaptureAudioSessionVolumeChanged = 322;

        public const int MECaptureAudioSessionDeviceRemoved = 323;

        public const int MECaptureAudioSessionFormatChanged = 324;

        public const int MECaptureAudioSessionDisconnected = 325;

        public const int MECaptureAudioSessionExclusiveModeOverride = 326;

        public const int MECaptureAudioSessionServerShutdown = 327;

        public const int MESinkV2Anchor = MECaptureAudioSessionServerShutdown;

        public const int METrustUnknown = 400;

        public const int MEPolicyChanged = 401;

        public const int MEContentProtectionMessage = 402;

        public const int MEPolicySet = 403;

        public const int METrustV1Anchor = MEPolicySet;

        public const int MEWMDRMLicenseBackupCompleted = 500;

        public const int MEWMDRMLicenseBackupProgress = 501;

        public const int MEWMDRMLicenseRestoreCompleted = 502;

        public const int MEWMDRMLicenseRestoreProgress = 503;

        public const int MEWMDRMLicenseAcquisitionCompleted = 506;

        public const int MEWMDRMIndividualizationCompleted = 508;

        public const int MEWMDRMIndividualizationProgress = 513;

        public const int MEWMDRMProximityCompleted = 514;

        public const int MEWMDRMLicenseStoreCleaned = 515;

        public const int MEWMDRMRevocationDownloadCompleted = 516;

        public const int MEWMDRMV1Anchor = MEWMDRMRevocationDownloadCompleted;

        public const int METransformUnknown = 600;

        public const int METransformNeedInput = (METransformUnknown + 1);

        public const int METransformHaveOutput = (METransformNeedInput + 1);

        public const int METransformDrainComplete = (METransformHaveOutput + 1);

        public const int METransformMarker = (METransformDrainComplete + 1);

        public const int METransformInputStreamStateChanged = (METransformMarker + 1);

        public const int MEByteStreamCharacteristicsChanged = 700;

        public const int MEVideoCaptureDeviceRemoved = 800;

        public const int MEVideoCaptureDevicePreempted = 801;

        public const int MEStreamSinkFormatInvalidated = 802;

        public const int MEEncodingParameters = 803;

        public const int MEContentProtectionMetadata = 900;

        public const int MEDeviceThermalStateChanged = 950;

        public const int MEReservedMax = 10000;

        public static readonly Guid IID_IMFAttributes = new Guid(0x2CD2D921, 0xC447, 0x44A7, 0xA1, 0x3C, 0x4A, 0xDA, 0xBF, 0xC2, 0x47, 0xE3);

        public static readonly Guid IID_IMFMediaBuffer = new Guid(0x045FA593, 0x8799, 0x42B8, 0xBC, 0x8D, 0x89, 0x68, 0xC6, 0x45, 0x35, 0x07);

        public static readonly Guid IID_IMFSample = new Guid(0xC40A00F2, 0xB93A, 0x4D80, 0xAE, 0x8C, 0x5A, 0x1C, 0x63, 0x4F, 0x58, 0xE4);

        public static readonly Guid IID_IMF2DBuffer = new Guid(0x7DC9D5F9, 0x9ED9, 0x44EC, 0x9B, 0xBF, 0x06, 0x00, 0xBB, 0x58, 0x9F, 0xBB);

        public static readonly Guid IID_IMF2DBuffer2 = new Guid(0x33AE5EA6, 0x4316, 0x436F, 0x8D, 0xDD, 0xD7, 0x3D, 0x22, 0xF8, 0x29, 0xEC);

        public static readonly Guid IID_IMFDXGIBuffer = new Guid(0xE7174CFA, 0x1C9E, 0x48B1, 0x88, 0x66, 0x62, 0x62, 0x26, 0xBF, 0xC2, 0x58);

        public static readonly Guid IID_IMFMediaType = new Guid(0x44AE0FA8, 0xEA31, 0x4109, 0x8D, 0x2E, 0x4C, 0xAE, 0x49, 0x97, 0xC5, 0x55);

        public static readonly Guid IID_IMFAudioMediaType = new Guid(0x26A0ADC3, 0xCE26, 0x4672, 0x93, 0x04, 0x69, 0x55, 0x2E, 0xDD, 0x3F, 0xAF);

        public static readonly Guid IID_IMFVideoMediaType = new Guid(0xB99F381F, 0xA8F9, 0x47A2, 0xA5, 0xAF, 0xCA, 0x3A, 0x22, 0x5A, 0x38, 0x90);

        public static readonly Guid IID_IMFAsyncResult = new Guid(0xAC6B7889, 0x0740, 0x4D51, 0x86, 0x19, 0x90, 0x59, 0x94, 0xA5, 0x5C, 0xC6);

        public static readonly Guid IID_IMFAsyncCallback = new Guid(0xA27003CF, 0x2354, 0x4F2A, 0x8D, 0x6A, 0xAB, 0x7C, 0xFF, 0x15, 0x43, 0x7E);

        public static readonly Guid IID_IMFAsyncCallbackLogging = new Guid(0xC7A4DCA1, 0xF5F0, 0x47B6, 0xB9, 0x2B, 0xBF, 0x01, 0x06, 0xD2, 0x57, 0x91);

        public static readonly Guid IID_IMFMediaEvent = new Guid(0xDF598932, 0xF10C, 0x4E39, 0xBB, 0xA2, 0xC3, 0x08, 0xF1, 0x01, 0xDA, 0xA3);

        public static readonly Guid IID_IMFMediaEventGenerator = new Guid(0x2CD0BD52, 0xBCD5, 0x4B89, 0xB6, 0x2C, 0xEA, 0xDC, 0x0C, 0x03, 0x1E, 0x7D);

        public static readonly Guid IID_IMFRemoteAsyncCallback = new Guid(0xA27003D0, 0x2354, 0x4F2A, 0x8D, 0x6A, 0xAB, 0x7C, 0xFF, 0x15, 0x43, 0x7E);

        public static readonly Guid IID_IMFByteStream = new Guid(0xAD4C1B00, 0x4BF7, 0x422F, 0x91, 0x75, 0x75, 0x66, 0x93, 0xD9, 0x13, 0x0D);

        public static readonly Guid IID_IMFByteStreamProxyClassFactory = new Guid(0xA6B43F84, 0x5C0A, 0x42E8, 0xA4, 0x4D, 0xB1, 0x85, 0x7A, 0x76, 0x99, 0x2F);

        public static readonly Guid IID_IMFSampleOutputStream = new Guid(0x8FEED468, 0x6F7E, 0x440D, 0x86, 0x9A, 0x49, 0xBD, 0xD2, 0x83, 0xAD, 0x0D);

        public static readonly Guid IID_IMFCollection = new Guid(0x5BC8A76B, 0x869A, 0x46A3, 0x9B, 0x03, 0xFA, 0x21, 0x8A, 0x66, 0xAE, 0xBE);

        public static readonly Guid IID_IMFMediaEventQueue = new Guid(0x36F846FC, 0x2256, 0x48B6, 0xB5, 0x8E, 0xE2, 0xB6, 0x38, 0x31, 0x65, 0x81);

        public static readonly Guid IID_IMFActivate = new Guid(0x7FEE9E9A, 0x4A89, 0x47A6, 0x89, 0x9C, 0xB6, 0xA5, 0x3A, 0x70, 0xFB, 0x67);

        public static readonly Guid IID_IMFPluginControl = new Guid(0x5C6C44BF, 0x1DB6, 0x435B, 0x92, 0x49, 0xE8, 0xCD, 0x10, 0xFD, 0xEC, 0x96);

        public static readonly Guid IID_IMFPluginControl2 = new Guid(0xC6982083, 0x3DDC, 0x45CB, 0xAF, 0x5E, 0x0F, 0x7A, 0x8C, 0xE4, 0xDE, 0x77);

        public static readonly Guid IID_IMFDXGIDeviceManager = new Guid(0xEB533D5D, 0x2DB6, 0x40F8, 0x97, 0xA9, 0x49, 0x46, 0x92, 0x01, 0x4F, 0x07);

        public static readonly Guid IID_IMFMuxStreamAttributesManager = new Guid(0xCE8BD576, 0xE440, 0x43B3, 0xBE, 0x34, 0x1E, 0x53, 0xF5, 0x65, 0xF7, 0xE8);

        public static readonly Guid IID_IMFMuxStreamMediaTypeManager = new Guid(0x505A2C72, 0x42F7, 0x4690, 0xAE, 0xAB, 0x8F, 0x51, 0x3D, 0x0F, 0xFD, 0xB8);

        public static readonly Guid IID_IMFMuxStreamSampleManager = new Guid(0x74ABBC19, 0xB1CC, 0x4E41, 0xBB, 0x8B, 0x9D, 0x9B, 0x86, 0xA8, 0xF6, 0xCA);

        public static readonly Guid IID_IMFSecureBuffer = new Guid(0xC1209904, 0xE584, 0x4752, 0xA2, 0xD6, 0x7F, 0x21, 0x69, 0x3F, 0x8B, 0x21);
    }
}
