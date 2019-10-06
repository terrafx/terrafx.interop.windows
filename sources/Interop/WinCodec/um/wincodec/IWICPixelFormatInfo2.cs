// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4")]
    public unsafe partial struct IWICPixelFormatInfo2
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICPixelFormatInfo2* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICPixelFormatInfo2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICPixelFormatInfo2* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetComponentType(IWICPixelFormatInfo2* This, WICComponentType* pType);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCLSID(IWICPixelFormatInfo2* This, [NativeTypeName("CLSID")] Guid* pclsid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSigningStatus(IWICPixelFormatInfo2* This, [NativeTypeName("DWORD")] uint* pStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAuthor(IWICPixelFormatInfo2* This, [NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] ushort* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVendorGUID(IWICPixelFormatInfo2* This, [NativeTypeName("GUID")] Guid* pguidVendor);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetVersion(IWICPixelFormatInfo2* This, [NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSpecVersion(IWICPixelFormatInfo2* This, [NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFriendlyName(IWICPixelFormatInfo2* This, [NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] ushort* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFormatGUID(IWICPixelFormatInfo2* This, [NativeTypeName("GUID")] Guid* pFormat);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorContext(IWICPixelFormatInfo2* This, IWICColorContext** ppIColorContext = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBitsPerPixel(IWICPixelFormatInfo2* This, [NativeTypeName("UINT")] uint* puiBitsPerPixel);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetChannelCount(IWICPixelFormatInfo2* This, [NativeTypeName("UINT")] uint* puiChannelCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetChannelMask(IWICPixelFormatInfo2* This, [NativeTypeName("UINT")] uint uiChannelIndex, [NativeTypeName("UINT")] uint cbMaskBuffer, [Optional, NativeTypeName("BYTE[]")] byte* pbMaskBuffer, [NativeTypeName("UINT")] uint* pcbActual);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SupportsTransparency(IWICPixelFormatInfo2* This, [NativeTypeName("BOOL")] int* pfSupportsTransparency);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetNumericRepresentation(IWICPixelFormatInfo2* This, WICPixelFormatNumericRepresentation* pNumericRepresentation);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetComponentType>(lpVtbl->GetComponentType)(This, pType);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID")] Guid* pclsid)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCLSID>(lpVtbl->GetCLSID)(This, pclsid);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD")] uint* pStatus)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSigningStatus>(lpVtbl->GetSigningStatus)(This, pStatus);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [Optional, NativeTypeName("WCHAR[]")] ushort* wzAuthor, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetAuthor>(lpVtbl->GetAuthor)(This, cchAuthor, wzAuthor, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID")] Guid* pguidVendor)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVendorGUID>(lpVtbl->GetVendorGUID)(This, pguidVendor);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetVersion>(lpVtbl->GetVersion)(This, cchVersion, wzVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [Optional, NativeTypeName("WCHAR[]")] ushort* wzSpecVersion, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSpecVersion>(lpVtbl->GetSpecVersion)(This, cchSpecVersion, wzSpecVersion, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [Optional, NativeTypeName("WCHAR[]")] ushort* wzFriendlyName, [NativeTypeName("UINT")] uint* pcchActual)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFriendlyName>(lpVtbl->GetFriendlyName)(This, cchFriendlyName, wzFriendlyName, pcchActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormatGUID([NativeTypeName("GUID")] Guid* pFormat)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFormatGUID>(lpVtbl->GetFormatGUID)(This, pFormat);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContext(IWICColorContext** ppIColorContext = null)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorContext>(lpVtbl->GetColorContext)(This, ppIColorContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBitsPerPixel([NativeTypeName("UINT")] uint* puiBitsPerPixel)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBitsPerPixel>(lpVtbl->GetBitsPerPixel)(This, puiBitsPerPixel);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT")] uint* puiChannelCount)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetChannelCount>(lpVtbl->GetChannelCount)(This, puiChannelCount);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelMask([NativeTypeName("UINT")] uint uiChannelIndex, [NativeTypeName("UINT")] uint cbMaskBuffer, [Optional, NativeTypeName("BYTE[]")] byte* pbMaskBuffer, [NativeTypeName("UINT")] uint* pcbActual)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetChannelMask>(lpVtbl->GetChannelMask)(This, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SupportsTransparency([NativeTypeName("BOOL")] int* pfSupportsTransparency)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SupportsTransparency>(lpVtbl->SupportsTransparency)(This, pfSupportsTransparency);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumericRepresentation(WICPixelFormatNumericRepresentation* pNumericRepresentation)
        {
            fixed (IWICPixelFormatInfo2* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumericRepresentation>(lpVtbl->GetNumericRepresentation)(This, pNumericRepresentation);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetComponentType;

            public IntPtr GetCLSID;

            public IntPtr GetSigningStatus;

            public IntPtr GetAuthor;

            public IntPtr GetVendorGUID;

            public IntPtr GetVersion;

            public IntPtr GetSpecVersion;

            public IntPtr GetFriendlyName;

            public IntPtr GetFormatGUID;

            public IntPtr GetColorContext;

            public IntPtr GetBitsPerPixel;

            public IntPtr GetChannelCount;

            public IntPtr GetChannelMask;

            public IntPtr SupportsTransparency;

            public IntPtr GetNumericRepresentation;
        }
    }
}
