// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaBreakInsertionMethod.xml' path='doc/member[@name="MediaBreakInsertionMethod"]/*' />
public enum MediaBreakInsertionMethod
{
    /// <include file='MediaBreakInsertionMethod.xml' path='doc/member[@name="MediaBreakInsertionMethod.MediaBreakInsertionMethod_Interrupt"]/*' />
    MediaBreakInsertionMethod_Interrupt = 0,

    /// <include file='MediaBreakInsertionMethod.xml' path='doc/member[@name="MediaBreakInsertionMethod.MediaBreakInsertionMethod_Replace"]/*' />
    MediaBreakInsertionMethod_Replace = 1,
}
