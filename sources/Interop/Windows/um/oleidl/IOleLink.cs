// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011D-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleLink
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleLink* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleLink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleLink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetUpdateOptions(IOleLink* pThis, [NativeTypeName("DWORD")] uint dwUpdateOpt);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUpdateOptions(IOleLink* pThis, [NativeTypeName("DWORD *")] uint* pdwUpdateOpt);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSourceMoniker(IOleLink* pThis, [NativeTypeName("IMoniker *")] IMoniker* pmk, [NativeTypeName("const IID &")] Guid* rclsid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceMoniker(IOleLink* pThis, [NativeTypeName("IMoniker **")] IMoniker** ppmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSourceDisplayName(IOleLink* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszStatusText);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSourceDisplayName(IOleLink* pThis, [NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindToSource(IOleLink* pThis, [NativeTypeName("DWORD")] uint bindflags, [NativeTypeName("IBindCtx *")] IBindCtx* pbc);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindIfRunning(IOleLink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBoundSource(IOleLink* pThis, [NativeTypeName("IUnknown **")] IUnknown** ppunk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnbindSource(IOleLink* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Update(IOleLink* pThis, [NativeTypeName("IBindCtx *")] IBindCtx* pbc);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUpdateOptions([NativeTypeName("DWORD")] uint dwUpdateOpt)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetUpdateOptions>(lpVtbl->SetUpdateOptions)((IOleLink*)Unsafe.AsPointer(ref this), dwUpdateOpt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUpdateOptions([NativeTypeName("DWORD *")] uint* pdwUpdateOpt)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUpdateOptions>(lpVtbl->GetUpdateOptions)((IOleLink*)Unsafe.AsPointer(ref this), pdwUpdateOpt);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceMoniker([NativeTypeName("IMoniker *")] IMoniker* pmk, [NativeTypeName("const IID &")] Guid* rclsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSourceMoniker>(lpVtbl->SetSourceMoniker)((IOleLink*)Unsafe.AsPointer(ref this), pmk, rclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceMoniker([NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSourceMoniker>(lpVtbl->GetSourceMoniker)((IOleLink*)Unsafe.AsPointer(ref this), ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceDisplayName([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSourceDisplayName>(lpVtbl->SetSourceDisplayName)((IOleLink*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceDisplayName([NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSourceDisplayName>(lpVtbl->GetSourceDisplayName)((IOleLink*)Unsafe.AsPointer(ref this), ppszDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToSource([NativeTypeName("DWORD")] uint bindflags, [NativeTypeName("IBindCtx *")] IBindCtx* pbc)
        {
            return Marshal.GetDelegateForFunctionPointer<_BindToSource>(lpVtbl->BindToSource)((IOleLink*)Unsafe.AsPointer(ref this), bindflags, pbc);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindIfRunning()
        {
            return Marshal.GetDelegateForFunctionPointer<_BindIfRunning>(lpVtbl->BindIfRunning)((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBoundSource([NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBoundSource>(lpVtbl->GetBoundSource)((IOleLink*)Unsafe.AsPointer(ref this), ppunk);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnbindSource()
        {
            return Marshal.GetDelegateForFunctionPointer<_UnbindSource>(lpVtbl->UnbindSource)((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("IBindCtx *")] IBindCtx* pbc)
        {
            return Marshal.GetDelegateForFunctionPointer<_Update>(lpVtbl->Update)((IOleLink*)Unsafe.AsPointer(ref this), pbc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr SetUpdateOptions;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetUpdateOptions;

            [NativeTypeName("HRESULT (IMoniker *, const IID &) __attribute__((stdcall))")]
            public IntPtr SetSourceMoniker;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public IntPtr GetSourceMoniker;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public IntPtr SetSourceDisplayName;

            [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
            public IntPtr GetSourceDisplayName;

            [NativeTypeName("HRESULT (DWORD, IBindCtx *) __attribute__((stdcall))")]
            public IntPtr BindToSource;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr BindIfRunning;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public IntPtr GetBoundSource;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr UnbindSource;

            [NativeTypeName("HRESULT (IBindCtx *) __attribute__((stdcall))")]
            public IntPtr Update;
        }
    }
}
