// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E667AF9F-CD56-4F46-83CE-032E595D70A8")]
    public unsafe partial struct ID3D12LifetimeOwner
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this));
        }

        public void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState)
        {
            lpVtbl->LifetimeStateUpdated((ID3D12LifetimeOwner*)Unsafe.AsPointer(ref this), NewState);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LifetimeOwner*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LifetimeOwner*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LifetimeOwner*, uint> Release;

            [NativeTypeName("void (D3D12_LIFETIME_STATE) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12LifetimeOwner*, D3D12_LIFETIME_STATE, void> LifetimeStateUpdated;
        }
    }
}
