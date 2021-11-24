// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct JOBOBJECT_BASIC_PROCESS_ID_LIST
{
    [NativeTypeName("DWORD")]
    public uint NumberOfAssignedProcesses;

    [NativeTypeName("DWORD")]
    public uint NumberOfProcessIdsInList;

    [NativeTypeName("ULONG_PTR [1]")]
    public _ProcessIdList_e__FixedBuffer ProcessIdList;

    public partial struct _ProcessIdList_e__FixedBuffer
    {
        public nuint e0;

        public ref nuint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<nuint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
