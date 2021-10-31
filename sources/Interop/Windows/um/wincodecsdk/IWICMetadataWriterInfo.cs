// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B22E3FBA-3925-4323-B5C1-9EBFC430F236")]
    [NativeTypeName("struct IWICMetadataWriterInfo : IWICMetadataHandlerInfo")]
    [NativeInheritance("IWICMetadataHandlerInfo")]
    public unsafe partial struct IWICMetadataWriterInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint>)(lpVtbl[1]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint>)(lpVtbl[2]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetComponentType(WICComponentType* pType)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, int>)(lpVtbl[4]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint*, int>)(lpVtbl[5]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetVendorGUID(Guid* pguidVendor)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, int>)(lpVtbl[7]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, int>)(lpVtbl[11]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT DoesRequireFullStream(BOOL* pfRequiresFullStream)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, BOOL*, int>)(lpVtbl[15]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT DoesSupportPadding(BOOL* pfSupportsPadding)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, BOOL*, int>)(lpVtbl[16]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT DoesRequireFixedSize(BOOL* pfFixedSize)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, BOOL*, int>)(lpVtbl[17]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, uint cbSize, WICMetadataHeader* pHeader, uint* pcbActual)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, Guid*, uint, WICMetadataHeader*, uint*, int>)(lpVtbl[18]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CreateInstance(IWICMetadataWriter** ppIWriter)
        {
            return ((delegate* unmanaged<IWICMetadataWriterInfo*, IWICMetadataWriter**, int>)(lpVtbl[19]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), ppIWriter);
        }
    }
}
