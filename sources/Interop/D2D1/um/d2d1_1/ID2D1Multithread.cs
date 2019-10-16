// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("31E6E7BC-E0FF-4D46-8C64-A0A8C41C15D3")]
    public unsafe partial struct ID2D1Multithread
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Multithread* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetMultithreadProtected(ID2D1Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Enter(ID2D1Multithread* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _Leave(ID2D1Multithread* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1Multithread*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int GetMultithreadProtected()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMultithreadProtected>(lpVtbl->GetMultithreadProtected)((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        public void Enter()
        {
            Marshal.GetDelegateForFunctionPointer<_Enter>(lpVtbl->Enter)((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        public void Leave()
        {
            Marshal.GetDelegateForFunctionPointer<_Leave>(lpVtbl->Leave)((ID2D1Multithread*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("BOOL () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetMultithreadProtected;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Enter;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr Leave;
        }
    }
}
