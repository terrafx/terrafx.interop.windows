// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextPoint.xml' path='doc/member[@name="TimedTextPoint"]/*' />
public partial struct TimedTextPoint
{
    /// <include file='TimedTextPoint.xml' path='doc/member[@name="TimedTextPoint.X"]/*' />
    public double X;

    /// <include file='TimedTextPoint.xml' path='doc/member[@name="TimedTextPoint.Y"]/*' />
    public double Y;

    /// <include file='TimedTextPoint.xml' path='doc/member[@name="TimedTextPoint.Unit"]/*' />
    [NativeTypeName("ABI::Windows::Media::Core::TimedTextUnit")]
    public TimedTextUnit Unit;
}
