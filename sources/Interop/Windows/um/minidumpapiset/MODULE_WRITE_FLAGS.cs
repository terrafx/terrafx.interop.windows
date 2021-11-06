// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MODULE_WRITE_FLAGS
    {
        ModuleWriteModule = 0x0001,
        ModuleWriteDataSeg = 0x0002,
        ModuleWriteMiscRecord = 0x0004,
        ModuleWriteCvRecord = 0x0008,
        ModuleReferencedByMemory = 0x0010,
        ModuleWriteTlsData = 0x0020,
        ModuleWriteCodeSegs = 0x0040,
    }
}
