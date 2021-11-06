// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MINIDUMP_HANDLE_OBJECT_INFORMATION_TYPE
    {
        MiniHandleObjectInformationNone,
        MiniThreadInformation1,
        MiniMutantInformation1,
        MiniMutantInformation2,
        MiniProcessInformation1,
        MiniProcessInformation2,
        MiniEventInformation1,
        MiniSectionInformation1,
        MiniSemaphoreInformation1,
        MiniHandleObjectInformationTypeMax,
    }
}
