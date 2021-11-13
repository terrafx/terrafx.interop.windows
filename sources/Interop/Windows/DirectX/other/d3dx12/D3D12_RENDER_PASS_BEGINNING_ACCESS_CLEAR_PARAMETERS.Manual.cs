// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;

namespace TerraFX.Interop.DirectX
{
    public partial struct D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS : IEquatable<D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS>
    {
        public static bool operator ==([NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS a, [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS b)
            => a.ClearValue == b.ClearValue;

        public static bool operator !=([NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS a, [NativeTypeName("const D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS &")] in D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS b)
            => !(a == b);

        public override bool Equals(object? obj) => (obj is D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS other) && Equals(other);

        public bool Equals(D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS other) => this == other;

        public override int GetHashCode() => ClearValue.GetHashCode();
    }
}
