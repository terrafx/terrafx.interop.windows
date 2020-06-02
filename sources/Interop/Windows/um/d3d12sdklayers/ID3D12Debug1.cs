// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFFAA4CA-63FE-4D8E-B8AD-159000AF4304")]
    public unsafe partial struct ID3D12Debug1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12Debug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        public void EnableDebugLayer()
        {
            lpVtbl->EnableDebugLayer((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] int Enable)
        {
            lpVtbl->SetEnableGPUBasedValidation((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
        }

        public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] int Enable)
        {
            lpVtbl->SetEnableSynchronizedCommandQueueValidation((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Debug1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Debug1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Debug1*, uint> Release;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Debug1*, void> EnableDebugLayer;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Debug1*, int, void> SetEnableGPUBasedValidation;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12Debug1*, int, void> SetEnableSynchronizedCommandQueueValidation;
        }
    }
}
