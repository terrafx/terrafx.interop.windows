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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ILayoutStorage* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ILayoutStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ILayoutStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LayoutScript(ILayoutStorage* pThis, [NativeTypeName("StorageLayout *")] StorageLayout* pStorageLayout, [NativeTypeName("DWORD")] uint nEntries, [NativeTypeName("DWORD")] uint glfInterleavedFlag);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BeginMonitor(ILayoutStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EndMonitor(ILayoutStorage* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReLayoutDocfile(ILayoutStorage* pThis, [NativeTypeName("OLECHAR *")] ushort* pwcsNewDfName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReLayoutDocfileOnILockBytes(ILayoutStorage* pThis, [NativeTypeName("ILockBytes *")] ILockBytes* pILockBytes);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ILayoutStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int LayoutScript([NativeTypeName("StorageLayout *")] StorageLayout* pStorageLayout, [NativeTypeName("DWORD")] uint nEntries, [NativeTypeName("DWORD")] uint glfInterleavedFlag)
        {
            return Marshal.GetDelegateForFunctionPointer<_LayoutScript>(lpVtbl->LayoutScript)((ILayoutStorage*)Unsafe.AsPointer(ref this), pStorageLayout, nEntries, glfInterleavedFlag);
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginMonitor()
        {
            return Marshal.GetDelegateForFunctionPointer<_BeginMonitor>(lpVtbl->BeginMonitor)((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EndMonitor()
        {
            return Marshal.GetDelegateForFunctionPointer<_EndMonitor>(lpVtbl->EndMonitor)((ILayoutStorage*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReLayoutDocfile([NativeTypeName("OLECHAR *")] ushort* pwcsNewDfName)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReLayoutDocfile>(lpVtbl->ReLayoutDocfile)((ILayoutStorage*)Unsafe.AsPointer(ref this), pwcsNewDfName);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReLayoutDocfileOnILockBytes([NativeTypeName("ILockBytes *")] ILockBytes* pILockBytes)
        {
            return Marshal.GetDelegateForFunctionPointer<_ReLayoutDocfileOnILockBytes>(lpVtbl->ReLayoutDocfileOnILockBytes)((ILayoutStorage*)Unsafe.AsPointer(ref this), pILockBytes);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (StorageLayout *, DWORD, DWORD) __attribute__((stdcall))")]
            public IntPtr LayoutScript;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr BeginMonitor;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr EndMonitor;

            [NativeTypeName("HRESULT (OLECHAR *) __attribute__((stdcall))")]
            public IntPtr ReLayoutDocfile;

            [NativeTypeName("HRESULT (ILockBytes *) __attribute__((stdcall))")]
            public IntPtr ReLayoutDocfileOnILockBytes;
        }
    }
}
