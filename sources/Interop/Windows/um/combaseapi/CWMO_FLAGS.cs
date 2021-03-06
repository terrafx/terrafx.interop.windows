// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum CWMO_FLAGS
    {
        CWMO_DEFAULT = 0,
        CWMO_DISPATCH_CALLS = 1,
        CWMO_DISPATCH_WINDOW_MESSAGES = 2,
    }
}
