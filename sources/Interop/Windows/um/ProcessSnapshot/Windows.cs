// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssCaptureSnapshot([NativeTypeName("HANDLE")] IntPtr ProcessHandle, PSS_CAPTURE_FLAGS CaptureFlags, [NativeTypeName("DWORD")] uint ThreadContextFlags, [NativeTypeName("HPSS *")] IntPtr* SnapshotHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssFreeSnapshot([NativeTypeName("HANDLE")] IntPtr ProcessHandle, [NativeTypeName("HPSS")] IntPtr SnapshotHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssQuerySnapshot([NativeTypeName("HPSS")] IntPtr SnapshotHandle, PSS_QUERY_INFORMATION_CLASS InformationClass, [NativeTypeName("void *")] void* Buffer, [NativeTypeName("DWORD")] uint BufferLength);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssWalkSnapshot([NativeTypeName("HPSS")] IntPtr SnapshotHandle, PSS_WALK_INFORMATION_CLASS InformationClass, [NativeTypeName("HPSSWALK")] IntPtr WalkMarkerHandle, [NativeTypeName("void *")] void* Buffer, [NativeTypeName("DWORD")] uint BufferLength);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssDuplicateSnapshot([NativeTypeName("HANDLE")] IntPtr SourceProcessHandle, [NativeTypeName("HPSS")] IntPtr SnapshotHandle, [NativeTypeName("HANDLE")] IntPtr TargetProcessHandle, [NativeTypeName("HPSS *")] IntPtr* TargetSnapshotHandle, PSS_DUPLICATE_FLAGS Flags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssWalkMarkerCreate([NativeTypeName("const PSS_ALLOCATOR *")] PSS_ALLOCATOR* Allocator, [NativeTypeName("HPSSWALK *")] IntPtr* WalkMarkerHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssWalkMarkerFree([NativeTypeName("HPSSWALK")] IntPtr WalkMarkerHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssWalkMarkerGetPosition([NativeTypeName("HPSSWALK")] IntPtr WalkMarkerHandle, [NativeTypeName("ULONG_PTR *")] nuint* Position);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssWalkMarkerSetPosition([NativeTypeName("HPSSWALK")] IntPtr WalkMarkerHandle, [NativeTypeName("ULONG_PTR")] nuint Position);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint PssWalkMarkerSeekToBeginning([NativeTypeName("HPSSWALK")] IntPtr WalkMarkerHandle);

        [NativeTypeName("#define PSS_PERF_RESOLUTION 1000000")]
        public const int PSS_PERF_RESOLUTION = 1000000;
    }
}
