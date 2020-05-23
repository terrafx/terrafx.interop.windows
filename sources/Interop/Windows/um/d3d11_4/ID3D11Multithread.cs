// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4E00-342C-4106-A19F-4F2704F689F0")]
    public unsafe partial struct ID3D11Multithread
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11Multithread* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Enter(ID3D11Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _Leave(ID3D11Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _SetMultithreadProtected(ID3D11Multithread* pThis, [NativeTypeName("BOOL")] int bMTProtect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetMultithreadProtected(ID3D11Multithread* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        public void Enter()
        {
            Marshal.GetDelegateForFunctionPointer<_Enter>(lpVtbl->Enter)((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        public void Leave()
        {
            Marshal.GetDelegateForFunctionPointer<_Leave>(lpVtbl->Leave)((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int SetMultithreadProtected([NativeTypeName("BOOL")] int bMTProtect)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMultithreadProtected>(lpVtbl->SetMultithreadProtected)((ID3D11Multithread*)Unsafe.AsPointer(ref this), bMTProtect);
        }

        [return: NativeTypeName("BOOL")]
        public int GetMultithreadProtected()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMultithreadProtected>(lpVtbl->GetMultithreadProtected)((ID3D11Multithread*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Enter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr Leave;

            [NativeTypeName("BOOL (BOOL) __attribute__((stdcall))")]
            public IntPtr SetMultithreadProtected;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr GetMultithreadProtected;
        }
    }
}
