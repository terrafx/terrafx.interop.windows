// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum htmlPersistState
    {
        htmlPersistStateNormal = 0,
        htmlPersistStateFavorite = 1,
        htmlPersistStateHistory = 2,
        htmlPersistStateSnapshot = 3,
        htmlPersistStateUserData = 4,
        htmlPersistState_Max = 2147483647,
    }
}
