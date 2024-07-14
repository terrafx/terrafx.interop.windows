// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextBoutenPosition.xml' path='doc/member[@name="TimedTextBoutenPosition"]/*' />
public enum TimedTextBoutenPosition
{
    /// <include file='TimedTextBoutenPosition.xml' path='doc/member[@name="TimedTextBoutenPosition.TimedTextBoutenPosition_Before"]/*' />
    TimedTextBoutenPosition_Before = 0,

    /// <include file='TimedTextBoutenPosition.xml' path='doc/member[@name="TimedTextBoutenPosition.TimedTextBoutenPosition_After"]/*' />
    TimedTextBoutenPosition_After = 1,

    /// <include file='TimedTextBoutenPosition.xml' path='doc/member[@name="TimedTextBoutenPosition.TimedTextBoutenPosition_Outside"]/*' />
    TimedTextBoutenPosition_Outside = 2,
}
