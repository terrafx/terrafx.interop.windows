// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MSGF
{
    /// <include file='MSGF.xml' path='doc/member[@name="MSGF.MSGF_COMMCTRL_BEGINDRAG"]/*' />
    [NativeTypeName("#define MSGF_COMMCTRL_BEGINDRAG 0x4200")]
    public const int MSGF_COMMCTRL_BEGINDRAG = 0x4200;

    /// <include file='MSGF.xml' path='doc/member[@name="MSGF.MSGF_COMMCTRL_SIZEHEADER"]/*' />
    [NativeTypeName("#define MSGF_COMMCTRL_SIZEHEADER 0x4201")]
    public const int MSGF_COMMCTRL_SIZEHEADER = 0x4201;

    /// <include file='MSGF.xml' path='doc/member[@name="MSGF.MSGF_COMMCTRL_DRAGSELECT"]/*' />
    [NativeTypeName("#define MSGF_COMMCTRL_DRAGSELECT 0x4202")]
    public const int MSGF_COMMCTRL_DRAGSELECT = 0x4202;

    /// <include file='MSGF.xml' path='doc/member[@name="MSGF.MSGF_COMMCTRL_TOOLBARCUST"]/*' />
    [NativeTypeName("#define MSGF_COMMCTRL_TOOLBARCUST 0x4203")]
    public const int MSGF_COMMCTRL_TOOLBARCUST = 0x4203;
}
