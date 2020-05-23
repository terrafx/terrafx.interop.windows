// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9BFBBC02-EFF1-101A-84ED-00AA00341D07")]
    public unsafe partial struct IPropertyNotifySink
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPropertyNotifySink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPropertyNotifySink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPropertyNotifySink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnChanged(IPropertyNotifySink* pThis, [NativeTypeName("DISPID")] int dispID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnRequestEdit(IPropertyNotifySink* pThis, [NativeTypeName("DISPID")] int dispID);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPropertyNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPropertyNotifySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnChanged([NativeTypeName("DISPID")] int dispID)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnChanged>(lpVtbl->OnChanged)((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
        }

        [return: NativeTypeName("HRESULT")]
        public int OnRequestEdit([NativeTypeName("DISPID")] int dispID)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnRequestEdit>(lpVtbl->OnRequestEdit)((IPropertyNotifySink*)Unsafe.AsPointer(ref this), dispID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
            public IntPtr OnChanged;

            [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
            public IntPtr OnRequestEdit;
        }
    }
}
