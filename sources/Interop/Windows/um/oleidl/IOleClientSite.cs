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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleClientSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveObject()
        {
            return lpVtbl->SaveObject((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return lpVtbl->GetMoniker((IOleClientSite*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainer([NativeTypeName("IOleContainer **")] IOleContainer** ppContainer)
        {
            return lpVtbl->GetContainer((IOleClientSite*)Unsafe.AsPointer(ref this), ppContainer);
        }

        [return: NativeTypeName("HRESULT")]
        public int ShowObject()
        {
            return lpVtbl->ShowObject((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnShowWindow([NativeTypeName("BOOL")] int fShow)
        {
            return lpVtbl->OnShowWindow((IOleClientSite*)Unsafe.AsPointer(ref this), fShow);
        }

        [return: NativeTypeName("HRESULT")]
        public int RequestNewObjectLayout()
        {
            return lpVtbl->RequestNewObjectLayout((IOleClientSite*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, int> SaveObject;

            [NativeTypeName("HRESULT (DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, uint, uint, IMoniker**, int> GetMoniker;

            [NativeTypeName("HRESULT (IOleContainer **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, IOleContainer**, int> GetContainer;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, int> ShowObject;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, int, int> OnShowWindow;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleClientSite*, int> RequestNewObjectLayout;
        }
    }
}
