// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AudioEncodingQuality.xml' path='doc/member[@name="AudioEncodingQuality"]/*' />
public enum AudioEncodingQuality
{
    /// <include file='AudioEncodingQuality.xml' path='doc/member[@name="AudioEncodingQuality.AudioEncodingQuality_Auto"]/*' />
    AudioEncodingQuality_Auto = 0,

    /// <include file='AudioEncodingQuality.xml' path='doc/member[@name="AudioEncodingQuality.AudioEncodingQuality_High"]/*' />
    AudioEncodingQuality_High = 1,

    /// <include file='AudioEncodingQuality.xml' path='doc/member[@name="AudioEncodingQuality.AudioEncodingQuality_Medium"]/*' />
    AudioEncodingQuality_Medium = 2,

    /// <include file='AudioEncodingQuality.xml' path='doc/member[@name="AudioEncodingQuality.AudioEncodingQuality_Low"]/*' />
    AudioEncodingQuality_Low = 3,
}
