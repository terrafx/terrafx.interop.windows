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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUpdateOptions([NativeTypeName("DWORD")] uint dwUpdateOpt)
        {
            return lpVtbl->SetUpdateOptions((IOleLink*)Unsafe.AsPointer(ref this), dwUpdateOpt);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUpdateOptions([NativeTypeName("DWORD *")] uint* pdwUpdateOpt)
        {
            return lpVtbl->GetUpdateOptions((IOleLink*)Unsafe.AsPointer(ref this), pdwUpdateOpt);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceMoniker([NativeTypeName("IMoniker *")] IMoniker* pmk, [NativeTypeName("const IID &")] Guid* rclsid)
        {
            return lpVtbl->SetSourceMoniker((IOleLink*)Unsafe.AsPointer(ref this), pmk, rclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceMoniker([NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return lpVtbl->GetSourceMoniker((IOleLink*)Unsafe.AsPointer(ref this), ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSourceDisplayName([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
        {
            return lpVtbl->SetSourceDisplayName((IOleLink*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceDisplayName([NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return lpVtbl->GetSourceDisplayName((IOleLink*)Unsafe.AsPointer(ref this), ppszDisplayName);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindToSource([NativeTypeName("DWORD")] uint bindflags, [NativeTypeName("IBindCtx *")] IBindCtx* pbc)
        {
            return lpVtbl->BindToSource((IOleLink*)Unsafe.AsPointer(ref this), bindflags, pbc);
        }

        [return: NativeTypeName("HRESULT")]
        public int BindIfRunning()
        {
            return lpVtbl->BindIfRunning((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBoundSource([NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return lpVtbl->GetBoundSource((IOleLink*)Unsafe.AsPointer(ref this), ppunk);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnbindSource()
        {
            return lpVtbl->UnbindSource((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("IBindCtx *")] IBindCtx* pbc)
        {
            return lpVtbl->Update((IOleLink*)Unsafe.AsPointer(ref this), pbc);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, uint> Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, uint, int> SetUpdateOptions;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, uint*, int> GetUpdateOptions;

            [NativeTypeName("HRESULT (IMoniker *, const IID &) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, IMoniker*, Guid*, int> SetSourceMoniker;

            [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, IMoniker**, int> GetSourceMoniker;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, ushort*, int> SetSourceDisplayName;

            [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, ushort**, int> GetSourceDisplayName;

            [NativeTypeName("HRESULT (DWORD, IBindCtx *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, uint, IBindCtx*, int> BindToSource;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, int> BindIfRunning;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, IUnknown**, int> GetBoundSource;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, int> UnbindSource;

            [NativeTypeName("HRESULT (IBindCtx *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleLink*, IBindCtx*, int> Update;
        }
    }
}
