// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIA
{
    /// <include file='DIA.xml' path='doc/member[@name="DIA.DIA_FORCEFEEDBACK"]/*' />
    [NativeTypeName("#define DIA_FORCEFEEDBACK 0x00000001")]
    public const int DIA_FORCEFEEDBACK = 0x00000001;

    /// <include file='DIA.xml' path='doc/member[@name="DIA.DIA_APPMAPPED"]/*' />
    [NativeTypeName("#define DIA_APPMAPPED 0x00000002")]
    public const int DIA_APPMAPPED = 0x00000002;

    /// <include file='DIA.xml' path='doc/member[@name="DIA.DIA_APPNOMAP"]/*' />
    [NativeTypeName("#define DIA_APPNOMAP 0x00000004")]
    public const int DIA_APPNOMAP = 0x00000004;

    /// <include file='DIA.xml' path='doc/member[@name="DIA.DIA_NORANGE"]/*' />
    [NativeTypeName("#define DIA_NORANGE 0x00000008")]
    public const int DIA_NORANGE = 0x00000008;

    /// <include file='DIA.xml' path='doc/member[@name="DIA.DIA_APPFIXED"]/*' />
    [NativeTypeName("#define DIA_APPFIXED 0x00000010")]
    public const int DIA_APPFIXED = 0x00000010;
}
