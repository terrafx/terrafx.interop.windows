// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("b04f5b50-2059-4f12-a8ff-a1e0cde1cc7e")]
    public unsafe partial struct IDxcVersionInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDxcVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDxcVersionInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT32 *")] uint* pMajor, [NativeTypeName("UINT32 *")] uint* pMinor)
        {
            return lpVtbl->GetVersion((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pMajor, pMinor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
        {
            return lpVtbl->GetFlags((IDxcVersionInfo*)Unsafe.AsPointer(ref this), pFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcVersionInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcVersionInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDxcVersionInfo*, uint> Release;

            [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcVersionInfo*, uint*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDxcVersionInfo*, uint*, int> GetFlags;
        }
    }
}
