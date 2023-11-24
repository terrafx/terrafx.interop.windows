// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_PAINT_FEATURE_LEVEL.xml' path='doc/member[@name="DWRITE_PAINT_FEATURE_LEVEL"]/*' />
[NativeTypeName("INT32")]
public enum DWRITE_PAINT_FEATURE_LEVEL
{
    /// <include file='DWRITE_PAINT_FEATURE_LEVEL.xml' path='doc/member[@name="DWRITE_PAINT_FEATURE_LEVEL.DWRITE_PAINT_FEATURE_LEVEL_NONE"]/*' />
    DWRITE_PAINT_FEATURE_LEVEL_NONE = 0,

    /// <include file='DWRITE_PAINT_FEATURE_LEVEL.xml' path='doc/member[@name="DWRITE_PAINT_FEATURE_LEVEL.DWRITE_PAINT_FEATURE_LEVEL_COLR_V0"]/*' />
    DWRITE_PAINT_FEATURE_LEVEL_COLR_V0 = 1,

    /// <include file='DWRITE_PAINT_FEATURE_LEVEL.xml' path='doc/member[@name="DWRITE_PAINT_FEATURE_LEVEL.DWRITE_PAINT_FEATURE_LEVEL_COLR_V1"]/*' />
    DWRITE_PAINT_FEATURE_LEVEL_COLR_V1 = 2,
}
