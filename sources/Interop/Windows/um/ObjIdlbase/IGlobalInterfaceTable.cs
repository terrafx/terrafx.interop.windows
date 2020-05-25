// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000146-0000-0000-C000-000000000046")]
    public unsafe partial struct IGlobalInterfaceTable
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IGlobalInterfaceTable* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IGlobalInterfaceTable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IGlobalInterfaceTable* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterInterfaceInGlobal(IGlobalInterfaceTable* pThis, [NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RevokeInterfaceFromGlobal(IGlobalInterfaceTable* pThis, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetInterfaceFromGlobal(IGlobalInterfaceTable* pThis, [NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterInterfaceInGlobal([NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterInterfaceInGlobal>(lpVtbl->RegisterInterfaceInGlobal)((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), pUnk, riid, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RevokeInterfaceFromGlobal>(lpVtbl->RevokeInterfaceFromGlobal)((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetInterfaceFromGlobal>(lpVtbl->GetInterfaceFromGlobal)((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie, riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, DWORD *) __attribute__((stdcall))")]
            public IntPtr RegisterInterfaceInGlobal;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr RevokeInterfaceFromGlobal;

            [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetInterfaceFromGlobal;
        }
    }
}
