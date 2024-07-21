// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextLineAlignment.xml' path='doc/member[@name="TimedTextLineAlignment"]/*' />
public enum TimedTextLineAlignment
{
    /// <include file='TimedTextLineAlignment.xml' path='doc/member[@name="TimedTextLineAlignment.TimedTextLineAlignment_Start"]/*' />
    TimedTextLineAlignment_Start = 0,

    /// <include file='TimedTextLineAlignment.xml' path='doc/member[@name="TimedTextLineAlignment.TimedTextLineAlignment_End"]/*' />
    TimedTextLineAlignment_End = 1,

    /// <include file='TimedTextLineAlignment.xml' path='doc/member[@name="TimedTextLineAlignment.TimedTextLineAlignment_Center"]/*' />
    TimedTextLineAlignment_Center = 2,
}
