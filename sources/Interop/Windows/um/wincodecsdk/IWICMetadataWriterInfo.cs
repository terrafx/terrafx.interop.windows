// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B22E3FBA-3925-4323-B5C1-9EBFC430F236")]
    public unsafe partial struct IWICMetadataWriterInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return lpVtbl->GetMetadataFormat((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats([NativeTypeName("UINT")] uint cContainerFormats, [NativeTypeName("GUID *")] Guid* pguidContainerFormats, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetContainerFormats((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream)
        {
            return lpVtbl->DoesRequireFullStream((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding)
        {
            return lpVtbl->DoesSupportPadding((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize)
        {
            return lpVtbl->DoesRequireFixedSize((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("UINT")] uint cbSize, [NativeTypeName("WICMetadataHeader *")] WICMetadataHeader* pHeader, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return lpVtbl->GetHeader((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter)
        {
            return lpVtbl->CreateInstance((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), ppIWriter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint, Guid*, uint*, int> GetContainerFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, uint, ushort*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, int*, int> DoesRequireFullStream;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, int*, int> DoesSupportPadding;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, int*, int> DoesRequireFixedSize;

            [NativeTypeName("HRESULT (const GUID &, UINT, WICMetadataHeader *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, Guid*, uint, WICMetadataHeader*, uint*, int> GetHeader;

            [NativeTypeName("HRESULT (IWICMetadataWriter **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataWriterInfo*, IWICMetadataWriter**, int> CreateInstance;
        }
    }
}
