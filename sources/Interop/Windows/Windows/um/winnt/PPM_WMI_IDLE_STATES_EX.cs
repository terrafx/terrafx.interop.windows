// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public unsafe partial struct PPM_WMI_IDLE_STATES_EX
{
    [NativeTypeName("DWORD")]
    public uint Type;

    [NativeTypeName("DWORD")]
    public uint Count;

    [NativeTypeName("DWORD")]
    public uint TargetState;

    [NativeTypeName("DWORD")]
    public uint OldState;

    [NativeTypeName("PVOID")]
    public void* TargetProcessors;

    [NativeTypeName("PPM_WMI_IDLE_STATE [1]")]
    public _State_e__FixedBuffer State;

    public partial struct _State_e__FixedBuffer
    {
        public PPM_WMI_IDLE_STATE e0;

        public ref PPM_WMI_IDLE_STATE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<PPM_WMI_IDLE_STATE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
