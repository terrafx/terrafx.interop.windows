// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A2F05A09-27A2-42B5-BC0E-AC163EF49D9B")]
    public unsafe partial struct IApartmentShutdown
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IApartmentShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IApartmentShutdown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IApartmentShutdown*)Unsafe.AsPointer(ref this));
        }

        public void OnUninitialize([NativeTypeName("UINT64")] ulong ui64ApartmentIdentifier)
        {
            lpVtbl->OnUninitialize((IApartmentShutdown*)Unsafe.AsPointer(ref this), ui64ApartmentIdentifier);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IApartmentShutdown*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IApartmentShutdown*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IApartmentShutdown*, uint> Release;

            [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<IApartmentShutdown*, ulong, void> OnUninitialize;
        }
    }
}
