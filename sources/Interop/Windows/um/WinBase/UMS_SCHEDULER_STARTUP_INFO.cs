// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct UMS_SCHEDULER_STARTUP_INFO
    {
        [NativeTypeName("ULONG")]
        public uint UmsVersion;

        [NativeTypeName("PUMS_COMPLETION_LIST")]
        public void* CompletionList;

        [NativeTypeName("PUMS_SCHEDULER_ENTRY_POINT")]
        public delegate* stdcall<RTL_UMS_SCHEDULER_REASON, nuint, void*, void>* SchedulerProc;

        [NativeTypeName("PVOID")]
        public void* SchedulerParam;
    }
}
