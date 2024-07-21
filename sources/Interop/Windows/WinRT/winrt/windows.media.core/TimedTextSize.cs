// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextSize.xml' path='doc/member[@name="TimedTextSize"]/*' />
public partial struct TimedTextSize
{
    /// <include file='TimedTextSize.xml' path='doc/member[@name="TimedTextSize.Height"]/*' />
    public double Height;

    /// <include file='TimedTextSize.xml' path='doc/member[@name="TimedTextSize.Width"]/*' />
    public double Width;

    /// <include file='TimedTextSize.xml' path='doc/member[@name="TimedTextSize.Unit"]/*' />
    [NativeTypeName("ABI::Windows::Media::Core::TimedTextUnit")]
    public TimedTextUnit Unit;
}
