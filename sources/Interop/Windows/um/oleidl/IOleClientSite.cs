// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000118-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleClientSite
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleClientSite* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleClientSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleClientSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveObject(IOleClientSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMoniker(IOleClientSite* pThis, [NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainer(IOleClientSite* pThis, [NativeTypeName("IOleContainer **")] IOleContainer** ppContainer);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ShowObject(IOleClientSite* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OnShowWindow(IOleClientSite* pThis, [NativeTypeName("BOOL")] int fShow);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RequestNewObjectLayout(IOleClientSite* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleClientSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveObject()
        {
            return Marshal.GetDelegateForFunctionPointer<_SaveObject>(lpVtbl->SaveObject)((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMoniker>(lpVtbl->GetMoniker)((IOleClientSite*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainer([NativeTypeName("IOleContainer **")] IOleContainer** ppContainer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainer>(lpVtbl->GetContainer)((IOleClientSite*)Unsafe.AsPointer(ref this), ppContainer);
        }

        [return: NativeTypeName("HRESULT")]
        public int ShowObject()
        {
            return Marshal.GetDelegateForFunctionPointer<_ShowObject>(lpVtbl->ShowObject)((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnShowWindow([NativeTypeName("BOOL")] int fShow)
        {
            return Marshal.GetDelegateForFunctionPointer<_OnShowWindow>(lpVtbl->OnShowWindow)((IOleClientSite*)Unsafe.AsPointer(ref this), fShow);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestNewObjectLayout()
        {
            return Marshal.GetDelegateForFunctionPointer<_RequestNewObjectLayout>(lpVtbl->RequestNewObjectLayout)((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr SaveObject;

            [NativeTypeName("HRESULT (DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
            public IntPtr GetMoniker;

            [NativeTypeName("HRESULT (IOleContainer **) __attribute__((stdcall))")]
            public IntPtr GetContainer;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr ShowObject;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public IntPtr OnShowWindow;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr RequestNewObjectLayout;
        }
    }
}
