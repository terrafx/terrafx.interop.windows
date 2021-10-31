// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B99F381F-A8F9-47A2-A5AF-CA3A225A3890")]
    [NativeTypeName("struct IMFVideoMediaType : IMFMediaType")]
    [NativeInheritance("IMFMediaType")]
    public unsafe partial struct IMFVideoMediaType
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, uint>)(lpVtbl[1]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, uint>)(lpVtbl[2]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, uint*, int>)(lpVtbl[7]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, double*, int>)(lpVtbl[9]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, uint*, int>)(lpVtbl[11]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, uint*, int>)(lpVtbl[14]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, int>)(lpVtbl[19]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, int>)(lpVtbl[20]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, uint, int>)(lpVtbl[21]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, ulong, int>)(lpVtbl[22]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, double, int>)(lpVtbl[23]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT LockStore()
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, int>)(lpVtbl[28]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT UnlockStore()
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, int>)(lpVtbl[29]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, uint*, int>)(lpVtbl[30]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CopyAllItems(IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, IMFAttributes*, int>)(lpVtbl[32]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetMajorType(Guid* pguidMajorType)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid*, int>)(lpVtbl[33]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pguidMajorType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT IsCompressedFormat(BOOL* pfCompressed)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, BOOL*, int>)(lpVtbl[34]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pfCompressed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT IsEqual(IMFMediaType* pIMediaType, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, IMFMediaType*, uint*, int>)(lpVtbl[35]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), pIMediaType, pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT GetRepresentation(Guid guidRepresentation, [NativeTypeName("LPVOID *")] void** ppvRepresentation)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid, void**, int>)(lpVtbl[36]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, ppvRepresentation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT FreeRepresentation(Guid guidRepresentation, [NativeTypeName("LPVOID")] void* pvRepresentation)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid, void*, int>)(lpVtbl[37]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, pvRepresentation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("const MFVIDEOFORMAT *")]
        public MFVIDEOFORMAT* GetVideoFormat()
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, MFVIDEOFORMAT*>)(lpVtbl[38]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT GetVideoRepresentation(Guid guidRepresentation, [NativeTypeName("LPVOID *")] void** ppvRepresentation, [NativeTypeName("LONG")] int lStride)
        {
            return ((delegate* unmanaged<IMFVideoMediaType*, Guid, void**, int, int>)(lpVtbl[39]))((IMFVideoMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, ppvRepresentation, lStride);
        }
    }
}
