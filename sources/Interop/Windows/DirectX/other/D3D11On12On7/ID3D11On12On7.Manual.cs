// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D11On12On7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

[Guid("00000000-0000-0000-0000-000000000000")]
public partial struct ID3D11On12On7
{
    static ref readonly Guid IHaveNativeGuid.GUID => throw new NotImplementedException();
}
