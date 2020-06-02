// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C1D867D-C290-41C8-AE7E-34A98702E9A5")]
    public unsafe partial struct ID2D1PrintControl
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1PrintControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddPage([NativeTypeName("ID2D1CommandList *")] ID2D1CommandList* commandList, D2D_SIZE_F pageSize, [NativeTypeName("IStream *")] IStream* pagePrintTicketStream, [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return lpVtbl->AddPage((ID2D1PrintControl*)Unsafe.AsPointer(ref this), commandList, pageSize, pagePrintTicketStream, tag1, tag2);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return lpVtbl->Close((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1PrintControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1PrintControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1PrintControl*, uint> Release;

            [NativeTypeName("HRESULT (ID2D1CommandList *, D2D_SIZE_F, IStream *, D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1PrintControl*, ID2D1CommandList*, D2D_SIZE_F, IStream*, ulong*, ulong*, int> AddPage;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1PrintControl*, int> Close;
        }
    }
}
