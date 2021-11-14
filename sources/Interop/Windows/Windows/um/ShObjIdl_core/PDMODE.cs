// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum PDMODE
    {
        PDM_DEFAULT = 0,
        PDM_RUN = 0x1,
        PDM_PREFLIGHT = 0x2,
        PDM_UNDOING = 0x4,
        PDM_ERRORSBLOCKING = 0x8,
        PDM_INDETERMINATE = 0x10,
    }
}
