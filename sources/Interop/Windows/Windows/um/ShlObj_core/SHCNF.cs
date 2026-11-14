// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SHCNF
{
    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_IDLIST"]/*' />
    [NativeTypeName("#define SHCNF_IDLIST 0x0000")]
    public const int SHCNF_IDLIST = 0x0000;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_PATHA"]/*' />
    [NativeTypeName("#define SHCNF_PATHA 0x0001")]
    public const int SHCNF_PATHA = 0x0001;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_PRINTERA"]/*' />
    [NativeTypeName("#define SHCNF_PRINTERA 0x0002")]
    public const int SHCNF_PRINTERA = 0x0002;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_DWORD"]/*' />
    [NativeTypeName("#define SHCNF_DWORD 0x0003")]
    public const int SHCNF_DWORD = 0x0003;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_PATHW"]/*' />
    [NativeTypeName("#define SHCNF_PATHW 0x0005")]
    public const int SHCNF_PATHW = 0x0005;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_PRINTERW"]/*' />
    [NativeTypeName("#define SHCNF_PRINTERW 0x0006")]
    public const int SHCNF_PRINTERW = 0x0006;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_TYPE"]/*' />
    [NativeTypeName("#define SHCNF_TYPE 0x00FF")]
    public const int SHCNF_TYPE = 0x00FF;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_FLUSH"]/*' />
    [NativeTypeName("#define SHCNF_FLUSH 0x1000")]
    public const int SHCNF_FLUSH = 0x1000;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_FLUSHNOWAIT"]/*' />
    [NativeTypeName("#define SHCNF_FLUSHNOWAIT 0x3000")]
    public const int SHCNF_FLUSHNOWAIT = 0x3000;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_NOTIFYRECURSIVE"]/*' />
    [NativeTypeName("#define SHCNF_NOTIFYRECURSIVE 0x10000")]
    public const int SHCNF_NOTIFYRECURSIVE = 0x10000;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_PATH"]/*' />
    [NativeTypeName("#define SHCNF_PATH SHCNF_PATHW")]
    public const int SHCNF_PATH = 0x0005;

    /// <include file='SHCNF.xml' path='doc/member[@name="SHCNF.SHCNF_PRINTER"]/*' />
    [NativeTypeName("#define SHCNF_PRINTER SHCNF_PRINTERW")]
    public const int SHCNF_PRINTER = 0x0006;
}
