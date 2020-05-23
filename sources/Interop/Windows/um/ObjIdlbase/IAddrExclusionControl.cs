// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000148-0000-0000-C000-000000000046")]
    public unsafe partial struct IAddrExclusionControl
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IAddrExclusionControl* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IAddrExclusionControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IAddrExclusionControl* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentAddrExclusionList(IAddrExclusionControl* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppEnumerator);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UpdateAddrExclusionList(IAddrExclusionControl* pThis, [NativeTypeName("IUnknown *")] IUnknown* pEnumerator);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IAddrExclusionControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentAddrExclusionList([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppEnumerator)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurrentAddrExclusionList>(lpVtbl->GetCurrentAddrExclusionList)((IAddrExclusionControl*)Unsafe.AsPointer(ref this), riid, ppEnumerator);
        }

        [return: NativeTypeName("HRESULT")]
        public int UpdateAddrExclusionList([NativeTypeName("IUnknown *")] IUnknown* pEnumerator)
        {
            return Marshal.GetDelegateForFunctionPointer<_UpdateAddrExclusionList>(lpVtbl->UpdateAddrExclusionList)((IAddrExclusionControl*)Unsafe.AsPointer(ref this), pEnumerator);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetCurrentAddrExclusionList;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public IntPtr UpdateAddrExclusionList;
        }
    }
}
