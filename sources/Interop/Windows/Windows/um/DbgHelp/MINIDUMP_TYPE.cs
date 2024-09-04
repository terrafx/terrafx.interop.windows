// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

[Flags]
public enum MINIDUMP_TYPE
{
#pragma warning disable CA1069
    /* index 1. */
    MiniDumpNormal = 0x00000000,
#pragma warning restore CA1069
    /* index 2. */
    MiniDumpWithDataSegs = 0x00000001,
    /* index 3. */
    MiniDumpWithFullMemory = 0x00000002,
    /* index 4. */
    MiniDumpWithHandleData = 0x00000004,
    /* index 5. */
    MiniDumpFilterMemory = 0x00000008,
    /* index 6. */
    MiniDumpScanMemory = 0x00000010,
    /* index 7. */
    MiniDumpWithUnloadedModules = 0x00000020,
    /* index 8. */
    MiniDumpWithIndirectlyReferencedMemory = 0x00000040,
    /* index 9. */
    MiniDumpFilterModulePaths = 0x00000080,
    /* index 10. */
    MiniDumpWithProcessThreadData = 0x00000100,
    /* index 11. */
    MiniDumpWithPrivateReadWriteMemory = 0x00000200,
    /* index 12. */
    MiniDumpWithoutOptionalData = 0x00000400,
    /* index 13. */
    MiniDumpWithFullMemoryInfo = 0x00000800,
    /* index 14. */
    MiniDumpWithThreadInfo = 0x00001000,
    /* index 15. */
    MiniDumpWithCodeSegs = 0x00002000,
    /* index 16. */
    MiniDumpWithoutAuxiliaryState = 0x00004000,
    /* index 17. */
    MiniDumpWithFullAuxiliaryState = 0x00008000,
    /* index 18. */
    MiniDumpWithPrivateWriteCopyMemory = 0x00010000,
    /* index 19. */
    MiniDumpIgnoreInaccessibleMemory = 0x00020000,
    /* index 20. */
    MiniDumpWithTokenInformation = 0x00040000,
    /* index 21. */
    MiniDumpWithModuleHeaders = 0x00080000,
    /* index 22. */
    MiniDumpFilterTriage = 0x00100000,
    /* index 23. */
    MiniDumpWithAvxXStateContext = 0x00200000,
    /* index 24. */
    MiniDumpWithIptTrace = 0x00400000,
    /* index 25. */
    MiniDumpScanInaccessiblePartialPages = 0x00800000,
    /* index 26. */
    MiniDumpFilterWriteCombinedMemory = 0x01000000,
    /* index 27. */
    MiniDumpValidTypeFlags = 0x01ffffff,
}
