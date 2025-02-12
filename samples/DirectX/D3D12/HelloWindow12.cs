// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12HelloWindow.h in https://github.com/Microsoft/DirectX-Graphics-Samples
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.Versioning;

namespace TerraFX.Samples.DirectX.D3D12;

[SupportedOSPlatform("windows10.0")]
public unsafe class HelloWindow12(string name) : DX12Sample(name)
{
    protected override void Draw()
    {
    }

    public override void OnUpdate(TimeSpan delta)
    {
    }
}
