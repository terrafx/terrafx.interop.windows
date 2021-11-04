// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BACC67A-2F1D-42D0-897E-6FF62DD533BB")]
    [NativeTypeName("struct IDedupReadFileCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDedupReadFileCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDedupReadFileCallback*, Guid*, void**, int>)(lpVtbl[0]))((IDedupReadFileCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDedupReadFileCallback*, uint>)(lpVtbl[1]))((IDedupReadFileCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDedupReadFileCallback*, uint>)(lpVtbl[2]))((IDedupReadFileCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ReadBackupFile([NativeTypeName("BSTR")] ushort* FileFullPath, [NativeTypeName("long long")] long FileOffset, [NativeTypeName("ULONG")] uint SizeToRead, byte* FileBuffer, [NativeTypeName("ULONG *")] uint* ReturnedSize, [NativeTypeName("DWORD")] uint Flags)
        {
            return ((delegate* unmanaged<IDedupReadFileCallback*, ushort*, long, uint, byte*, uint*, uint, int>)(lpVtbl[3]))((IDedupReadFileCallback*)Unsafe.AsPointer(ref this), FileFullPath, FileOffset, SizeToRead, FileBuffer, ReturnedSize, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OrderContainersRestore([NativeTypeName("ULONG")] uint NumberOfContainers, [NativeTypeName("BSTR *")] ushort** ContainerPaths, [NativeTypeName("ULONG *")] uint* ReadPlanEntries, DEDUP_CONTAINER_EXTENT** ReadPlan)
        {
            return ((delegate* unmanaged<IDedupReadFileCallback*, uint, ushort**, uint*, DEDUP_CONTAINER_EXTENT**, int>)(lpVtbl[4]))((IDedupReadFileCallback*)Unsafe.AsPointer(ref this), NumberOfContainers, ContainerPaths, ReadPlanEntries, ReadPlan);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT PreviewContainerRead([NativeTypeName("BSTR")] ushort* FileFullPath, [NativeTypeName("ULONG")] uint NumberOfReads, DDP_FILE_EXTENT* ReadOffsets)
        {
            return ((delegate* unmanaged<IDedupReadFileCallback*, ushort*, uint, DDP_FILE_EXTENT*, int>)(lpVtbl[5]))((IDedupReadFileCallback*)Unsafe.AsPointer(ref this), FileFullPath, NumberOfReads, ReadOffsets);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDedupReadFileCallback*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDedupReadFileCallback*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDedupReadFileCallback*, uint> Release;

            [NativeTypeName("HRESULT (BSTR, long long, ULONG, BYTE *, ULONG *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDedupReadFileCallback*, ushort*, long, uint, byte*, uint*, uint, int> ReadBackupFile;

            [NativeTypeName("HRESULT (ULONG, BSTR *, ULONG *, DEDUP_CONTAINER_EXTENT **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDedupReadFileCallback*, uint, ushort**, uint*, DEDUP_CONTAINER_EXTENT**, int> OrderContainersRestore;

            [NativeTypeName("HRESULT (BSTR, ULONG, DDP_FILE_EXTENT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDedupReadFileCallback*, ushort*, uint, DDP_FILE_EXTENT*, int> PreviewContainerRead;
        }
    }
}
