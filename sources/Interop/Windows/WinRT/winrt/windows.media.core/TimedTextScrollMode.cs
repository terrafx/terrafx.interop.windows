// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextScrollMode.xml' path='doc/member[@name="TimedTextScrollMode"]/*' />
public enum TimedTextScrollMode
{
    /// <include file='TimedTextScrollMode.xml' path='doc/member[@name="TimedTextScrollMode.TimedTextScrollMode_Popon"]/*' />
    TimedTextScrollMode_Popon = 0,

    /// <include file='TimedTextScrollMode.xml' path='doc/member[@name="TimedTextScrollMode.TimedTextScrollMode_Rollup"]/*' />
    TimedTextScrollMode_Rollup = 1,
}
