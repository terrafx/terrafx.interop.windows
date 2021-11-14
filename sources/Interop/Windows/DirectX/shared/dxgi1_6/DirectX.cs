// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public static partial class DirectX
    {
        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("dxgi", ExactSpelling = true)]
        public static extern HRESULT DXGIDeclareAdapterRemovalSupport();
    }
}
