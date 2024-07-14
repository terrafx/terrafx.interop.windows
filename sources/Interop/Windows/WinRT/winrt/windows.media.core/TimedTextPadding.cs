// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextPadding.xml' path='doc/member[@name="TimedTextPadding"]/*' />
public partial struct TimedTextPadding
{
    /// <include file='TimedTextPadding.xml' path='doc/member[@name="TimedTextPadding.Before"]/*' />
    public double Before;

    /// <include file='TimedTextPadding.xml' path='doc/member[@name="TimedTextPadding.After"]/*' />
    public double After;

    /// <include file='TimedTextPadding.xml' path='doc/member[@name="TimedTextPadding.Start"]/*' />
    public double Start;

    /// <include file='TimedTextPadding.xml' path='doc/member[@name="TimedTextPadding.End"]/*' />
    public double End;

    /// <include file='TimedTextPadding.xml' path='doc/member[@name="TimedTextPadding.Unit"]/*' />
    [NativeTypeName("ABI::Windows::Media::Core::TimedTextUnit")]
    public TimedTextUnit Unit;
}
