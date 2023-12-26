// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='MediaTimeRange.xml' path='doc/member[@name="MediaTimeRange"]/*' />
public partial struct MediaTimeRange
{
    /// <include file='MediaTimeRange.xml' path='doc/member[@name="MediaTimeRange.Start"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan Start;

    /// <include file='MediaTimeRange.xml' path='doc/member[@name="MediaTimeRange.End"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan End;
}
