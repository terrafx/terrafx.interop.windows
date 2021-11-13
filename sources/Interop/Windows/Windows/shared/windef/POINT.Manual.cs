// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public partial struct POINT : IEquatable<POINT>
    {
        public POINT([NativeTypeName("INT32")] int x = 0, [NativeTypeName("INT32")] int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==([NativeTypeName("const POINT &")] in POINT l, [NativeTypeName("const POINT &")] in POINT r)
        {
            return (l.x == r.x)
                && (l.y == r.y);
        }

        public static bool operator !=([NativeTypeName("const POINT &")] in POINT l, [NativeTypeName("const POINT &")] in POINT r)
            => !(l == r);

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(POINT other) => this == other;

        public override int GetHashCode() => HashCode.Combine(x, y);
    }
}
