// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.Gdiplus;

[NativeTypeName("struct GpMetafile : GpImage")]
[NativeInheritance("GpImage")]
public partial struct GpMetafile : GpMetafile.Interface
{
    public interface Interface : GpImage.Interface
    {
    }
}
