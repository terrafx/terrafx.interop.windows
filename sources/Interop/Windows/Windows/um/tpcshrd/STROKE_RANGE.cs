// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct STROKE_RANGE
{
    [NativeTypeName("ULONG")]
    public uint iStrokeBegin;

    [NativeTypeName("ULONG")]
    public uint iStrokeEnd;
}
