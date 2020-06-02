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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocation([NativeTypeName("UINT")] uint cchMaxLength, [NativeTypeName("WCHAR *")] ushort* wzNamespace, [NativeTypeName("UINT *")] uint* pcchActualLength)
        {
            return lpVtbl->GetLocation((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetMetadataByName((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumString **")] IEnumString** ppIEnumString)
        {
            return lpVtbl->GetEnumerator((IWICMetadataQueryReader*)Unsafe.AsPointer(ref this), ppIEnumString);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryReader*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryReader*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryReader*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryReader*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryReader*, uint, ushort*, uint*, int> GetLocation;

            [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryReader*, ushort*, PROPVARIANT*, int> GetMetadataByName;

            [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryReader*, IEnumString**, int> GetEnumerator;
        }
    }
}
