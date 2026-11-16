// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct DEVPROPCOMPKEY : IEquatable<DEVPROPCOMPKEY>
{
    public readonly bool Equals(DEVPROPCOMPKEY other)
        => (Key == other.Key) && (Store == other.Store) && Windows.IsEqualLocaleName(LocaleName, other.LocaleName);

    public override readonly bool Equals(object? obj) => (obj is DEVPROPCOMPKEY other) && Equals(other);

    public override readonly int GetHashCode()
    {
        int localeNameHashCode = (LocaleName == null) ? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(new string(LocaleName));
        return HashCode.Combine(Key, Store, localeNameHashCode);
    }

    public static bool operator ==(DEVPROPCOMPKEY left, DEVPROPCOMPKEY right) => left.Equals(right);

    public static bool operator !=(DEVPROPCOMPKEY left, DEVPROPCOMPKEY right) => !left.Equals(right);
}
