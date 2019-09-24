// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public struct D3D12_BOX
    {
        [NativeTypeName("UINT")]
        public uint left;

        [NativeTypeName("UINT")]
        public uint top;

        [NativeTypeName("UINT")]
        public uint front;

        [NativeTypeName("UINT")]
        public uint right;

        [NativeTypeName("UINT")]
        public uint bottom;

        [NativeTypeName("UINT")]
        public uint back;

        public D3D12_BOX(int Left, int Right)
        {
            left = (uint)Left;
            top = 0;
            front = 0;
            right = (uint)Right;
            bottom = 1;
            back = 1;
        }

        public D3D12_BOX(int Left, int Top, int Right, int Bottom)
        {
            left = (uint)Left;
            top = (uint)Top;
            front = 0;
            right = (uint)Right;
            bottom = (uint)Bottom;
            back = 1;
        }

        public D3D12_BOX(int Left, int Top, int Front, int Right, int Bottom, int Back)
        {
            left = (uint)Left;
            top = (uint)Top;
            front = (uint)Front;
            right = (uint)Right;
            bottom = (uint)Bottom;
            back = (uint)Back;
        }

        public static bool operator ==(D3D12_BOX l, D3D12_BOX r)
        {
            return (l.left == r.left)
                && (l.top == r.top)
                && (l.front == r.front)
                && (l.right == r.right)
                && (l.bottom == r.bottom)
                && (l.back == r.back);
        }

        public static bool operator !=(D3D12_BOX l, D3D12_BOX r)
        {
            return !(l == r);
        }

        public override bool Equals(object? obj)
        {
            return (obj is D3D12_BOX other) && (this == other);
        }

        public override int GetHashCode() => HashCode.Combine(
            left,
            top,
            front,
            right,
            bottom,
            back
        );
    }
}
