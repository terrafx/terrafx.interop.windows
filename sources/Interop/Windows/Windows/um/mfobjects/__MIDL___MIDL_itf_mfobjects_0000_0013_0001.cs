// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001"]/*' />
public enum __MIDL___MIDL_itf_mfobjects_0000_0013_0001
{
    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEUnknown"]/*' />
    MEUnknown = 0,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEError"]/*' />
    MEError = 1,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEExtendedType"]/*' />
    MEExtendedType = 2,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MENonFatalError"]/*' />
    MENonFatalError = 3,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEGenericV1Anchor"]/*' />
    MEGenericV1Anchor = MENonFatalError,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionUnknown"]/*' />
    MESessionUnknown = 100,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionTopologySet"]/*' />
    MESessionTopologySet = 101,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionTopologiesCleared"]/*' />
    MESessionTopologiesCleared = 102,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionStarted"]/*' />
    MESessionStarted = 103,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionPaused"]/*' />
    MESessionPaused = 104,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionStopped"]/*' />
    MESessionStopped = 105,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionClosed"]/*' />
    MESessionClosed = 106,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionEnded"]/*' />
    MESessionEnded = 107,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionRateChanged"]/*' />
    MESessionRateChanged = 108,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionScrubSampleComplete"]/*' />
    MESessionScrubSampleComplete = 109,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionCapabilitiesChanged"]/*' />
    MESessionCapabilitiesChanged = 110,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionTopologyStatus"]/*' />
    MESessionTopologyStatus = 111,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionNotifyPresentationTime"]/*' />
    MESessionNotifyPresentationTime = 112,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MENewPresentation"]/*' />
    MENewPresentation = 113,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MELicenseAcquisitionStart"]/*' />
    MELicenseAcquisitionStart = 114,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MELicenseAcquisitionCompleted"]/*' />
    MELicenseAcquisitionCompleted = 115,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEIndividualizationStart"]/*' />
    MEIndividualizationStart = 116,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEIndividualizationCompleted"]/*' />
    MEIndividualizationCompleted = 117,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEEnablerProgress"]/*' />
    MEEnablerProgress = 118,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEEnablerCompleted"]/*' />
    MEEnablerCompleted = 119,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEPolicyError"]/*' />
    MEPolicyError = 120,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEPolicyReport"]/*' />
    MEPolicyReport = 121,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEBufferingStarted"]/*' />
    MEBufferingStarted = 122,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEBufferingStopped"]/*' />
    MEBufferingStopped = 123,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEConnectStart"]/*' />
    MEConnectStart = 124,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEConnectEnd"]/*' />
    MEConnectEnd = 125,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEReconnectStart"]/*' />
    MEReconnectStart = 126,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEReconnectEnd"]/*' />
    MEReconnectEnd = 127,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MERendererEvent"]/*' />
    MERendererEvent = 128,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionStreamSinkFormatChanged"]/*' />
    MESessionStreamSinkFormatChanged = 129,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESessionV1Anchor"]/*' />
    MESessionV1Anchor = MESessionStreamSinkFormatChanged,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceUnknown"]/*' />
    MESourceUnknown = 200,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceStarted"]/*' />
    MESourceStarted = 201,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamStarted"]/*' />
    MEStreamStarted = 202,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceSeeked"]/*' />
    MESourceSeeked = 203,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSeeked"]/*' />
    MEStreamSeeked = 204,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MENewStream"]/*' />
    MENewStream = 205,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEUpdatedStream"]/*' />
    MEUpdatedStream = 206,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceStopped"]/*' />
    MESourceStopped = 207,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamStopped"]/*' />
    MEStreamStopped = 208,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourcePaused"]/*' />
    MESourcePaused = 209,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamPaused"]/*' />
    MEStreamPaused = 210,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEEndOfPresentation"]/*' />
    MEEndOfPresentation = 211,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEEndOfStream"]/*' />
    MEEndOfStream = 212,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEMediaSample"]/*' />
    MEMediaSample = 213,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamTick"]/*' />
    MEStreamTick = 214,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamThinMode"]/*' />
    MEStreamThinMode = 215,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamFormatChanged"]/*' />
    MEStreamFormatChanged = 216,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceRateChanged"]/*' />
    MESourceRateChanged = 217,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEEndOfPresentationSegment"]/*' />
    MEEndOfPresentationSegment = 218,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceCharacteristicsChanged"]/*' />
    MESourceCharacteristicsChanged = 219,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceRateChangeRequested"]/*' />
    MESourceRateChangeRequested = 220,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceMetadataChanged"]/*' />
    MESourceMetadataChanged = 221,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESequencerSourceTopologyUpdated"]/*' />
    MESequencerSourceTopologyUpdated = 222,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESourceV1Anchor"]/*' />
    MESourceV1Anchor = MESequencerSourceTopologyUpdated,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESinkUnknown"]/*' />
    MESinkUnknown = 300,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkStarted"]/*' />
    MEStreamSinkStarted = 301,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkStopped"]/*' />
    MEStreamSinkStopped = 302,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkPaused"]/*' />
    MEStreamSinkPaused = 303,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkRateChanged"]/*' />
    MEStreamSinkRateChanged = 304,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkRequestSample"]/*' />
    MEStreamSinkRequestSample = 305,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkMarker"]/*' />
    MEStreamSinkMarker = 306,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkPrerolled"]/*' />
    MEStreamSinkPrerolled = 307,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkScrubSampleComplete"]/*' />
    MEStreamSinkScrubSampleComplete = 308,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkFormatChanged"]/*' />
    MEStreamSinkFormatChanged = 309,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkDeviceChanged"]/*' />
    MEStreamSinkDeviceChanged = 310,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEQualityNotify"]/*' />
    MEQualityNotify = 311,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESinkInvalidated"]/*' />
    MESinkInvalidated = 312,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionNameChanged"]/*' />
    MEAudioSessionNameChanged = 313,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionVolumeChanged"]/*' />
    MEAudioSessionVolumeChanged = 314,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionDeviceRemoved"]/*' />
    MEAudioSessionDeviceRemoved = 315,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionServerShutdown"]/*' />
    MEAudioSessionServerShutdown = 316,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionGroupingParamChanged"]/*' />
    MEAudioSessionGroupingParamChanged = 317,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionIconChanged"]/*' />
    MEAudioSessionIconChanged = 318,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionFormatChanged"]/*' />
    MEAudioSessionFormatChanged = 319,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionDisconnected"]/*' />
    MEAudioSessionDisconnected = 320,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEAudioSessionExclusiveModeOverride"]/*' />
    MEAudioSessionExclusiveModeOverride = 321,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESinkV1Anchor"]/*' />
    MESinkV1Anchor = MEAudioSessionExclusiveModeOverride,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MECaptureAudioSessionVolumeChanged"]/*' />
    MECaptureAudioSessionVolumeChanged = 322,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MECaptureAudioSessionDeviceRemoved"]/*' />
    MECaptureAudioSessionDeviceRemoved = 323,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MECaptureAudioSessionFormatChanged"]/*' />
    MECaptureAudioSessionFormatChanged = 324,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MECaptureAudioSessionDisconnected"]/*' />
    MECaptureAudioSessionDisconnected = 325,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MECaptureAudioSessionExclusiveModeOverride"]/*' />
    MECaptureAudioSessionExclusiveModeOverride = 326,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MECaptureAudioSessionServerShutdown"]/*' />
    MECaptureAudioSessionServerShutdown = 327,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MESinkV2Anchor"]/*' />
    MESinkV2Anchor = MECaptureAudioSessionServerShutdown,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METrustUnknown"]/*' />
    METrustUnknown = 400,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEPolicyChanged"]/*' />
    MEPolicyChanged = 401,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEContentProtectionMessage"]/*' />
    MEContentProtectionMessage = 402,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEPolicySet"]/*' />
    MEPolicySet = 403,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METrustV1Anchor"]/*' />
    METrustV1Anchor = MEPolicySet,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMLicenseBackupCompleted"]/*' />
    MEWMDRMLicenseBackupCompleted = 500,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMLicenseBackupProgress"]/*' />
    MEWMDRMLicenseBackupProgress = 501,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMLicenseRestoreCompleted"]/*' />
    MEWMDRMLicenseRestoreCompleted = 502,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMLicenseRestoreProgress"]/*' />
    MEWMDRMLicenseRestoreProgress = 503,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMLicenseAcquisitionCompleted"]/*' />
    MEWMDRMLicenseAcquisitionCompleted = 506,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMIndividualizationCompleted"]/*' />
    MEWMDRMIndividualizationCompleted = 508,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMIndividualizationProgress"]/*' />
    MEWMDRMIndividualizationProgress = 513,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMProximityCompleted"]/*' />
    MEWMDRMProximityCompleted = 514,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMLicenseStoreCleaned"]/*' />
    MEWMDRMLicenseStoreCleaned = 515,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMRevocationDownloadCompleted"]/*' />
    MEWMDRMRevocationDownloadCompleted = 516,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEWMDRMV1Anchor"]/*' />
    MEWMDRMV1Anchor = MEWMDRMRevocationDownloadCompleted,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METransformUnknown"]/*' />
    METransformUnknown = 600,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METransformNeedInput"]/*' />
    METransformNeedInput = (METransformUnknown + 1),

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METransformHaveOutput"]/*' />
    METransformHaveOutput = (METransformNeedInput + 1),

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METransformDrainComplete"]/*' />
    METransformDrainComplete = (METransformHaveOutput + 1),

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METransformMarker"]/*' />
    METransformMarker = (METransformDrainComplete + 1),

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.METransformInputStreamStateChanged"]/*' />
    METransformInputStreamStateChanged = (METransformMarker + 1),

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEByteStreamCharacteristicsChanged"]/*' />
    MEByteStreamCharacteristicsChanged = 700,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEVideoCaptureDeviceRemoved"]/*' />
    MEVideoCaptureDeviceRemoved = 800,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEVideoCaptureDevicePreempted"]/*' />
    MEVideoCaptureDevicePreempted = 801,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEStreamSinkFormatInvalidated"]/*' />
    MEStreamSinkFormatInvalidated = 802,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEEncodingParameters"]/*' />
    MEEncodingParameters = 803,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEContentProtectionMetadata"]/*' />
    MEContentProtectionMetadata = 900,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEDeviceThermalStateChanged"]/*' />
    MEDeviceThermalStateChanged = 950,

    /// <include file='__MIDL___MIDL_itf_mfobjects_0000_0013_0001.xml' path='doc/member[@name="__MIDL___MIDL_itf_mfobjects_0000_0013_0001.MEReservedMax"]/*' />
    MEReservedMax = 10000,
}
