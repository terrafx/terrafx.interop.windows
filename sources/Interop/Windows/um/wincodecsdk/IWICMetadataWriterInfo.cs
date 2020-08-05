// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B22E3FBA-3925-4323-B5C1-9EBFC430F236")]
    [NativeTypeName("struct IWICMetadataWriterInfo : IWICMetadataHandlerInfo")]
    public unsafe partial struct IWICMetadataWriterInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint>)(lpVtbl[1]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint>)(lpVtbl[2]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, Guid*, int>)(lpVtbl[4]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint*, int>)(lpVtbl[5]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, Guid*, int>)(lpVtbl[7]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, Guid*, int>)(lpVtbl[11]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats([NativeTypeName("UINT")] uint cContainerFormats, [NativeTypeName("GUID *")] Guid* pguidContainerFormats, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, int*, int>)(lpVtbl[15]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, int*, int>)(lpVtbl[16]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, int*, int>)(lpVtbl[17]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("UINT")] uint cbSize, [NativeTypeName("WICMetadataHeader *")] WICMetadataHeader* pHeader, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, Guid*, uint, WICMetadataHeader*, uint*, int>)(lpVtbl[18]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter)
        {
            return ((delegate* stdcall<IWICMetadataWriterInfo*, IWICMetadataWriter**, int>)(lpVtbl[19]))((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), ppIWriter);
        }
    }
}
