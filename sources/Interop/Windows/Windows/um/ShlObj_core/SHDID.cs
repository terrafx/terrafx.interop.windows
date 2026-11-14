// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SHDID
{
    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_ROOT_REGITEM"]/*' />
    [NativeTypeName("#define SHDID_ROOT_REGITEM 1")]
    public const int SHDID_ROOT_REGITEM = 1;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_FS_FILE"]/*' />
    [NativeTypeName("#define SHDID_FS_FILE 2")]
    public const int SHDID_FS_FILE = 2;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_FS_DIRECTORY"]/*' />
    [NativeTypeName("#define SHDID_FS_DIRECTORY 3")]
    public const int SHDID_FS_DIRECTORY = 3;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_FS_OTHER"]/*' />
    [NativeTypeName("#define SHDID_FS_OTHER 4")]
    public const int SHDID_FS_OTHER = 4;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_DRIVE35"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_DRIVE35 5")]
    public const int SHDID_COMPUTER_DRIVE35 = 5;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_DRIVE525"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_DRIVE525 6")]
    public const int SHDID_COMPUTER_DRIVE525 = 6;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_REMOVABLE"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_REMOVABLE 7")]
    public const int SHDID_COMPUTER_REMOVABLE = 7;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_FIXED"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_FIXED 8")]
    public const int SHDID_COMPUTER_FIXED = 8;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_NETDRIVE"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_NETDRIVE 9")]
    public const int SHDID_COMPUTER_NETDRIVE = 9;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_CDROM"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_CDROM 10")]
    public const int SHDID_COMPUTER_CDROM = 10;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_RAMDISK"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_RAMDISK 11")]
    public const int SHDID_COMPUTER_RAMDISK = 11;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_OTHER"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_OTHER 12")]
    public const int SHDID_COMPUTER_OTHER = 12;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_NET_DOMAIN"]/*' />
    [NativeTypeName("#define SHDID_NET_DOMAIN 13")]
    public const int SHDID_NET_DOMAIN = 13;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_NET_SERVER"]/*' />
    [NativeTypeName("#define SHDID_NET_SERVER 14")]
    public const int SHDID_NET_SERVER = 14;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_NET_SHARE"]/*' />
    [NativeTypeName("#define SHDID_NET_SHARE 15")]
    public const int SHDID_NET_SHARE = 15;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_NET_RESTOFNET"]/*' />
    [NativeTypeName("#define SHDID_NET_RESTOFNET 16")]
    public const int SHDID_NET_RESTOFNET = 16;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_NET_OTHER"]/*' />
    [NativeTypeName("#define SHDID_NET_OTHER 17")]
    public const int SHDID_NET_OTHER = 17;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_IMAGING"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_IMAGING 18")]
    public const int SHDID_COMPUTER_IMAGING = 18;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_AUDIO"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_AUDIO 19")]
    public const int SHDID_COMPUTER_AUDIO = 19;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_COMPUTER_SHAREDDOCS"]/*' />
    [NativeTypeName("#define SHDID_COMPUTER_SHAREDDOCS 20")]
    public const int SHDID_COMPUTER_SHAREDDOCS = 20;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_MOBILE_DEVICE"]/*' />
    [NativeTypeName("#define SHDID_MOBILE_DEVICE 21")]
    public const int SHDID_MOBILE_DEVICE = 21;

    /// <include file='SHDID.xml' path='doc/member[@name="SHDID.SHDID_REMOTE_DESKTOP_DRIVE"]/*' />
    [NativeTypeName("#define SHDID_REMOTE_DESKTOP_DRIVE 22")]
    public const int SHDID_REMOTE_DESKTOP_DRIVE = 22;
}
