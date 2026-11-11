// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VIEW
{
    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_E_FIRST"]/*' />
    [NativeTypeName("#define VIEW_E_FIRST 0x80040140L")]
    public const uint VIEW_E_FIRST = 0x80040140;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_E_LAST"]/*' />
    [NativeTypeName("#define VIEW_E_LAST 0x8004014FL")]
    public const uint VIEW_E_LAST = 0x8004014F;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_S_FIRST"]/*' />
    [NativeTypeName("#define VIEW_S_FIRST 0x00040140L")]
    public const int VIEW_S_FIRST = 0x00040140;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_S_LAST"]/*' />
    [NativeTypeName("#define VIEW_S_LAST 0x0004014FL")]
    public const int VIEW_S_LAST = 0x0004014F;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_E_DRAW"]/*' />
    [NativeTypeName("#define VIEW_E_DRAW _HRESULT_TYPEDEF_(0x80040140L)")]
    public const int VIEW_E_DRAW = unchecked((int)(0x80040140));

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_S_ALREADY_FROZEN"]/*' />
    [NativeTypeName("#define VIEW_S_ALREADY_FROZEN _HRESULT_TYPEDEF_(0x00040140L)")]
    public const int VIEW_S_ALREADY_FROZEN = ((int)(0x00040140));
}
