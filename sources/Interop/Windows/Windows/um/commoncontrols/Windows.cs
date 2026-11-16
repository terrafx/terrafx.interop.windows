// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImageList_CoCreateInstance"]/*' />
    [DllImport("comctl32", ExactSpelling = true)]
    public static extern HRESULT ImageList_CoCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IUnknown *")] IUnknown* punkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILIF_ALPHA"]/*' />
    [NativeTypeName("#define ILIF_ALPHA 0x00000001")]
    public const int ILIF_ALPHA = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILIF_LOWQUALITY"]/*' />
    [NativeTypeName("#define ILIF_LOWQUALITY 0x00000002")]
    public const int ILIF_LOWQUALITY = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILDRF_IMAGELOWQUALITY"]/*' />
    [NativeTypeName("#define ILDRF_IMAGELOWQUALITY 0x00000001")]
    public const int ILDRF_IMAGELOWQUALITY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILDRF_OVERLAYLOWQUALITY"]/*' />
    [NativeTypeName("#define ILDRF_OVERLAYLOWQUALITY 0x00000010")]
    public const int ILDRF_OVERLAYLOWQUALITY = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_DEFAULT"]/*' />
    [NativeTypeName("#define ILR_DEFAULT 0x0000")]
    public const int ILR_DEFAULT = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_HORIZONTAL_LEFT"]/*' />
    [NativeTypeName("#define ILR_HORIZONTAL_LEFT 0x0000")]
    public const int ILR_HORIZONTAL_LEFT = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_HORIZONTAL_CENTER"]/*' />
    [NativeTypeName("#define ILR_HORIZONTAL_CENTER 0x0001")]
    public const int ILR_HORIZONTAL_CENTER = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_HORIZONTAL_RIGHT"]/*' />
    [NativeTypeName("#define ILR_HORIZONTAL_RIGHT 0x0002")]
    public const int ILR_HORIZONTAL_RIGHT = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_VERTICAL_TOP"]/*' />
    [NativeTypeName("#define ILR_VERTICAL_TOP 0x0000")]
    public const int ILR_VERTICAL_TOP = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_VERTICAL_CENTER"]/*' />
    [NativeTypeName("#define ILR_VERTICAL_CENTER 0x0010")]
    public const int ILR_VERTICAL_CENTER = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_VERTICAL_BOTTOM"]/*' />
    [NativeTypeName("#define ILR_VERTICAL_BOTTOM 0x0020")]
    public const int ILR_VERTICAL_BOTTOM = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_SCALE_CLIP"]/*' />
    [NativeTypeName("#define ILR_SCALE_CLIP 0x0000")]
    public const int ILR_SCALE_CLIP = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILR_SCALE_ASPECTRATIO"]/*' />
    [NativeTypeName("#define ILR_SCALE_ASPECTRATIO 0x0100")]
    public const int ILR_SCALE_ASPECTRATIO = 0x0100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILGOS_ALWAYS"]/*' />
    [NativeTypeName("#define ILGOS_ALWAYS 0x00000000")]
    public const int ILGOS_ALWAYS = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILGOS_FROMSTANDBY"]/*' />
    [NativeTypeName("#define ILGOS_FROMSTANDBY 0x00000001")]
    public const int ILGOS_FROMSTANDBY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILFIP_ALWAYS"]/*' />
    [NativeTypeName("#define ILFIP_ALWAYS 0x00000000")]
    public const int ILFIP_ALWAYS = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILFIP_FROMSTANDBY"]/*' />
    [NativeTypeName("#define ILFIP_FROMSTANDBY 0x00000001")]
    public const int ILFIP_FROMSTANDBY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILDI_PURGE"]/*' />
    [NativeTypeName("#define ILDI_PURGE 0x00000001")]
    public const int ILDI_PURGE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILDI_STANDBY"]/*' />
    [NativeTypeName("#define ILDI_STANDBY 0x00000002")]
    public const int ILDI_STANDBY = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILDI_RESETACCESS"]/*' />
    [NativeTypeName("#define ILDI_RESETACCESS 0x00000004")]
    public const int ILDI_RESETACCESS = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ILDI_QUERYACCESS"]/*' />
    [NativeTypeName("#define ILDI_QUERYACCESS 0x00000008")]
    public const int ILDI_QUERYACCESS = 0x00000008;
}
