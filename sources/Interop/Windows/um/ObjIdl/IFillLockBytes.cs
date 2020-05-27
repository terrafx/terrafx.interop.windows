// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("99CAF010-415E-11CF-8814-00AA00B569F5")]
    public unsafe partial struct IFillLockBytes
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IFillLockBytes* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IFillLockBytes* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IFillLockBytes* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillAppend(IFillLockBytes* pThis, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FillAt(IFillLockBytes* pThis, ULARGE_INTEGER ulOffset, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFillSize(IFillLockBytes* pThis, ULARGE_INTEGER ulSize);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Terminate(IFillLockBytes* pThis, [NativeTypeName("BOOL")] int bCanceled);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IFillLockBytes*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IFillLockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IFillLockBytes*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int FillAppend([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return Marshal.GetDelegateForFunctionPointer<_FillAppend>(lpVtbl->FillAppend)((IFillLockBytes*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int FillAt(ULARGE_INTEGER ulOffset, [NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
        {
            return Marshal.GetDelegateForFunctionPointer<_FillAt>(lpVtbl->FillAt)((IFillLockBytes*)Unsafe.AsPointer(ref this), ulOffset, pv, cb, pcbWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFillSize(ULARGE_INTEGER ulSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetFillSize>(lpVtbl->SetFillSize)((IFillLockBytes*)Unsafe.AsPointer(ref this), ulSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int Terminate([NativeTypeName("BOOL")] int bCanceled)
        {
            return Marshal.GetDelegateForFunctionPointer<_Terminate>(lpVtbl->Terminate)((IFillLockBytes*)Unsafe.AsPointer(ref this), bCanceled);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr FillAppend;

            [NativeTypeName("HRESULT (ULARGE_INTEGER, const void *, ULONG, ULONG *) __attribute__((stdcall))")]
            public IntPtr FillAt;

            [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
            public IntPtr SetFillSize;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr Terminate;
        }
    }
}
