// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_D3D10_SB_TOKENIZED_PROGRAM_LENGTH (0xffffffff)")]
    public const uint MAX_D3D10_SB_TOKENIZED_PROGRAM_LENGTH = (0xffffffff);

    [NativeTypeName("#define MAX_D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH 127")]
    public const int MAX_D3D10_SB_TOKENIZED_INSTRUCTION_LENGTH = 127;
}
