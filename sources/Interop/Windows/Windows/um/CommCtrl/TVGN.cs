// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TVGN
{
    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_ROOT"]/*' />
    [NativeTypeName("#define TVGN_ROOT 0x0000")]
    public const int TVGN_ROOT = 0x0000;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_NEXT"]/*' />
    [NativeTypeName("#define TVGN_NEXT 0x0001")]
    public const int TVGN_NEXT = 0x0001;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_PREVIOUS"]/*' />
    [NativeTypeName("#define TVGN_PREVIOUS 0x0002")]
    public const int TVGN_PREVIOUS = 0x0002;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_PARENT"]/*' />
    [NativeTypeName("#define TVGN_PARENT 0x0003")]
    public const int TVGN_PARENT = 0x0003;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_CHILD"]/*' />
    [NativeTypeName("#define TVGN_CHILD 0x0004")]
    public const int TVGN_CHILD = 0x0004;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_FIRSTVISIBLE"]/*' />
    [NativeTypeName("#define TVGN_FIRSTVISIBLE 0x0005")]
    public const int TVGN_FIRSTVISIBLE = 0x0005;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_NEXTVISIBLE"]/*' />
    [NativeTypeName("#define TVGN_NEXTVISIBLE 0x0006")]
    public const int TVGN_NEXTVISIBLE = 0x0006;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_PREVIOUSVISIBLE"]/*' />
    [NativeTypeName("#define TVGN_PREVIOUSVISIBLE 0x0007")]
    public const int TVGN_PREVIOUSVISIBLE = 0x0007;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_DROPHILITE"]/*' />
    [NativeTypeName("#define TVGN_DROPHILITE 0x0008")]
    public const int TVGN_DROPHILITE = 0x0008;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_CARET"]/*' />
    [NativeTypeName("#define TVGN_CARET 0x0009")]
    public const int TVGN_CARET = 0x0009;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_LASTVISIBLE"]/*' />
    [NativeTypeName("#define TVGN_LASTVISIBLE 0x000A")]
    public const int TVGN_LASTVISIBLE = 0x000A;

    /// <include file='TVGN.xml' path='doc/member[@name="TVGN.TVGN_NEXTSELECTED"]/*' />
    [NativeTypeName("#define TVGN_NEXTSELECTED 0x000B")]
    public const int TVGN_NEXTSELECTED = 0x000B;
}
