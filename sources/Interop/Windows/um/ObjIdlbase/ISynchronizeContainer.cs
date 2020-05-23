// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000033-0000-0000-C000-000000000046")]
    public unsafe partial struct ISynchronizeContainer
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ISynchronizeContainer* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ISynchronizeContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ISynchronizeContainer* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddSynchronize(ISynchronizeContainer* pThis, [NativeTypeName("ISynchronize *")] ISynchronize* pSync);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _WaitMultiple(ISynchronizeContainer* pThis, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeOut, [NativeTypeName("ISynchronize **")] ISynchronize** ppSync);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ISynchronizeContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSynchronize([NativeTypeName("ISynchronize *")] ISynchronize* pSync)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddSynchronize>(lpVtbl->AddSynchronize)((ISynchronizeContainer*)Unsafe.AsPointer(ref this), pSync);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitMultiple([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeOut, [NativeTypeName("ISynchronize **")] ISynchronize** ppSync)
        {
            return Marshal.GetDelegateForFunctionPointer<_WaitMultiple>(lpVtbl->WaitMultiple)((ISynchronizeContainer*)Unsafe.AsPointer(ref this), dwFlags, dwTimeOut, ppSync);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ISynchronize *) __attribute__((stdcall))")]
            public IntPtr AddSynchronize;

            [NativeTypeName("HRESULT (DWORD, DWORD, ISynchronize **) __attribute__((stdcall))")]
            public IntPtr WaitMultiple;
        }
    }
}
