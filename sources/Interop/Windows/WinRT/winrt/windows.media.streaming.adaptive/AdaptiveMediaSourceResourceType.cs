// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AdaptiveMediaSourceResourceType.xml' path='doc/member[@name="AdaptiveMediaSourceResourceType"]/*' />
public enum AdaptiveMediaSourceResourceType
{
    /// <include file='AdaptiveMediaSourceResourceType.xml' path='doc/member[@name="AdaptiveMediaSourceResourceType.AdaptiveMediaSourceResourceType_Manifest"]/*' />
    AdaptiveMediaSourceResourceType_Manifest = 0,

    /// <include file='AdaptiveMediaSourceResourceType.xml' path='doc/member[@name="AdaptiveMediaSourceResourceType.AdaptiveMediaSourceResourceType_InitializationSegment"]/*' />
    AdaptiveMediaSourceResourceType_InitializationSegment = 1,

    /// <include file='AdaptiveMediaSourceResourceType.xml' path='doc/member[@name="AdaptiveMediaSourceResourceType.AdaptiveMediaSourceResourceType_MediaSegment"]/*' />
    AdaptiveMediaSourceResourceType_MediaSegment = 2,

    /// <include file='AdaptiveMediaSourceResourceType.xml' path='doc/member[@name="AdaptiveMediaSourceResourceType.AdaptiveMediaSourceResourceType_Key"]/*' />
    AdaptiveMediaSourceResourceType_Key = 3,

    /// <include file='AdaptiveMediaSourceResourceType.xml' path='doc/member[@name="AdaptiveMediaSourceResourceType.AdaptiveMediaSourceResourceType_InitializationVector"]/*' />
    AdaptiveMediaSourceResourceType_InitializationVector = 4,

    /// <include file='AdaptiveMediaSourceResourceType.xml' path='doc/member[@name="AdaptiveMediaSourceResourceType.AdaptiveMediaSourceResourceType_MediaSegmentIndex"]/*' />
    AdaptiveMediaSourceResourceType_MediaSegmentIndex = 5,
}
