// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MseTimeRange.xml' path='doc/member[@name="MseTimeRange"]/*' />
public partial struct MseTimeRange
{
    /// <include file='MseTimeRange.xml' path='doc/member[@name="MseTimeRange.Start"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan Start;

    /// <include file='MseTimeRange.xml' path='doc/member[@name="MseTimeRange.End"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan End;
}
