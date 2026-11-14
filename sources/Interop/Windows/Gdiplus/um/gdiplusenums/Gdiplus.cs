// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

public static partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.FlatnessDefault"]/*' />
    [NativeTypeName("const float")]
    public const float FlatnessDefault = 1.0f / 4.0f;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GDIP_EMFPLUS_RECORD_BASE"]/*' />
    [NativeTypeName("#define GDIP_EMFPLUS_RECORD_BASE 0x00004000")]
    public const int GDIP_EMFPLUS_RECORD_BASE = 0x00004000;

    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GDIP_WMF_RECORD_BASE"]/*' />
    [NativeTypeName("#define GDIP_WMF_RECORD_BASE 0x00010000")]
    public const int GDIP_WMF_RECORD_BASE = 0x00010000;
}
