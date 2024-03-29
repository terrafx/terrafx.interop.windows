// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.Gdiplus;

[NativeTypeName("struct GpPrivateFontCollection : GpFontCollection")]
[NativeInheritance("GpFontCollection")]
public partial struct GpPrivateFontCollection : GpPrivateFontCollection.Interface
{
    public interface Interface : GpFontCollection.Interface
    {
    }
}
