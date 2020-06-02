// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
    public unsafe partial struct IWICMetadataQueryWriter
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return lpVtbl->GetContainerFormat((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocation([NativeTypeName("UINT")] uint cchMaxLength, [NativeTypeName("WCHAR *")] ushort* wzNamespace, [NativeTypeName("UINT *")] uint* pcchActualLength)
        {
            return lpVtbl->GetLocation((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->GetMetadataByName((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumString **")] IEnumString** ppIEnumString)
        {
            return lpVtbl->GetEnumerator((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), ppIEnumString);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return lpVtbl->SetMetadataByName((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName)
        {
            return lpVtbl->RemoveMetadataByName((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, Guid*, int> GetContainerFormat;

            [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, uint, ushort*, uint*, int> GetLocation;

            [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, ushort*, PROPVARIANT*, int> GetMetadataByName;

            [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, IEnumString**, int> GetEnumerator;

            [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, ushort*, PROPVARIANT*, int> SetMetadataByName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IWICMetadataQueryWriter*, ushort*, int> RemoveMetadataByName;
        }
    }
}
