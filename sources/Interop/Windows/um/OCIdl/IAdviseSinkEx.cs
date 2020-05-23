// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3AF24290-0C96-11CE-A0CF-00AA00600AB8")]
    public unsafe partial struct IAdviseSinkEx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IAdviseSinkEx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IAdviseSinkEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IAdviseSinkEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnDataChange(IAdviseSinkEx* pThis, [NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnViewChange(IAdviseSinkEx* pThis, [NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnRename(IAdviseSinkEx* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnSave(IAdviseSinkEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnClose(IAdviseSinkEx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void _OnViewStatusChange(IAdviseSinkEx* pThis, [NativeTypeName("DWORD")] uint dwViewStatus);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IAdviseSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        public void OnDataChange([NativeTypeName("FORMATETC *")] FORMATETC* pFormatetc, [NativeTypeName("STGMEDIUM *")] STGMEDIUM* pStgmed)
        {
            Marshal.GetDelegateForFunctionPointer<_OnDataChange>(lpVtbl->OnDataChange)((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
        }

        public void OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
        {
            Marshal.GetDelegateForFunctionPointer<_OnViewChange>(lpVtbl->OnViewChange)((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwAspect, lindex);
        }

        public void OnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            Marshal.GetDelegateForFunctionPointer<_OnRename>(lpVtbl->OnRename)((IAdviseSinkEx*)Unsafe.AsPointer(ref this), pmk);
        }

        public void OnSave()
        {
            Marshal.GetDelegateForFunctionPointer<_OnSave>(lpVtbl->OnSave)((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        public void OnClose()
        {
            Marshal.GetDelegateForFunctionPointer<_OnClose>(lpVtbl->OnClose)((IAdviseSinkEx*)Unsafe.AsPointer(ref this));
        }

        public void OnViewStatusChange([NativeTypeName("DWORD")] uint dwViewStatus)
        {
            Marshal.GetDelegateForFunctionPointer<_OnViewStatusChange>(lpVtbl->OnViewStatusChange)((IAdviseSinkEx*)Unsafe.AsPointer(ref this), dwViewStatus);
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

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public IntPtr OnViewStatusChange;
        }
    }
}
