// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public partial struct DEVPROPKEY : IEquatable<DEVPROPKEY>
{
    public readonly bool Equals(DEVPROPKEY other) => (pid == other.pid) && (fmtid == other.fmtid);

    public override readonly bool Equals(object? obj) => (obj is DEVPROPKEY other) && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(fmtid, pid);

    public static bool operator ==(DEVPROPKEY left, DEVPROPKEY right) => left.Equals(right);

    public static bool operator !=(DEVPROPKEY left, DEVPROPKEY right) => !left.Equals(right);
}
