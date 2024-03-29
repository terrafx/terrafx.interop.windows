// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.Gdiplus;

[NativeTypeName("struct GpHatch : GpBrush")]
[NativeInheritance("GpBrush")]
public partial struct GpHatch : GpHatch.Interface
{
    public interface Interface : GpBrush.Interface
    {
    }
}
