// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.1")]
public unsafe partial struct PSS_HANDLE_ENTRY
{
    public HANDLE Handle;

    public PSS_HANDLE_FLAGS Flags;

    public PSS_OBJECT_TYPE ObjectType;

    public FILETIME CaptureTime;

    [NativeTypeName("DWORD")]
    public uint Attributes;

    [NativeTypeName("DWORD")]
    public uint GrantedAccess;

    [NativeTypeName("DWORD")]
    public uint HandleCount;

    [NativeTypeName("DWORD")]
    public uint PointerCount;

    [NativeTypeName("DWORD")]
    public uint PagedPoolCharge;

    [NativeTypeName("DWORD")]
    public uint NonPagedPoolCharge;

    public FILETIME CreationTime;

    [NativeTypeName("WORD")]
    public ushort TypeNameLength;

    [NativeTypeName("const wchar_t *")]
    public ushort* TypeName;

    [NativeTypeName("WORD")]
    public ushort ObjectNameLength;

    [NativeTypeName("const wchar_t *")]
    public ushort* ObjectName;

    [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ProcessSnapshot.h:258:5)")]
    public _TypeSpecificInformation_e__Union TypeSpecificInformation;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _TypeSpecificInformation_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ProcessSnapshot.h:261:9)")]
        public _Process_e__Struct Process;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ProcessSnapshot.h:272:9)")]
        public _Thread_e__Struct Thread;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ProcessSnapshot.h:284:9)")]
        public _Mutant_e__Struct Mutant;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ProcessSnapshot.h:292:9)")]
        public _Event_e__Struct Event;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ProcessSnapshot.h:298:9)")]
        public _Section_e__Struct Section;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/ProcessSnapshot.h:306:9)")]
        public _Semaphore_e__Struct Semaphore;

        public unsafe partial struct _Process_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint ExitStatus;

            public void* PebBaseAddress;

            [NativeTypeName("ULONG_PTR")]
            public nuint AffinityMask;

            [NativeTypeName("LONG")]
            public int BasePriority;

            [NativeTypeName("DWORD")]
            public uint ProcessId;

            [NativeTypeName("DWORD")]
            public uint ParentProcessId;

            [NativeTypeName("DWORD")]
            public uint Flags;
        }

        public unsafe partial struct _Thread_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint ExitStatus;

            public void* TebBaseAddress;

            [NativeTypeName("DWORD")]
            public uint ProcessId;

            [NativeTypeName("DWORD")]
            public uint ThreadId;

            [NativeTypeName("ULONG_PTR")]
            public nuint AffinityMask;

            public int Priority;

            public int BasePriority;

            public void* Win32StartAddress;
        }

        public partial struct _Mutant_e__Struct
        {
            [NativeTypeName("LONG")]
            public int CurrentCount;

            public BOOL Abandoned;

            [NativeTypeName("DWORD")]
            public uint OwnerProcessId;

            [NativeTypeName("DWORD")]
            public uint OwnerThreadId;
        }

        public partial struct _Event_e__Struct
        {
            public BOOL ManualReset;

            public BOOL Signaled;
        }

        public unsafe partial struct _Section_e__Struct
        {
            public void* BaseAddress;

            [NativeTypeName("DWORD")]
            public uint AllocationAttributes;

            public LARGE_INTEGER MaximumSize;
        }

        public partial struct _Semaphore_e__Struct
        {
            [NativeTypeName("LONG")]
            public int CurrentCount;

            [NativeTypeName("LONG")]
            public int MaximumCount;
        }
    }
}
