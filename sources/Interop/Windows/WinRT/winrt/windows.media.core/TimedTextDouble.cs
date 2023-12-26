// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextDouble.xml' path='doc/member[@name="TimedTextDouble"]/*' />
public partial struct TimedTextDouble
{
    /// <include file='TimedTextDouble.xml' path='doc/member[@name="TimedTextDouble.Value"]/*' />
    public double Value;

    /// <include file='TimedTextDouble.xml' path='doc/member[@name="TimedTextDouble.Unit"]/*' />
    [NativeTypeName("ABI::Windows::Media::Core::TimedTextUnit")]
    public TimedTextUnit Unit;
}
