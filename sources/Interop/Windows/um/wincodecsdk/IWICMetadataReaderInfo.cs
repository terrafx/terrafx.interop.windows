// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EEBF1F5B-07C1-4447-A3AB-22ACAF78A804")]
    [NativeTypeName("struct IWICMetadataReaderInfo : IWICMetadataHandlerInfo")]
    public unsafe partial struct IWICMetadataReaderInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint>)(lpVtbl[1]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint>)(lpVtbl[2]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, Guid*, int>)(lpVtbl[4]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint*, int>)(lpVtbl[5]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, Guid*, int>)(lpVtbl[7]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, Guid*, int>)(lpVtbl[11]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats([NativeTypeName("UINT")] uint cContainerFormats, [NativeTypeName("GUID *")] Guid* pguidContainerFormats, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, int*, int>)(lpVtbl[15]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, int*, int>)(lpVtbl[16]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, int*, int>)(lpVtbl[17]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPatterns([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("UINT")] uint cbSize, WICMetadataPattern* pPattern, [NativeTypeName("UINT *")] uint* pcCount, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, Guid*, uint, WICMetadataPattern*, uint*, uint*, int>)(lpVtbl[18]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IStream* pIStream, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, Guid*, IStream*, int*, int>)(lpVtbl[19]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, pIStream, pfMatches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance(IWICMetadataReader** ppIReader)
        {
            return ((delegate* unmanaged<IWICMetadataReaderInfo*, IWICMetadataReader**, int>)(lpVtbl[20]))((IWICMetadataReaderInfo*)Unsafe.AsPointer(ref this), ppIReader);
        }
    }
}
