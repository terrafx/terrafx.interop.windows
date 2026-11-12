// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.DirectX;

public partial struct COMPOSITION_TARGET_ID
{
    public static bool operator ==(in COMPOSITION_TARGET_ID lhs, in COMPOSITION_TARGET_ID rhs)
        => (lhs.displayAdapterLuid.LowPart == rhs.displayAdapterLuid.LowPart)
        && (lhs.displayAdapterLuid.HighPart == rhs.displayAdapterLuid.HighPart)
        && (lhs.renderAdapterLuid.LowPart == rhs.renderAdapterLuid.LowPart)
        && (lhs.renderAdapterLuid.HighPart == rhs.renderAdapterLuid.HighPart)
        && (lhs.vidPnSourceId == rhs.vidPnSourceId)
        && (lhs.vidPnTargetId == rhs.vidPnTargetId)
        && ((lhs.uniqueId == rhs.uniqueId) || (lhs.uniqueId == 0) || (rhs.uniqueId == 0));

    public static bool operator !=(in COMPOSITION_TARGET_ID lhs, in COMPOSITION_TARGET_ID rhs) => !(lhs == rhs);

    public override readonly bool Equals(object? obj) => (obj is COMPOSITION_TARGET_ID other) && (this == other);

    public override readonly int GetHashCode()
    {
        // uniqueId is a wildcard in operator==, so it cannot contribute to the hash.
        return HashCode.Combine(displayAdapterLuid.LowPart, displayAdapterLuid.HighPart, renderAdapterLuid.LowPart, renderAdapterLuid.HighPart, vidPnSourceId, vidPnTargetId);
    }
}
