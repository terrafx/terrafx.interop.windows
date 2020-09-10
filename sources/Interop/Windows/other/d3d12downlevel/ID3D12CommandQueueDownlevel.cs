// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("38A8C5EF-7CCB-4E81-914F-A6E9D072C494")]
    [NativeTypeName("struct ID3D12CommandQueueDownlevel : IUnknown")]
    public unsafe partial struct ID3D12CommandQueueDownlevel
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12CommandQueueDownlevel*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12CommandQueueDownlevel*, uint>)(lpVtbl[1]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12CommandQueueDownlevel*, uint>)(lpVtbl[2]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Present([NativeTypeName("ID3D12GraphicsCommandList *")] ID3D12GraphicsCommandList* pOpenCommandList, [NativeTypeName("ID3D12Resource *")] ID3D12Resource* pSourceTex2D, [NativeTypeName("HWND")] IntPtr hWindow, D3D12_DOWNLEVEL_PRESENT_FLAGS Flags)
        {
            return ((delegate* stdcall<ID3D12CommandQueueDownlevel*, ID3D12GraphicsCommandList*, ID3D12Resource*, IntPtr, D3D12_DOWNLEVEL_PRESENT_FLAGS, int>)(lpVtbl[3]))((ID3D12CommandQueueDownlevel*)Unsafe.AsPointer(ref this), pOpenCommandList, pSourceTex2D, hWindow, Flags);
        }
    }
}
