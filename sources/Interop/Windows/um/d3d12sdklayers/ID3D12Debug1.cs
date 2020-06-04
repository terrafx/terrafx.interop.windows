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
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12Debug1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Debug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12Debug1*, uint>)(lpVtbl[1]))((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12Debug1*, uint>)(lpVtbl[2]))((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        public void EnableDebugLayer()
        {
            ((delegate* stdcall<ID3D12Debug1*, void>)(lpVtbl[3]))((ID3D12Debug1*)Unsafe.AsPointer(ref this));
        }

        public void SetEnableGPUBasedValidation([NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* stdcall<ID3D12Debug1*, int, void>)(lpVtbl[4]))((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
        }

        public void SetEnableSynchronizedCommandQueueValidation([NativeTypeName("BOOL")] int Enable)
        {
            ((delegate* stdcall<ID3D12Debug1*, int, void>)(lpVtbl[5]))((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
        }
    }
}
