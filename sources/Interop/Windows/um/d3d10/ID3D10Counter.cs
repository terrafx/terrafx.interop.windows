// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B7E4C11-342C-4106-A19F-4F2704F689F0")]
    [NativeTypeName("struct ID3D10Counter : ID3D10Asynchronous")]
    [NativeInheritance("ID3D10Asynchronous")]
    public unsafe partial struct ID3D10Counter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10Counter*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10Counter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10Counter*, uint>)(lpVtbl[1]))((ID3D10Counter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10Counter*, uint>)(lpVtbl[2]))((ID3D10Counter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetDevice(ID3D10Device** ppDevice)
        {
            ((delegate* unmanaged<ID3D10Counter*, ID3D10Device**, void>)(lpVtbl[3]))((ID3D10Counter*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D10Counter*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D10Counter*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D10Counter*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D10Counter*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* unmanaged<ID3D10Counter*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D10Counter*)Unsafe.AsPointer(ref this), guid, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void Begin()
        {
            ((delegate* unmanaged<ID3D10Counter*, void>)(lpVtbl[7]))((ID3D10Counter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void End()
        {
            ((delegate* unmanaged<ID3D10Counter*, void>)(lpVtbl[8]))((ID3D10Counter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetData(void* pData, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("UINT")] uint GetDataFlags)
        {
            return ((delegate* unmanaged<ID3D10Counter*, void*, uint, uint, int>)(lpVtbl[9]))((ID3D10Counter*)Unsafe.AsPointer(ref this), pData, DataSize, GetDataFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("UINT")]
        public uint GetDataSize()
        {
            return ((delegate* unmanaged<ID3D10Counter*, uint>)(lpVtbl[10]))((ID3D10Counter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void GetDesc(D3D10_COUNTER_DESC* pDesc)
        {
            ((delegate* unmanaged<ID3D10Counter*, D3D10_COUNTER_DESC*, void>)(lpVtbl[11]))((ID3D10Counter*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
