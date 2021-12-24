// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='PathData.xml' path='doc/member[@name="PathData"]/*' />
public unsafe partial struct PathData
{
    /// <include file='PathData.xml' path='doc/member[@name="PathData.Count"]/*' />
    public int Count;

    /// <include file='PathData.xml' path='doc/member[@name="PathData.Points"]/*' />
    [NativeTypeName("Gdiplus::PointF *")]
    public PointF* Points;

    /// <include file='PathData.xml' path='doc/member[@name="PathData.Types"]/*' />
    public byte* Types;

    public PathData()
    {
        Count = 0;
        Points = null;
        Types = null;
    }
}
