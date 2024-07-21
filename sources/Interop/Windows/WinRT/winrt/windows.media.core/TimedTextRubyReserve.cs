// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextRubyReserve.xml' path='doc/member[@name="TimedTextRubyReserve"]/*' />
public enum TimedTextRubyReserve
{
    /// <include file='TimedTextRubyReserve.xml' path='doc/member[@name="TimedTextRubyReserve.TimedTextRubyReserve_None"]/*' />
    TimedTextRubyReserve_None = 0,

    /// <include file='TimedTextRubyReserve.xml' path='doc/member[@name="TimedTextRubyReserve.TimedTextRubyReserve_Before"]/*' />
    TimedTextRubyReserve_Before = 1,

    /// <include file='TimedTextRubyReserve.xml' path='doc/member[@name="TimedTextRubyReserve.TimedTextRubyReserve_After"]/*' />
    TimedTextRubyReserve_After = 2,

    /// <include file='TimedTextRubyReserve.xml' path='doc/member[@name="TimedTextRubyReserve.TimedTextRubyReserve_Both"]/*' />
    TimedTextRubyReserve_Both = 3,

    /// <include file='TimedTextRubyReserve.xml' path='doc/member[@name="TimedTextRubyReserve.TimedTextRubyReserve_Outside"]/*' />
    TimedTextRubyReserve_Outside = 4,
}
