// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E6D4D90-6738-11CF-9608-00AA00680DB4")]
    public unsafe partial struct ILayoutStorage
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ILayoutStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LayoutScript([NativeTypeName("StorageLayout *")] StorageLayout* pStorageLayout, [NativeTypeName("DWORD")] uint nEntries, [NativeTypeName("DWORD")] uint glfInterleavedFlag)
        {
            return lpVtbl->LayoutScript((ILayoutStorage*)Unsafe.AsPointer(ref this), pStorageLayout, nEntries, glfInterleavedFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginMonitor()
        {
            return lpVtbl->BeginMonitor((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EndMonitor()
        {
            return lpVtbl->EndMonitor((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReLayoutDocfile([NativeTypeName("OLECHAR *")] ushort* pwcsNewDfName)
        {
            return lpVtbl->ReLayoutDocfile((ILayoutStorage*)Unsafe.AsPointer(ref this), pwcsNewDfName);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReLayoutDocfileOnILockBytes([NativeTypeName("ILockBytes *")] ILockBytes* pILockBytes)
        {
            return lpVtbl->ReLayoutDocfileOnILockBytes((ILayoutStorage*)Unsafe.AsPointer(ref this), pILockBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, uint> Release;

            [NativeTypeName("HRESULT (StorageLayout *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, StorageLayout*, uint, uint, int> LayoutScript;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, int> BeginMonitor;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, int> EndMonitor;

            [NativeTypeName("HRESULT (OLECHAR *) __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, ushort*, int> ReLayoutDocfile;

            [NativeTypeName("HRESULT (ILockBytes *) __attribute__((stdcall))")]
            public delegate* stdcall<ILayoutStorage*, ILockBytes*, int> ReLayoutDocfileOnILockBytes;
        }
    }
}
