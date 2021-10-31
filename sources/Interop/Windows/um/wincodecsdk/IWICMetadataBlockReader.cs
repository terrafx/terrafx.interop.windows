// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEAA2A8D-B3F3-43E4-B25C-D1DE990A1AE1")]
    [NativeTypeName("struct IWICMetadataBlockReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWICMetadataBlockReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICMetadataBlockReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICMetadataBlockReader*, uint>)(lpVtbl[1]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICMetadataBlockReader*, uint>)(lpVtbl[2]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged<IWICMetadataBlockReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCount([NativeTypeName("UINT *")] uint* pcCount)
        {
            return ((delegate* unmanaged<IWICMetadataBlockReader*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetReaderByIndex([NativeTypeName("UINT")] uint nIndex, IWICMetadataReader** ppIMetadataReader)
        {
            return ((delegate* unmanaged<IWICMetadataBlockReader*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetEnumerator(IEnumUnknown** ppIEnumMetadata)
        {
            return ((delegate* unmanaged<IWICMetadataBlockReader*, IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }
    }
}
