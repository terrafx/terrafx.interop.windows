// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public partial struct SIZE : IEquatable<SIZE>
{
    public SIZE([NativeTypeName("INT32")] int cx = 0, [NativeTypeName("INT32")] int cy = 0)
    {
        this.cx = cx;
        this.cy = cy;
    }

    public static bool operator ==([NativeTypeName("const SIZE &")] in SIZE l, [NativeTypeName("const SIZE &")] in SIZE r)
    {
        return (l.cx == r.cx)
            && (l.cy == r.cy);
    }

    public static bool operator !=([NativeTypeName("const SIZE &")] in SIZE l, [NativeTypeName("const SIZE &")] in SIZE r)
        => !(l == r);

    public override bool Equals(object? obj) => (obj is SIZE other) && Equals(other);

    public bool Equals(SIZE other) => this == other;

    public override int GetHashCode() => HashCode.Combine(cx, cy);
}
