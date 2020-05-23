// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E6D4D92-6738-11CF-9608-00AA00680DB4")]
    public unsafe partial struct IDirectWriterLock
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDirectWriterLock* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDirectWriterLock* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDirectWriterLock* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitForWriteAccess(IDirectWriterLock* pThis, [NativeTypeName("DWORD")] uint dwTimeout);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseWriteAccess(IDirectWriterLock* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HaveWriteAccess(IDirectWriterLock* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDirectWriterLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForWriteAccess([NativeTypeName("DWORD")] uint dwTimeout)
        {
            return Marshal.GetDelegateForFunctionPointer<_WaitForWriteAccess>(lpVtbl->WaitForWriteAccess)((IDirectWriterLock*)Unsafe.AsPointer(ref this), dwTimeout);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseWriteAccess()
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseWriteAccess>(lpVtbl->ReleaseWriteAccess)((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int HaveWriteAccess()
        {
            return Marshal.GetDelegateForFunctionPointer<_HaveWriteAccess>(lpVtbl->HaveWriteAccess)((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr WaitForWriteAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr ReleaseWriteAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr HaveWriteAccess;
        }
    }
}
