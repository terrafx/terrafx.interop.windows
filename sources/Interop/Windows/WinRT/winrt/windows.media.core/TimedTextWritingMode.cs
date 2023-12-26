// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode"]/*' />
public enum TimedTextWritingMode
{
    /// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode.TimedTextWritingMode_LeftRightTopBottom"]/*' />
    TimedTextWritingMode_LeftRightTopBottom = 0,

    /// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode.TimedTextWritingMode_RightLeftTopBottom"]/*' />
    TimedTextWritingMode_RightLeftTopBottom = 1,

    /// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode.TimedTextWritingMode_TopBottomRightLeft"]/*' />
    TimedTextWritingMode_TopBottomRightLeft = 2,

    /// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode.TimedTextWritingMode_TopBottomLeftRight"]/*' />
    TimedTextWritingMode_TopBottomLeftRight = 3,

    /// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode.TimedTextWritingMode_LeftRight"]/*' />
    TimedTextWritingMode_LeftRight = 4,

    /// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode.TimedTextWritingMode_RightLeft"]/*' />
    TimedTextWritingMode_RightLeft = 5,

    /// <include file='TimedTextWritingMode.xml' path='doc/member[@name="TimedTextWritingMode.TimedTextWritingMode_TopBottom"]/*' />
    TimedTextWritingMode_TopBottom = 6,
}
