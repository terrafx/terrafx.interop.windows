// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SFGAO
{
    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CANCOPY"]/*' />
    [NativeTypeName("#define SFGAO_CANCOPY DROPEFFECT_COPY")]
    public const int SFGAO_CANCOPY = (1);

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CANMOVE"]/*' />
    [NativeTypeName("#define SFGAO_CANMOVE DROPEFFECT_MOVE")]
    public const int SFGAO_CANMOVE = (2);

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CANLINK"]/*' />
    [NativeTypeName("#define SFGAO_CANLINK DROPEFFECT_LINK")]
    public const int SFGAO_CANLINK = (4);

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_STORAGE"]/*' />
    [NativeTypeName("#define SFGAO_STORAGE 0x00000008L")]
    public const int SFGAO_STORAGE = 0x00000008;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CANRENAME"]/*' />
    [NativeTypeName("#define SFGAO_CANRENAME 0x00000010L")]
    public const int SFGAO_CANRENAME = 0x00000010;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CANDELETE"]/*' />
    [NativeTypeName("#define SFGAO_CANDELETE 0x00000020L")]
    public const int SFGAO_CANDELETE = 0x00000020;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_HASPROPSHEET"]/*' />
    [NativeTypeName("#define SFGAO_HASPROPSHEET 0x00000040L")]
    public const int SFGAO_HASPROPSHEET = 0x00000040;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_DROPTARGET"]/*' />
    [NativeTypeName("#define SFGAO_DROPTARGET 0x00000100L")]
    public const int SFGAO_DROPTARGET = 0x00000100;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CAPABILITYMASK"]/*' />
    [NativeTypeName("#define SFGAO_CAPABILITYMASK 0x00000177L")]
    public const int SFGAO_CAPABILITYMASK = 0x00000177;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_PLACEHOLDER"]/*' />
    [NativeTypeName("#define SFGAO_PLACEHOLDER 0x00000800L")]
    public const int SFGAO_PLACEHOLDER = 0x00000800;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_SYSTEM"]/*' />
    [NativeTypeName("#define SFGAO_SYSTEM 0x00001000L")]
    public const int SFGAO_SYSTEM = 0x00001000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_ENCRYPTED"]/*' />
    [NativeTypeName("#define SFGAO_ENCRYPTED 0x00002000L")]
    public const int SFGAO_ENCRYPTED = 0x00002000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_ISSLOW"]/*' />
    [NativeTypeName("#define SFGAO_ISSLOW 0x00004000L")]
    public const int SFGAO_ISSLOW = 0x00004000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_GHOSTED"]/*' />
    [NativeTypeName("#define SFGAO_GHOSTED 0x00008000L")]
    public const int SFGAO_GHOSTED = 0x00008000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_LINK"]/*' />
    [NativeTypeName("#define SFGAO_LINK 0x00010000L")]
    public const int SFGAO_LINK = 0x00010000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_SHARE"]/*' />
    [NativeTypeName("#define SFGAO_SHARE 0x00020000L")]
    public const int SFGAO_SHARE = 0x00020000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_READONLY"]/*' />
    [NativeTypeName("#define SFGAO_READONLY 0x00040000L")]
    public const int SFGAO_READONLY = 0x00040000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_HIDDEN"]/*' />
    [NativeTypeName("#define SFGAO_HIDDEN 0x00080000L")]
    public const int SFGAO_HIDDEN = 0x00080000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_DISPLAYATTRMASK"]/*' />
    [NativeTypeName("#define SFGAO_DISPLAYATTRMASK 0x000FC000L")]
    public const int SFGAO_DISPLAYATTRMASK = 0x000FC000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_FILESYSANCESTOR"]/*' />
    [NativeTypeName("#define SFGAO_FILESYSANCESTOR 0x10000000L")]
    public const int SFGAO_FILESYSANCESTOR = 0x10000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_FOLDER"]/*' />
    [NativeTypeName("#define SFGAO_FOLDER 0x20000000L")]
    public const int SFGAO_FOLDER = 0x20000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_FILESYSTEM"]/*' />
    [NativeTypeName("#define SFGAO_FILESYSTEM 0x40000000L")]
    public const int SFGAO_FILESYSTEM = 0x40000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_HASSUBFOLDER"]/*' />
    [NativeTypeName("#define SFGAO_HASSUBFOLDER 0x80000000L")]
    public const uint SFGAO_HASSUBFOLDER = 0x80000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CONTENTSMASK"]/*' />
    [NativeTypeName("#define SFGAO_CONTENTSMASK 0x80000000L")]
    public const uint SFGAO_CONTENTSMASK = 0x80000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_VALIDATE"]/*' />
    [NativeTypeName("#define SFGAO_VALIDATE 0x01000000L")]
    public const int SFGAO_VALIDATE = 0x01000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_REMOVABLE"]/*' />
    [NativeTypeName("#define SFGAO_REMOVABLE 0x02000000L")]
    public const int SFGAO_REMOVABLE = 0x02000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_COMPRESSED"]/*' />
    [NativeTypeName("#define SFGAO_COMPRESSED 0x04000000L")]
    public const int SFGAO_COMPRESSED = 0x04000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_BROWSABLE"]/*' />
    [NativeTypeName("#define SFGAO_BROWSABLE 0x08000000L")]
    public const int SFGAO_BROWSABLE = 0x08000000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_NONENUMERATED"]/*' />
    [NativeTypeName("#define SFGAO_NONENUMERATED 0x00100000L")]
    public const int SFGAO_NONENUMERATED = 0x00100000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_NEWCONTENT"]/*' />
    [NativeTypeName("#define SFGAO_NEWCONTENT 0x00200000L")]
    public const int SFGAO_NEWCONTENT = 0x00200000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_CANMONIKER"]/*' />
    [NativeTypeName("#define SFGAO_CANMONIKER 0x00400000L")]
    public const int SFGAO_CANMONIKER = 0x00400000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_HASSTORAGE"]/*' />
    [NativeTypeName("#define SFGAO_HASSTORAGE 0x00400000L")]
    public const int SFGAO_HASSTORAGE = 0x00400000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_STREAM"]/*' />
    [NativeTypeName("#define SFGAO_STREAM 0x00400000L")]
    public const int SFGAO_STREAM = 0x00400000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_STORAGEANCESTOR"]/*' />
    [NativeTypeName("#define SFGAO_STORAGEANCESTOR 0x00800000L")]
    public const int SFGAO_STORAGEANCESTOR = 0x00800000;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_STORAGECAPMASK"]/*' />
    [NativeTypeName("#define SFGAO_STORAGECAPMASK 0x70C50008L")]
    public const int SFGAO_STORAGECAPMASK = 0x70C50008;

    /// <include file='SFGAO.xml' path='doc/member[@name="SFGAO.SFGAO_PKEYSFGAOMASK"]/*' />
    [NativeTypeName("#define SFGAO_PKEYSFGAOMASK 0x81044000L")]
    public const uint SFGAO_PKEYSFGAOMASK = 0x81044000;
}
