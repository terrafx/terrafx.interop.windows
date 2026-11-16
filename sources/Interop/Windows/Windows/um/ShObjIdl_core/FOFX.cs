// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FOFX
{
    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_NOSKIPJUNCTIONS"]/*' />
    [NativeTypeName("#define FOFX_NOSKIPJUNCTIONS 0x00010000")]
    public const int FOFX_NOSKIPJUNCTIONS = 0x00010000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_PREFERHARDLINK"]/*' />
    [NativeTypeName("#define FOFX_PREFERHARDLINK 0x00020000")]
    public const int FOFX_PREFERHARDLINK = 0x00020000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_SHOWELEVATIONPROMPT"]/*' />
    [NativeTypeName("#define FOFX_SHOWELEVATIONPROMPT 0x00040000")]
    public const int FOFX_SHOWELEVATIONPROMPT = 0x00040000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_RECYCLEONDELETE"]/*' />
    [NativeTypeName("#define FOFX_RECYCLEONDELETE 0x00080000")]
    public const int FOFX_RECYCLEONDELETE = 0x00080000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_EARLYFAILURE"]/*' />
    [NativeTypeName("#define FOFX_EARLYFAILURE 0x00100000")]
    public const int FOFX_EARLYFAILURE = 0x00100000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_PRESERVEFILEEXTENSIONS"]/*' />
    [NativeTypeName("#define FOFX_PRESERVEFILEEXTENSIONS 0x00200000")]
    public const int FOFX_PRESERVEFILEEXTENSIONS = 0x00200000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_KEEPNEWERFILE"]/*' />
    [NativeTypeName("#define FOFX_KEEPNEWERFILE 0x00400000")]
    public const int FOFX_KEEPNEWERFILE = 0x00400000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_NOCOPYHOOKS"]/*' />
    [NativeTypeName("#define FOFX_NOCOPYHOOKS 0x00800000")]
    public const int FOFX_NOCOPYHOOKS = 0x00800000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_NOMINIMIZEBOX"]/*' />
    [NativeTypeName("#define FOFX_NOMINIMIZEBOX 0x01000000")]
    public const int FOFX_NOMINIMIZEBOX = 0x01000000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_MOVEACLSACROSSVOLUMES"]/*' />
    [NativeTypeName("#define FOFX_MOVEACLSACROSSVOLUMES 0x02000000")]
    public const int FOFX_MOVEACLSACROSSVOLUMES = 0x02000000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_DONTDISPLAYSOURCEPATH"]/*' />
    [NativeTypeName("#define FOFX_DONTDISPLAYSOURCEPATH 0x04000000")]
    public const int FOFX_DONTDISPLAYSOURCEPATH = 0x04000000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_DONTDISPLAYDESTPATH"]/*' />
    [NativeTypeName("#define FOFX_DONTDISPLAYDESTPATH 0x08000000")]
    public const int FOFX_DONTDISPLAYDESTPATH = 0x08000000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_REQUIREELEVATION"]/*' />
    [NativeTypeName("#define FOFX_REQUIREELEVATION 0x10000000")]
    public const int FOFX_REQUIREELEVATION = 0x10000000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_ADDUNDORECORD"]/*' />
    [NativeTypeName("#define FOFX_ADDUNDORECORD 0x20000000")]
    public const int FOFX_ADDUNDORECORD = 0x20000000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_COPYASDOWNLOAD"]/*' />
    [NativeTypeName("#define FOFX_COPYASDOWNLOAD 0x40000000")]
    public const int FOFX_COPYASDOWNLOAD = 0x40000000;

    /// <include file='FOFX.xml' path='doc/member[@name="FOFX.FOFX_DONTDISPLAYLOCATIONS"]/*' />
    [NativeTypeName("#define FOFX_DONTDISPLAYLOCATIONS 0x80000000")]
    public const uint FOFX_DONTDISPLAYLOCATIONS = 0x80000000;
}
