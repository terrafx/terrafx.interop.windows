// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CAT
{
    /// <include file='CAT.xml' path='doc/member[@name="CAT.CAT_E_FIRST"]/*' />
    [NativeTypeName("#define CAT_E_FIRST 0x80040160L")]
    public const uint CAT_E_FIRST = 0x80040160;

    /// <include file='CAT.xml' path='doc/member[@name="CAT.CAT_E_LAST"]/*' />
    [NativeTypeName("#define CAT_E_LAST 0x80040161L")]
    public const uint CAT_E_LAST = 0x80040161;

    /// <include file='CAT.xml' path='doc/member[@name="CAT.CAT_E_CATIDNOEXIST"]/*' />
    [NativeTypeName("#define CAT_E_CATIDNOEXIST _HRESULT_TYPEDEF_(0x80040160L)")]
    public const int CAT_E_CATIDNOEXIST = unchecked((int)(0x80040160));

    /// <include file='CAT.xml' path='doc/member[@name="CAT.CAT_E_NODESCRIPTION"]/*' />
    [NativeTypeName("#define CAT_E_NODESCRIPTION _HRESULT_TYPEDEF_(0x80040161L)")]
    public const int CAT_E_NODESCRIPTION = unchecked((int)(0x80040161));
}
