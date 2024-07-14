// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextDisplayAlignment.xml' path='doc/member[@name="TimedTextDisplayAlignment"]/*' />
public enum TimedTextDisplayAlignment
{
    /// <include file='TimedTextDisplayAlignment.xml' path='doc/member[@name="TimedTextDisplayAlignment.TimedTextDisplayAlignment_Before"]/*' />
    TimedTextDisplayAlignment_Before = 0,

    /// <include file='TimedTextDisplayAlignment.xml' path='doc/member[@name="TimedTextDisplayAlignment.TimedTextDisplayAlignment_After"]/*' />
    TimedTextDisplayAlignment_After = 1,

    /// <include file='TimedTextDisplayAlignment.xml' path='doc/member[@name="TimedTextDisplayAlignment.TimedTextDisplayAlignment_Center"]/*' />
    TimedTextDisplayAlignment_Center = 2,
}
