// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SE
{
    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_FNF"]/*' />
    [NativeTypeName("#define SE_ERR_FNF 2")]
    public const int SE_ERR_FNF = 2;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_PNF"]/*' />
    [NativeTypeName("#define SE_ERR_PNF 3")]
    public const int SE_ERR_PNF = 3;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_ACCESSDENIED"]/*' />
    [NativeTypeName("#define SE_ERR_ACCESSDENIED 5")]
    public const int SE_ERR_ACCESSDENIED = 5;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_OOM"]/*' />
    [NativeTypeName("#define SE_ERR_OOM 8")]
    public const int SE_ERR_OOM = 8;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_DLLNOTFOUND"]/*' />
    [NativeTypeName("#define SE_ERR_DLLNOTFOUND 32")]
    public const int SE_ERR_DLLNOTFOUND = 32;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_SHARE"]/*' />
    [NativeTypeName("#define SE_ERR_SHARE 26")]
    public const int SE_ERR_SHARE = 26;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_ASSOCINCOMPLETE"]/*' />
    [NativeTypeName("#define SE_ERR_ASSOCINCOMPLETE 27")]
    public const int SE_ERR_ASSOCINCOMPLETE = 27;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_DDETIMEOUT"]/*' />
    [NativeTypeName("#define SE_ERR_DDETIMEOUT 28")]
    public const int SE_ERR_DDETIMEOUT = 28;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_DDEFAIL"]/*' />
    [NativeTypeName("#define SE_ERR_DDEFAIL 29")]
    public const int SE_ERR_DDEFAIL = 29;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_DDEBUSY"]/*' />
    [NativeTypeName("#define SE_ERR_DDEBUSY 30")]
    public const int SE_ERR_DDEBUSY = 30;

    /// <include file='SE.xml' path='doc/member[@name="SE.SE_ERR_NOASSOC"]/*' />
    [NativeTypeName("#define SE_ERR_NOASSOC 31")]
    public const int SE_ERR_NOASSOC = 31;
}
