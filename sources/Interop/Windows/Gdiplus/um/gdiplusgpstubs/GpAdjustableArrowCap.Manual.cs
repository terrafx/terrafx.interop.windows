// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.Gdiplus;

[NativeTypeName("struct GpAdjustableArrowCap : GpCustomLineCap")]
[NativeInheritance("GpCustomLineCap")]
public partial struct GpAdjustableArrowCap : GpAdjustableArrowCap.Interface
{
    public interface Interface : GpCustomLineCap.Interface
    {
    }
}
