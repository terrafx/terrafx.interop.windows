// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;

namespace TerraFX.Interop.DirectX;

public partial struct D3D12_RENDER_PASS_RENDER_TARGET_DESC : IEquatable<D3D12_RENDER_PASS_RENDER_TARGET_DESC>
{
    public static bool operator ==([NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")] in D3D12_RENDER_PASS_RENDER_TARGET_DESC a, [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")] in D3D12_RENDER_PASS_RENDER_TARGET_DESC b)
    {
        if (a.cpuDescriptor.ptr != b.cpuDescriptor.ptr)
        {
            return false;
        }

        if (!(a.BeginningAccess == b.BeginningAccess))
        {
            return false;
        }

        if (!(a.EndingAccess == b.EndingAccess))
        {
            return false;
        }

        return true;
    }

    public static bool operator !=([NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")] in D3D12_RENDER_PASS_RENDER_TARGET_DESC a, [NativeTypeName("const D3D12_RENDER_PASS_RENDER_TARGET_DESC &")] in D3D12_RENDER_PASS_RENDER_TARGET_DESC b)
        => !(a == b);

    public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_RENDER_TARGET_DESC other) && Equals(other);

    public bool Equals(D3D12_RENDER_PASS_RENDER_TARGET_DESC other) => this == other;

    public override int GetHashCode() => HashCode.Combine(cpuDescriptor, BeginningAccess, EndingAccess);
}
