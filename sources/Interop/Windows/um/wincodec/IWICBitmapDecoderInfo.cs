// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
    public unsafe partial struct IWICBitmapDecoderInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return lpVtbl->GetComponentType((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return lpVtbl->GetCLSID((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return lpVtbl->GetSigningStatus((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetAuthor((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return lpVtbl->GetVendorGUID((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetVersion((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetSpecVersion((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetFriendlyName((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats([NativeTypeName("UINT")] uint cFormats, [NativeTypeName("GUID *")] Guid* pguidPixelFormats, [NativeTypeName("UINT *")] uint* pcActual)
        {
            return lpVtbl->GetPixelFormats((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion([NativeTypeName("UINT")] uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetColorManagementVersion((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetDeviceManufacturer((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetDeviceModels((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes([NativeTypeName("UINT")] uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetMimeTypes((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions([NativeTypeName("UINT")] uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return lpVtbl->GetFileExtensions((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation)
        {
            return lpVtbl->DoesSupportAnimation((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey)
        {
            return lpVtbl->DoesSupportChromakey((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless)
        {
            return lpVtbl->DoesSupportLossless((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe)
        {
            return lpVtbl->DoesSupportMultiframe((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return lpVtbl->MatchesMimeType((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPatterns([NativeTypeName("UINT")] uint cbSizePatterns, [NativeTypeName("WICBitmapPattern *")] WICBitmapPattern* pPatterns, [NativeTypeName("UINT *")] uint* pcPatterns, [NativeTypeName("UINT *")] uint* pcbPatternsActual)
        {
            return lpVtbl->GetPatterns((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesPattern([NativeTypeName("IStream *")] IStream* pIStream, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return lpVtbl->MatchesPattern((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pIStream, pfMatches);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICBitmapDecoder **")] IWICBitmapDecoder** ppIBitmapDecoder)
        {
            return lpVtbl->CreateInstance((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapDecoder);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint> Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, WICComponentType*, int> GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, Guid*, int> GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint*, int> GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, Guid*, int> GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int> GetPixelFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetColorManagementVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetDeviceModels;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetMimeTypes;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, ushort*, uint*, int> GetFileExtensions;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, int*, int> DoesSupportAnimation;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, int*, int> DoesSupportChromakey;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, int*, int> DoesSupportLossless;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, int*, int> DoesSupportMultiframe;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, ushort*, int*, int> MatchesMimeType;

            [NativeTypeName("HRESULT (UINT, WICBitmapPattern *, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, uint, WICBitmapPattern*, uint*, uint*, int> GetPatterns;

            [NativeTypeName("HRESULT (IStream *, BOOL *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, IStream*, int*, int> MatchesPattern;

            [NativeTypeName("HRESULT (IWICBitmapDecoder **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICBitmapDecoderInfo*, IWICBitmapDecoder**, int> CreateInstance;
        }
    }
}
