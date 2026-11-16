// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DDENUMOVERLAYZ
{
    /// <include file='DDENUMOVERLAYZ.xml' path='doc/member[@name="DDENUMOVERLAYZ.DDENUMOVERLAYZ_BACKTOFRONT"]/*' />
    [NativeTypeName("#define DDENUMOVERLAYZ_BACKTOFRONT 0x00000000l")]
    public const int DDENUMOVERLAYZ_BACKTOFRONT = 0x00000000;

    /// <include file='DDENUMOVERLAYZ.xml' path='doc/member[@name="DDENUMOVERLAYZ.DDENUMOVERLAYZ_FRONTTOBACK"]/*' />
    [NativeTypeName("#define DDENUMOVERLAYZ_FRONTTOBACK 0x00000001l")]
    public const int DDENUMOVERLAYZ_FRONTTOBACK = 0x00000001;
}
