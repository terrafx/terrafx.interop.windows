// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_BASIC_LIMIT_INFORMATION
    {
        public LARGE_INTEGER PerProcessUserTimeLimit;

        public LARGE_INTEGER PerJobUserTimeLimit;

        [NativeTypeName("DWORD")]
        public uint LimitFlags;

        [NativeTypeName("SIZE_T")]
        public UIntPtr MinimumWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public UIntPtr MaximumWorkingSetSize;

        [NativeTypeName("DWORD")]
        public uint ActiveProcessLimit;

        [NativeTypeName("ULONG_PTR")]
        public UIntPtr Affinity;

        [NativeTypeName("DWORD")]
        public uint PriorityClass;

        [NativeTypeName("DWORD")]
        public uint SchedulingClass;
    }
}
