// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("30989668-E1C9-4597-B395-458EEDB808DF")]
    public unsafe partial struct IWICMetadataQueryReader
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICMetadataQueryReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICMetadataQueryReader*, uint>)(lpVtbl[1]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICMetadataQueryReader*, uint>)(lpVtbl[2]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* stdcall<IWICMetadataQueryReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocation([NativeTypeName("UINT")] uint cchMaxLength, [NativeTypeName("WCHAR *")] ushort* wzNamespace, [NativeTypeName("UINT *")] uint* pcchActualLength)
        {
            return ((delegate* stdcall<IWICMetadataQueryReader*, uint, ushort*, uint*, int>)(lpVtbl[4]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* stdcall<IWICMetadataQueryReader*, ushort*, PROPVARIANT*, int>)(lpVtbl[5]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumString **")] IEnumString** ppIEnumString)
        {
            return ((delegate* stdcall<IWICMetadataQueryReader*, IEnumString**, int>)(lpVtbl[6]))((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), ppIEnumString);
        }
    }
}
