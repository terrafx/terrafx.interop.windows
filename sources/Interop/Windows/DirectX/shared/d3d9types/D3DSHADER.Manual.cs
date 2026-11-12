// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using static TerraFX.Interop.DirectX.D3DSI_;
using static TerraFX.Interop.DirectX.D3DSHADER_INSTRUCTION_OPCODE_TYPE;

namespace TerraFX.Interop.DirectX;

public static partial class D3DSHADER
{
    public static uint D3DSHADER_VERSION_MAJOR(uint Version) => (Version >> 8) & 0xFF;

    public static uint D3DSHADER_VERSION_MINOR(uint Version) => (Version >> 0) & 0xFF;

    public static uint D3DSHADER_COMMENT(uint DWordSize)
        => ((DWordSize << D3DSI_COMMENTSIZE_SHIFT) & (uint)(D3DSI_COMMENTSIZE_MASK)) | (uint)(D3DSIO_COMMENT);
}
