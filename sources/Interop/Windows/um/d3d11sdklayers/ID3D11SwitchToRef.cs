// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1EF337E3-58E7-4F83-A692-DB221F5ED47E")]
    public unsafe partial struct ID3D11SwitchToRef
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D11SwitchToRef* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D11SwitchToRef* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D11SwitchToRef* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _SetUseRef(ID3D11SwitchToRef* pThis, [NativeTypeName("BOOL")] int UseRef);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetUseRef(ID3D11SwitchToRef* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int SetUseRef([NativeTypeName("BOOL")] int UseRef)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetUseRef>(lpVtbl->SetUseRef)((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this), UseRef);
        }

        [return: NativeTypeName("BOOL")]
        public int GetUseRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUseRef>(lpVtbl->GetUseRef)((ID3D11SwitchToRef*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("BOOL (BOOL) __attribute__((stdcall))")]
            public IntPtr SetUseRef;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr GetUseRef;
        }
    }
}
