// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d11on12on7.h in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d3d11on12", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetD3D11On12On7Interface([NativeTypeName("ID3D11On12On7 **")] ID3D11On12On7** ppIface);
    }
}
