// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GIL
{
    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_OPENICON"]/*' />
    [NativeTypeName("#define GIL_OPENICON 0x0001")]
    public const int GIL_OPENICON = 0x0001;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_FORSHELL"]/*' />
    [NativeTypeName("#define GIL_FORSHELL 0x0002")]
    public const int GIL_FORSHELL = 0x0002;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_ASYNC"]/*' />
    [NativeTypeName("#define GIL_ASYNC 0x0020")]
    public const int GIL_ASYNC = 0x0020;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_DEFAULTICON"]/*' />
    [NativeTypeName("#define GIL_DEFAULTICON 0x0040")]
    public const int GIL_DEFAULTICON = 0x0040;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_FORSHORTCUT"]/*' />
    [NativeTypeName("#define GIL_FORSHORTCUT 0x0080")]
    public const int GIL_FORSHORTCUT = 0x0080;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_CHECKSHIELD"]/*' />
    [NativeTypeName("#define GIL_CHECKSHIELD 0x0200")]
    public const int GIL_CHECKSHIELD = 0x0200;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_SIMULATEDOC"]/*' />
    [NativeTypeName("#define GIL_SIMULATEDOC 0x0001")]
    public const int GIL_SIMULATEDOC = 0x0001;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_PERINSTANCE"]/*' />
    [NativeTypeName("#define GIL_PERINSTANCE 0x0002")]
    public const int GIL_PERINSTANCE = 0x0002;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_PERCLASS"]/*' />
    [NativeTypeName("#define GIL_PERCLASS 0x0004")]
    public const int GIL_PERCLASS = 0x0004;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_NOTFILENAME"]/*' />
    [NativeTypeName("#define GIL_NOTFILENAME 0x0008")]
    public const int GIL_NOTFILENAME = 0x0008;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_DONTCACHE"]/*' />
    [NativeTypeName("#define GIL_DONTCACHE 0x0010")]
    public const int GIL_DONTCACHE = 0x0010;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_SHIELD"]/*' />
    [NativeTypeName("#define GIL_SHIELD 0x0200")]
    public const int GIL_SHIELD = 0x0200;

    /// <include file='GIL.xml' path='doc/member[@name="GIL.GIL_FORCENOSHIELD"]/*' />
    [NativeTypeName("#define GIL_FORCENOSHIELD 0x0400")]
    public const int GIL_FORCENOSHIELD = 0x0400;
}
