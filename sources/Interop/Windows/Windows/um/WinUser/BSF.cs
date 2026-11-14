// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BSF
{
    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_QUERY"]/*' />
    [NativeTypeName("#define BSF_QUERY 0x00000001")]
    public const int BSF_QUERY = 0x00000001;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_IGNORECURRENTTASK"]/*' />
    [NativeTypeName("#define BSF_IGNORECURRENTTASK 0x00000002")]
    public const int BSF_IGNORECURRENTTASK = 0x00000002;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_FLUSHDISK"]/*' />
    [NativeTypeName("#define BSF_FLUSHDISK 0x00000004")]
    public const int BSF_FLUSHDISK = 0x00000004;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_NOHANG"]/*' />
    [NativeTypeName("#define BSF_NOHANG 0x00000008")]
    public const int BSF_NOHANG = 0x00000008;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_POSTMESSAGE"]/*' />
    [NativeTypeName("#define BSF_POSTMESSAGE 0x00000010")]
    public const int BSF_POSTMESSAGE = 0x00000010;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_FORCEIFHUNG"]/*' />
    [NativeTypeName("#define BSF_FORCEIFHUNG 0x00000020")]
    public const int BSF_FORCEIFHUNG = 0x00000020;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_NOTIMEOUTIFNOTHUNG"]/*' />
    [NativeTypeName("#define BSF_NOTIMEOUTIFNOTHUNG 0x00000040")]
    public const int BSF_NOTIMEOUTIFNOTHUNG = 0x00000040;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_ALLOWSFW"]/*' />
    [NativeTypeName("#define BSF_ALLOWSFW 0x00000080")]
    public const int BSF_ALLOWSFW = 0x00000080;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_SENDNOTIFYMESSAGE"]/*' />
    [NativeTypeName("#define BSF_SENDNOTIFYMESSAGE 0x00000100")]
    public const int BSF_SENDNOTIFYMESSAGE = 0x00000100;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_RETURNHDESK"]/*' />
    [NativeTypeName("#define BSF_RETURNHDESK 0x00000200")]
    public const int BSF_RETURNHDESK = 0x00000200;

    /// <include file='BSF.xml' path='doc/member[@name="BSF.BSF_LUID"]/*' />
    [NativeTypeName("#define BSF_LUID 0x00000400")]
    public const int BSF_LUID = 0x00000400;
}
