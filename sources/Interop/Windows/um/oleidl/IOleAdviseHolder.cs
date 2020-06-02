// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000111-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleAdviseHolder
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return lpVtbl->Advise((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pAdvise, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return lpVtbl->Unadvise((IOleAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return lpVtbl->EnumAdvise((IOleAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnRename([NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return lpVtbl->SendOnRename((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnSave()
        {
            return lpVtbl->SendOnSave((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SendOnClose()
        {
            return lpVtbl->SendOnClose((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, uint> Release;

            [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, IAdviseSink*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, IEnumSTATDATA**, int> EnumAdvise;

            [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, IMoniker*, int> SendOnRename;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, int> SendOnSave;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleAdviseHolder*, int> SendOnClose;
        }
    }
}
