// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class RDW
{
    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_INVALIDATE"]/*' />
    [NativeTypeName("#define RDW_INVALIDATE 0x0001")]
    public const int RDW_INVALIDATE = 0x0001;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_INTERNALPAINT"]/*' />
    [NativeTypeName("#define RDW_INTERNALPAINT 0x0002")]
    public const int RDW_INTERNALPAINT = 0x0002;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_ERASE"]/*' />
    [NativeTypeName("#define RDW_ERASE 0x0004")]
    public const int RDW_ERASE = 0x0004;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_VALIDATE"]/*' />
    [NativeTypeName("#define RDW_VALIDATE 0x0008")]
    public const int RDW_VALIDATE = 0x0008;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_NOINTERNALPAINT"]/*' />
    [NativeTypeName("#define RDW_NOINTERNALPAINT 0x0010")]
    public const int RDW_NOINTERNALPAINT = 0x0010;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_NOERASE"]/*' />
    [NativeTypeName("#define RDW_NOERASE 0x0020")]
    public const int RDW_NOERASE = 0x0020;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_NOCHILDREN"]/*' />
    [NativeTypeName("#define RDW_NOCHILDREN 0x0040")]
    public const int RDW_NOCHILDREN = 0x0040;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_ALLCHILDREN"]/*' />
    [NativeTypeName("#define RDW_ALLCHILDREN 0x0080")]
    public const int RDW_ALLCHILDREN = 0x0080;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_UPDATENOW"]/*' />
    [NativeTypeName("#define RDW_UPDATENOW 0x0100")]
    public const int RDW_UPDATENOW = 0x0100;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_ERASENOW"]/*' />
    [NativeTypeName("#define RDW_ERASENOW 0x0200")]
    public const int RDW_ERASENOW = 0x0200;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_FRAME"]/*' />
    [NativeTypeName("#define RDW_FRAME 0x0400")]
    public const int RDW_FRAME = 0x0400;

    /// <include file='RDW.xml' path='doc/member[@name="RDW.RDW_NOFRAME"]/*' />
    [NativeTypeName("#define RDW_NOFRAME 0x0800")]
    public const int RDW_NOFRAME = 0x0800;
}
