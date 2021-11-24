// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssCaptureSnapshot(HANDLE ProcessHandle, PSS_CAPTURE_FLAGS CaptureFlags, [NativeTypeName("DWORD")] uint ThreadContextFlags, HPSS* SnapshotHandle);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssFreeSnapshot(HANDLE ProcessHandle, HPSS SnapshotHandle);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssQuerySnapshot(HPSS SnapshotHandle, PSS_QUERY_INFORMATION_CLASS InformationClass, void* Buffer, [NativeTypeName("DWORD")] uint BufferLength);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssWalkSnapshot(HPSS SnapshotHandle, PSS_WALK_INFORMATION_CLASS InformationClass, HPSSWALK WalkMarkerHandle, void* Buffer, [NativeTypeName("DWORD")] uint BufferLength);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssDuplicateSnapshot(HANDLE SourceProcessHandle, HPSS SnapshotHandle, HANDLE TargetProcessHandle, HPSS* TargetSnapshotHandle, PSS_DUPLICATE_FLAGS Flags);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssWalkMarkerCreate([NativeTypeName("const PSS_ALLOCATOR *")] PSS_ALLOCATOR* Allocator, HPSSWALK* WalkMarkerHandle);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssWalkMarkerFree(HPSSWALK WalkMarkerHandle);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssWalkMarkerGetPosition(HPSSWALK WalkMarkerHandle, [NativeTypeName("ULONG_PTR *")] nuint* Position);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssWalkMarkerSetPosition(HPSSWALK WalkMarkerHandle, [NativeTypeName("ULONG_PTR")] nuint Position);

    [SupportedOSPlatform("windows8.1")]
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint PssWalkMarkerSeekToBeginning(HPSSWALK WalkMarkerHandle);

    [NativeTypeName("#define PSS_PERF_RESOLUTION 1000000")]
    public const int PSS_PERF_RESOLUTION = 1000000;
}
