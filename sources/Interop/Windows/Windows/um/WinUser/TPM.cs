// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TPM
{
    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_LEFTBUTTON"]/*' />
    [NativeTypeName("#define TPM_LEFTBUTTON 0x0000L")]
    public const int TPM_LEFTBUTTON = 0x0000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_RIGHTBUTTON"]/*' />
    [NativeTypeName("#define TPM_RIGHTBUTTON 0x0002L")]
    public const int TPM_RIGHTBUTTON = 0x0002;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_LEFTALIGN"]/*' />
    [NativeTypeName("#define TPM_LEFTALIGN 0x0000L")]
    public const int TPM_LEFTALIGN = 0x0000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_CENTERALIGN"]/*' />
    [NativeTypeName("#define TPM_CENTERALIGN 0x0004L")]
    public const int TPM_CENTERALIGN = 0x0004;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_RIGHTALIGN"]/*' />
    [NativeTypeName("#define TPM_RIGHTALIGN 0x0008L")]
    public const int TPM_RIGHTALIGN = 0x0008;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_TOPALIGN"]/*' />
    [NativeTypeName("#define TPM_TOPALIGN 0x0000L")]
    public const int TPM_TOPALIGN = 0x0000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_VCENTERALIGN"]/*' />
    [NativeTypeName("#define TPM_VCENTERALIGN 0x0010L")]
    public const int TPM_VCENTERALIGN = 0x0010;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_BOTTOMALIGN"]/*' />
    [NativeTypeName("#define TPM_BOTTOMALIGN 0x0020L")]
    public const int TPM_BOTTOMALIGN = 0x0020;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_HORIZONTAL"]/*' />
    [NativeTypeName("#define TPM_HORIZONTAL 0x0000L")]
    public const int TPM_HORIZONTAL = 0x0000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_VERTICAL"]/*' />
    [NativeTypeName("#define TPM_VERTICAL 0x0040L")]
    public const int TPM_VERTICAL = 0x0040;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_NONOTIFY"]/*' />
    [NativeTypeName("#define TPM_NONOTIFY 0x0080L")]
    public const int TPM_NONOTIFY = 0x0080;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_RETURNCMD"]/*' />
    [NativeTypeName("#define TPM_RETURNCMD 0x0100L")]
    public const int TPM_RETURNCMD = 0x0100;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_RECURSE"]/*' />
    [NativeTypeName("#define TPM_RECURSE 0x0001L")]
    public const int TPM_RECURSE = 0x0001;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_HORPOSANIMATION"]/*' />
    [NativeTypeName("#define TPM_HORPOSANIMATION 0x0400L")]
    public const int TPM_HORPOSANIMATION = 0x0400;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_HORNEGANIMATION"]/*' />
    [NativeTypeName("#define TPM_HORNEGANIMATION 0x0800L")]
    public const int TPM_HORNEGANIMATION = 0x0800;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_VERPOSANIMATION"]/*' />
    [NativeTypeName("#define TPM_VERPOSANIMATION 0x1000L")]
    public const int TPM_VERPOSANIMATION = 0x1000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_VERNEGANIMATION"]/*' />
    [NativeTypeName("#define TPM_VERNEGANIMATION 0x2000L")]
    public const int TPM_VERNEGANIMATION = 0x2000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_NOANIMATION"]/*' />
    [NativeTypeName("#define TPM_NOANIMATION 0x4000L")]
    public const int TPM_NOANIMATION = 0x4000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_LAYOUTRTL"]/*' />
    [NativeTypeName("#define TPM_LAYOUTRTL 0x8000L")]
    public const int TPM_LAYOUTRTL = 0x8000;

    /// <include file='TPM.xml' path='doc/member[@name="TPM.TPM_WORKAREA"]/*' />
    [NativeTypeName("#define TPM_WORKAREA 0x10000L")]
    public const int TPM_WORKAREA = 0x10000;
}
