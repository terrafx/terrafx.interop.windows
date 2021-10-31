// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E6D4D90-6738-11CF-9608-00AA00680DB4")]
    [NativeTypeName("struct ILayoutStorage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ILayoutStorage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILayoutStorage*, Guid*, void**, int>)(lpVtbl[0]))((ILayoutStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILayoutStorage*, uint>)(lpVtbl[1]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILayoutStorage*, uint>)(lpVtbl[2]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT LayoutScript(StorageLayout* pStorageLayout, [NativeTypeName("DWORD")] uint nEntries, [NativeTypeName("DWORD")] uint glfInterleavedFlag)
        {
            return ((delegate* unmanaged<ILayoutStorage*, StorageLayout*, uint, uint, int>)(lpVtbl[3]))((ILayoutStorage*)Unsafe.AsPointer(ref this), pStorageLayout, nEntries, glfInterleavedFlag);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT BeginMonitor()
        {
            return ((delegate* unmanaged<ILayoutStorage*, int>)(lpVtbl[4]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EndMonitor()
        {
            return ((delegate* unmanaged<ILayoutStorage*, int>)(lpVtbl[5]))((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ReLayoutDocfile([NativeTypeName("OLECHAR *")] ushort* pwcsNewDfName)
        {
            return ((delegate* unmanaged<ILayoutStorage*, ushort*, int>)(lpVtbl[6]))((ILayoutStorage*)Unsafe.AsPointer(ref this), pwcsNewDfName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ReLayoutDocfileOnILockBytes(ILockBytes* pILockBytes)
        {
            return ((delegate* unmanaged<ILayoutStorage*, ILockBytes*, int>)(lpVtbl[7]))((ILayoutStorage*)Unsafe.AsPointer(ref this), pILockBytes);
        }
    }
}
