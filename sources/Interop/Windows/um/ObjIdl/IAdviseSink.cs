// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010F-0000-0000-C000-000000000046")]
    public unsafe partial struct IAdviseSink
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IAdviseSink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IAdviseSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IAdviseSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnDataChange(IAdviseSink* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnViewChange(IAdviseSink* pThis, [NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnRename(IAdviseSink* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnSave(IAdviseSink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnClose(IAdviseSink* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            Marshal.GetDelegateForFunctionPointer<_OnDataChange>(lpVtbl->OnDataChange)((IAdviseSink*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            Marshal.GetDelegateForFunctionPointer<_OnViewChange>(lpVtbl->OnViewChange)((IAdviseSink*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            Marshal.GetDelegateForFunctionPointer<_OnRename>(lpVtbl->OnRename)((IAdviseSink*)Unsafe.AsPointer(ref this), pmk);
        }

        public void OnSave()
        {
            Marshal.GetDelegateForFunctionPointer<_OnSave>(lpVtbl->OnSave)((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public void OnClose()
        {
            Marshal.GetDelegateForFunctionPointer<_OnClose>(lpVtbl->OnClose)((IAdviseSink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
            public IntPtr OnDataChange;

            [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
            public IntPtr OnViewChange;

            [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
            public IntPtr OnRename;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr OnSave;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr OnClose;
        }
    }
}
