// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='SizeF.xml' path='doc/member[@name="SizeF"]/*' />
public partial struct SizeF
{
    /// <include file='SizeF.xml' path='doc/member[@name="SizeF.Width"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float Width;

    /// <include file='SizeF.xml' path='doc/member[@name="SizeF.Height"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float Height;

    public SizeF()
    {
        Width = Height = 0.0f;
    }

    public unsafe SizeF([NativeTypeName("const Gdiplus::SizeF &")] SizeF* size)
    {
        Width = size->Width;
        Height = size->Height;
    }

    public SizeF([NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height)
    {
        Width = width;
        Height = height;
    }

    public unsafe BOOL Equals([NativeTypeName("const Gdiplus::SizeF &")] SizeF* sz)
    {
        return ((Width == sz->Width) && (Height == sz->Height)) ? 1 : 0;
    }

    public BOOL Empty()
    {
        return (Width == 0.0f && Height == 0.0f) ? 1 : 0;
    }
}
