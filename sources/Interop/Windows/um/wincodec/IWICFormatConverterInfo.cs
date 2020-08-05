// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9F34FB65-13F4-4F15-BC57-3726B5E53D9F")]
    [NativeTypeName("struct IWICFormatConverterInfo : IWICComponentInfo")]
    public unsafe partial struct IWICFormatConverterInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint>)(lpVtbl[1]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint>)(lpVtbl[2]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[4]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint*, int>)(lpVtbl[5]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, Guid*, int>)(lpVtbl[7]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPixelFormats([NativeTypeName("UINT")] uint cFormats, [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormatGUIDs, [NativeTypeName("UINT *")] uint* pcActual)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, uint, Guid*, uint*, int>)(lpVtbl[11]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), cFormats, pPixelFormatGUIDs, pcActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("IWICFormatConverter **")] IWICFormatConverter** ppIConverter)
        {
            return ((delegate* stdcall<IWICFormatConverterInfo*, IWICFormatConverter**, int>)(lpVtbl[12]))((IWICFormatConverterInfo*)Unsafe.AsPointer(ref this), ppIConverter);
        }
    }
}
