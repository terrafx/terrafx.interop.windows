// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4")]
    [NativeTypeName("struct IWICPixelFormatInfo2 : IWICPixelFormatInfo")]
    public unsafe partial struct IWICPixelFormatInfo2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint>)(lpVtbl[1]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint>)(lpVtbl[2]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, WICComponentType*, int>)(lpVtbl[3]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[4]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[5]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[7]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormatGUID([NativeTypeName("GUID *")] Guid* pFormat)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[11]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContext([NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, IWICColorContext**, int>)(lpVtbl[12]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBitsPerPixel([NativeTypeName("UINT *")] uint* puiBitsPerPixel)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[13]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* puiChannelCount)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[14]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiChannelCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelMask([NativeTypeName("UINT")] uint uiChannelIndex, [NativeTypeName("UINT")] uint cbMaskBuffer, [NativeTypeName("BYTE *")] byte* pbMaskBuffer, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)(lpVtbl[15]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int SupportsTransparency([NativeTypeName("BOOL *")] int* pfSupportsTransparency)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, int*, int>)(lpVtbl[16]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pfSupportsTransparency);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNumericRepresentation([NativeTypeName("WICPixelFormatNumericRepresentation *")] WICPixelFormatNumericRepresentation* pNumericRepresentation)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo2*, WICPixelFormatNumericRepresentation*, int>)(lpVtbl[17]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pNumericRepresentation);
        }
    }
}
