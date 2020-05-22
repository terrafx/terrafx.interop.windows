// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000032-0000-0000-C000-000000000046")]
    public unsafe partial struct ISynchronizeEvent
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ISynchronizeEvent* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ISynchronizeEvent* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ISynchronizeEvent* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHandle(ISynchronizeEvent* pThis, [NativeTypeName("HANDLE *")] void** ph);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetEventHandle(ISynchronizeEvent* pThis, [NativeTypeName("HANDLE *")] void** ph);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ISynchronizeEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ISynchronizeEvent*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ISynchronizeEvent*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHandle([NativeTypeName("HANDLE *")] void** ph)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHandle>(lpVtbl->GetHandle)((ISynchronizeEvent*)Unsafe.AsPointer(ref this), ph);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetEventHandle([NativeTypeName("HANDLE *")] void** ph)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetEventHandle>(lpVtbl->SetEventHandle)((ISynchronizeEvent*)Unsafe.AsPointer(ref this), ph);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
            public IntPtr GetHandle;

            [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
            public IntPtr SetEventHandle;
        }
    }
}
