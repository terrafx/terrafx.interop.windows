// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94C9B4EE-A09F-4F92-8A1E-4A9BCE7E76FB")]
    public unsafe partial struct IWICBitmapEncoderInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICBitmapEncoderInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICBitmapEncoderInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICBitmapEncoderInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(IWICBitmapEncoderInfo* pThis, [NativeTypeName("WICComponentType *")] WICComponentType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(IWICBitmapEncoderInfo* pThis, [NativeTypeName("CLSID *")] Guid* pclsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(IWICBitmapEncoderInfo* pThis, [NativeTypeName("DWORD *")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(IWICBitmapEncoderInfo* pThis, [NativeTypeName("GUID *")] Guid* pguidVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormat(IWICBitmapEncoderInfo* pThis, [NativeTypeName("GUID *")] Guid* pguidContainerFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPixelFormats(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cFormats, [NativeTypeName("GUID *")] Guid* pguidPixelFormats, [NativeTypeName("UINT *")] uint* pcActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorManagementVersion(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMimeTypes(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFileExtensions(IWICBitmapEncoderInfo* pThis, [NativeTypeName("UINT")] uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportAnimation(IWICBitmapEncoderInfo* pThis, [NativeTypeName("BOOL *")] int* pfSupportAnimation);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportChromakey(IWICBitmapEncoderInfo* pThis, [NativeTypeName("BOOL *")] int* pfSupportChromakey);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportLossless(IWICBitmapEncoderInfo* pThis, [NativeTypeName("BOOL *")] int* pfSupportLossless);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportMultiframe(IWICBitmapEncoderInfo* pThis, [NativeTypeName("BOOL *")] int* pfSupportMultiframe);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MatchesMimeType(IWICBitmapEncoderInfo* pThis, [NativeTypeName("LPCWSTR")] ushort* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(IWICBitmapEncoderInfo* pThis, [NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIBitmapEncoder);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainerFormat>(lpVtbl->GetContainerFormat)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats([NativeTypeName("UINT")] uint cFormats, [NativeTypeName("GUID *")] Guid* pguidPixelFormats, [NativeTypeName("UINT *")] uint* pcActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPixelFormats>(lpVtbl->GetPixelFormats)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorManagementVersion([NativeTypeName("UINT")] uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorManagementVersion>(lpVtbl->GetColorManagementVersion)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceManufacturer>(lpVtbl->GetDeviceManufacturer)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceModels>(lpVtbl->GetDeviceModels)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMimeTypes([NativeTypeName("UINT")] uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMimeTypes>(lpVtbl->GetMimeTypes)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFileExtensions([NativeTypeName("UINT")] uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFileExtensions>(lpVtbl->GetFileExtensions)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportAnimation([NativeTypeName("BOOL *")] int* pfSupportAnimation)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesSupportAnimation>(lpVtbl->DoesSupportAnimation)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportChromakey([NativeTypeName("BOOL *")] int* pfSupportChromakey)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesSupportChromakey>(lpVtbl->DoesSupportChromakey)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportLossless([NativeTypeName("BOOL *")] int* pfSupportLossless)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesSupportLossless>(lpVtbl->DoesSupportLossless)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportMultiframe([NativeTypeName("BOOL *")] int* pfSupportMultiframe)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesSupportMultiframe>(lpVtbl->DoesSupportMultiframe)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [return: NativeTypeName("HRESULT")]
        public int MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, [NativeTypeName("BOOL *")] int* pfMatches)
        {
            return Marshal.GetDelegateForFunctionPointer<_MatchesMimeType>(lpVtbl->MatchesMimeType)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICBitmapEncoder **")] IWICBitmapEncoder** ppIBitmapEncoder)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)((IWICBitmapEncoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapEncoder);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
            public IntPtr GetComponentType;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public IntPtr GetCLSID;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetSigningStatus;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetAuthor;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetVendorGUID;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetSpecVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetFriendlyName;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetPixelFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetColorManagementVersion;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetDeviceModels;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetMimeTypes;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetFileExtensions;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesSupportAnimation;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesSupportChromakey;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesSupportLossless;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesSupportMultiframe;

            [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
            public IntPtr MatchesMimeType;

            [NativeTypeName("HRESULT (IWICBitmapEncoder **) __attribute__((stdcall))")]
            public IntPtr CreateInstance;
        }
    }
}
