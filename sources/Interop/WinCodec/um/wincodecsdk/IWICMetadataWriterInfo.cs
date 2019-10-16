// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct IWICMetadataWriterInfo
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICMetadataWriterInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICMetadataWriterInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICMetadataWriterInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(IWICMetadataWriterInfo* pThis, [NativeTypeName("WICComponentType *")] WICComponentType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(IWICMetadataWriterInfo* pThis, [NativeTypeName("CLSID *")] Guid* pclsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(IWICMetadataWriterInfo* pThis, [NativeTypeName("DWORD *")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(IWICMetadataWriterInfo* pThis, [NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(IWICMetadataWriterInfo* pThis, [NativeTypeName("GUID *")] Guid* pguidVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IWICMetadataWriterInfo* pThis, [NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(IWICMetadataWriterInfo* pThis, [NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(IWICMetadataWriterInfo* pThis, [NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMetadataFormat(IWICMetadataWriterInfo* pThis, [NativeTypeName("GUID *")] Guid* pguidMetadataFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetContainerFormats(IWICMetadataWriterInfo* pThis, [NativeTypeName("UINT")] uint cContainerFormats, [NativeTypeName("GUID *")] Guid* pguidContainerFormats, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceManufacturer(IWICMetadataWriterInfo* pThis, [NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDeviceModels(IWICMetadataWriterInfo* pThis, [NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFullStream(IWICMetadataWriterInfo* pThis, [NativeTypeName("BOOL *")] int* pfRequiresFullStream);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesSupportPadding(IWICMetadataWriterInfo* pThis, [NativeTypeName("BOOL *")] int* pfSupportsPadding);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoesRequireFixedSize(IWICMetadataWriterInfo* pThis, [NativeTypeName("BOOL *")] int* pfFixedSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHeader(IWICMetadataWriterInfo* pThis, [NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("UINT")] uint cbSize, [NativeTypeName("WICMetadataHeader *")] WICMetadataHeader* pHeader, [NativeTypeName("UINT *")] uint* pcbActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateInstance(IWICMetadataWriterInfo* pThis, [NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataFormat([NativeTypeName("GUID *")] Guid* pguidMetadataFormat)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMetadataFormat>(lpVtbl->GetMetadataFormat)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormats([NativeTypeName("UINT")] uint cContainerFormats, [NativeTypeName("GUID *")] Guid* pguidContainerFormats, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetContainerFormats>(lpVtbl->GetContainerFormats)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cContainerFormats, pguidContainerFormats, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceManufacturer([NativeTypeName("UINT")] uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceManufacturer>(lpVtbl->GetDeviceManufacturer)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceModels([NativeTypeName("UINT")] uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDeviceModels>(lpVtbl->GetDeviceModels)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFullStream([NativeTypeName("BOOL *")] int* pfRequiresFullStream)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesRequireFullStream>(lpVtbl->DoesRequireFullStream)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfRequiresFullStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesSupportPadding([NativeTypeName("BOOL *")] int* pfSupportsPadding)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesSupportPadding>(lpVtbl->DoesSupportPadding)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfSupportsPadding);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoesRequireFixedSize([NativeTypeName("BOOL *")] int* pfFixedSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoesRequireFixedSize>(lpVtbl->DoesRequireFixedSize)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), pfFixedSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHeader([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("UINT")] uint cbSize, [NativeTypeName("WICMetadataHeader *")] WICMetadataHeader* pHeader, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHeader>(lpVtbl->GetHeader)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), guidContainerFormat, cbSize, pHeader, pcbActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICMetadataWriter **")] IWICMetadataWriter** ppIWriter)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateInstance>(lpVtbl->CreateInstance)((IWICMetadataWriterInfo*)Unsafe.AsPointer(ref this), ppIWriter);
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
            public IntPtr GetMetadataFormat;

            [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetContainerFormats;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetDeviceManufacturer;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetDeviceModels;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesRequireFullStream;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesSupportPadding;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr DoesRequireFixedSize;

            [NativeTypeName("HRESULT (const GUID &, UINT, WICMetadataHeader *, UINT *) __attribute__((stdcall))")]
            public IntPtr GetHeader;

            [NativeTypeName("HRESULT (IWICMetadataWriter **) __attribute__((stdcall))")]
            public IntPtr CreateInstance;
        }
    }
}
