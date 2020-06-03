// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E8EDA601-3D48-431A-AB44-69059BE88BBE")]
    public unsafe partial struct IWICPixelFormatInfo
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint>)(lpVtbl[1]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint>)(lpVtbl[2]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComponentType([NativeTypeName("WICComponentType *")] WICComponentType* pType)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[4]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[5]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[7]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFormatGUID([NativeTypeName("GUID *")] Guid* pFormat)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, Guid*, int>)(lpVtbl[11]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), pFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorContext([NativeTypeName("IWICColorContext **")] IWICColorContext** ppIColorContext)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, IWICColorContext**, int>)(lpVtbl[12]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), ppIColorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBitsPerPixel([NativeTypeName("UINT *")] uint* puiBitsPerPixel)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[13]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* puiChannelCount)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint*, int>)(lpVtbl[14]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), puiChannelCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetChannelMask([NativeTypeName("UINT")] uint uiChannelIndex, [NativeTypeName("UINT")] uint cbMaskBuffer, [NativeTypeName("BYTE *")] byte* pbMaskBuffer, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return ((delegate* stdcall<IWICPixelFormatInfo*, uint, uint, byte*, uint*, int>)(lpVtbl[15]))((IWICPixelFormatInfo*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
        }
    }
}
