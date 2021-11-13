// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum FILTER_STATE
    {
        State_Stopped = 0,
        State_Paused = (State_Stopped + 1),
        State_Running = (State_Paused + 1),
    }
}
