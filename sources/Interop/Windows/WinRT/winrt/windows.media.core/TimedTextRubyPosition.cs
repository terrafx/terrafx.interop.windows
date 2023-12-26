// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextRubyPosition.xml' path='doc/member[@name="TimedTextRubyPosition"]/*' />
public enum TimedTextRubyPosition
{
    /// <include file='TimedTextRubyPosition.xml' path='doc/member[@name="TimedTextRubyPosition.TimedTextRubyPosition_Before"]/*' />
    TimedTextRubyPosition_Before = 0,

    /// <include file='TimedTextRubyPosition.xml' path='doc/member[@name="TimedTextRubyPosition.TimedTextRubyPosition_After"]/*' />
    TimedTextRubyPosition_After = 1,

    /// <include file='TimedTextRubyPosition.xml' path='doc/member[@name="TimedTextRubyPosition.TimedTextRubyPosition_Outside"]/*' />
    TimedTextRubyPosition_Outside = 2,
}
