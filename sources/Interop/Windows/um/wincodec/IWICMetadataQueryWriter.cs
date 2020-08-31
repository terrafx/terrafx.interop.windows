// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
    [NativeTypeName("struct IWICMetadataQueryWriter : IWICMetadataQueryReader")]
    public unsafe partial struct IWICMetadataQueryWriter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, uint>)(lpVtbl[1]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, uint>)(lpVtbl[2]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContainerFormat([NativeTypeName("GUID *")] Guid* pguidContainerFormat)
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocation([NativeTypeName("UINT")] uint cchMaxLength, [NativeTypeName("WCHAR *")] ushort* wzNamespace, [NativeTypeName("UINT *")] uint* pcchActualLength)
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, uint, ushort*, uint*, int>)(lpVtbl[4]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), cchMaxLength, wzNamespace, pcchActualLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, ushort*, PROPVARIANT*, int>)(lpVtbl[5]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumerator([NativeTypeName("IEnumString **")] IEnumString** ppIEnumString)
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, IEnumString**, int>)(lpVtbl[6]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), ppIEnumString);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, ushort*, PROPVARIANT*, int>)(lpVtbl[7]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName)
        {
            return ((delegate* stdcall<IWICMetadataQueryWriter*, ushort*, int>)(lpVtbl[8]))((IWICMetadataQueryWriter*)Unsafe.AsPointer(ref this), wzName);
        }
    }
}
