// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct UMS_SCHEDULER_STARTUP_INFO
    {
        [NativeTypeName("ULONG")]
        public uint UmsVersion;

        [NativeTypeName("PUMS_COMPLETION_LIST")]
        public void* CompletionList;

        [NativeTypeName("PUMS_SCHEDULER_ENTRY_POINT")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<RTL_UMS_SCHEDULER_REASON, nuint, void*, void>* SchedulerProc;
#else
        public void* _SchedulerProc;

        public delegate* unmanaged[Stdcall]<RTL_UMS_SCHEDULER_REASON, nuint, void*, void>* SchedulerProc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<RTL_UMS_SCHEDULER_REASON, nuint, void*, void>*)_SchedulerProc;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _SchedulerProc = value;
            }
        }
#endif

        [NativeTypeName("PVOID")]
        public void* SchedulerParam;
    }
}
