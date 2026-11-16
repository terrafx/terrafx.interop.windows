// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DWM
{
    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_BB_ENABLE"]/*' />
    [NativeTypeName("#define DWM_BB_ENABLE 0x00000001")]
    public const int DWM_BB_ENABLE = 0x00000001;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_BB_BLURREGION"]/*' />
    [NativeTypeName("#define DWM_BB_BLURREGION 0x00000002")]
    public const int DWM_BB_BLURREGION = 0x00000002;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_BB_TRANSITIONONMAXIMIZED"]/*' />
    [NativeTypeName("#define DWM_BB_TRANSITIONONMAXIMIZED 0x00000004")]
    public const int DWM_BB_TRANSITIONONMAXIMIZED = 0x00000004;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_CLOAKED_APP"]/*' />
    [NativeTypeName("#define DWM_CLOAKED_APP 0x00000001")]
    public const int DWM_CLOAKED_APP = 0x00000001;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_CLOAKED_SHELL"]/*' />
    [NativeTypeName("#define DWM_CLOAKED_SHELL 0x00000002")]
    public const int DWM_CLOAKED_SHELL = 0x00000002;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_CLOAKED_INHERITED"]/*' />
    [NativeTypeName("#define DWM_CLOAKED_INHERITED 0x00000004")]
    public const int DWM_CLOAKED_INHERITED = 0x00000004;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_TNP_RECTDESTINATION"]/*' />
    [NativeTypeName("#define DWM_TNP_RECTDESTINATION 0x00000001")]
    public const int DWM_TNP_RECTDESTINATION = 0x00000001;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_TNP_RECTSOURCE"]/*' />
    [NativeTypeName("#define DWM_TNP_RECTSOURCE 0x00000002")]
    public const int DWM_TNP_RECTSOURCE = 0x00000002;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_TNP_OPACITY"]/*' />
    [NativeTypeName("#define DWM_TNP_OPACITY 0x00000004")]
    public const int DWM_TNP_OPACITY = 0x00000004;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_TNP_VISIBLE"]/*' />
    [NativeTypeName("#define DWM_TNP_VISIBLE 0x00000008")]
    public const int DWM_TNP_VISIBLE = 0x00000008;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_TNP_SOURCECLIENTAREAONLY"]/*' />
    [NativeTypeName("#define DWM_TNP_SOURCECLIENTAREAONLY 0x00000010")]
    public const int DWM_TNP_SOURCECLIENTAREAONLY = 0x00000010;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_FRAME_DURATION_DEFAULT"]/*' />
    [NativeTypeName("#define DWM_FRAME_DURATION_DEFAULT -1")]
    public const int DWM_FRAME_DURATION_DEFAULT = -1;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_EC_DISABLECOMPOSITION"]/*' />
    [NativeTypeName("#define DWM_EC_DISABLECOMPOSITION 0")]
    public const int DWM_EC_DISABLECOMPOSITION = 0;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_EC_ENABLECOMPOSITION"]/*' />
    [NativeTypeName("#define DWM_EC_ENABLECOMPOSITION 1")]
    public const int DWM_EC_ENABLECOMPOSITION = 1;

    /// <include file='DWM.xml' path='doc/member[@name="DWM.DWM_SIT_DISPLAYFRAME"]/*' />
    [NativeTypeName("#define DWM_SIT_DISPLAYFRAME 0x00000001")]
    public const int DWM_SIT_DISPLAYFRAME = 0x00000001;
}
