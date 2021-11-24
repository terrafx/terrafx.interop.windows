// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.DirectX;

namespace TerraFX.Interop.WinRT;

[NativeTypeName("uint32_t")]
public enum MLOperatorExecutionType : uint
{
    Undefined = 0,
    Cpu = 1,
    D3D12 = 2,
}
