// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("334B1F50-2292-4B35-99A1-25588D8C17FE")]
    [NativeTypeName("struct IDxcContainerBuilder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDxcContainerBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcContainerBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcContainerBuilder*, uint>)(lpVtbl[1]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcContainerBuilder*, uint>)(lpVtbl[2]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IDxcBlob* pDxilContainerHeader)
        {
            return ((delegate* unmanaged<IDxcContainerBuilder*, IDxcBlob*, int>)(lpVtbl[3]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), pDxilContainerHeader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int AddPart([NativeTypeName("UINT32")] uint fourCC, IDxcBlob* pSource)
        {
            return ((delegate* unmanaged<IDxcContainerBuilder*, uint, IDxcBlob*, int>)(lpVtbl[4]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC, pSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int RemovePart([NativeTypeName("UINT32")] uint fourCC)
        {
            return ((delegate* unmanaged<IDxcContainerBuilder*, uint, int>)(lpVtbl[5]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), fourCC);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SerializeContainer(IDxcOperationResult** ppResult)
        {
            return ((delegate* unmanaged<IDxcContainerBuilder*, IDxcOperationResult**, int>)(lpVtbl[6]))((IDxcContainerBuilder*)Unsafe.AsPointer(ref this), ppResult);
        }
    }
}
