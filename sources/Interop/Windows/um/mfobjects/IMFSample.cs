// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C40A00F2-B93A-4D80-AE8C-5A1C634F58E4")]
    [NativeTypeName("struct IMFSample : IMFAttributes")]
    [NativeInheritance("IMFAttributes")]
    public unsafe partial struct IMFSample
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, void**, int>)(lpVtbl[0]))((IMFSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSample*, uint>)(lpVtbl[1]))((IMFSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSample*, uint>)(lpVtbl[2]))((IMFSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
        {
            return ((delegate* unmanaged<IMFSample*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFSample*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, uint*, int>)(lpVtbl[7]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, double*, int>)(lpVtbl[9]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, uint*, int>)(lpVtbl[11]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, uint*, int>)(lpVtbl[14]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, int>)(lpVtbl[19]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFSample*, int>)(lpVtbl[20]))((IMFSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, uint, int>)(lpVtbl[21]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, ulong, int>)(lpVtbl[22]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, double, int>)(lpVtbl[23]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFSample*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFSample*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT LockStore()
        {
            return ((delegate* unmanaged<IMFSample*, int>)(lpVtbl[28]))((IMFSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT UnlockStore()
        {
            return ((delegate* unmanaged<IMFSample*, int>)(lpVtbl[29]))((IMFSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFSample*, uint*, int>)(lpVtbl[30]))((IMFSample*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFSample*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFSample*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT CopyAllItems(IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFSample*, IMFAttributes*, int>)(lpVtbl[32]))((IMFSample*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT GetSampleFlags([NativeTypeName("DWORD *")] uint* pdwSampleFlags)
        {
            return ((delegate* unmanaged<IMFSample*, uint*, int>)(lpVtbl[33]))((IMFSample*)Unsafe.AsPointer(ref this), pdwSampleFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT SetSampleFlags([NativeTypeName("DWORD")] uint dwSampleFlags)
        {
            return ((delegate* unmanaged<IMFSample*, uint, int>)(lpVtbl[34]))((IMFSample*)Unsafe.AsPointer(ref this), dwSampleFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetSampleTime([NativeTypeName("LONGLONG *")] long* phnsSampleTime)
        {
            return ((delegate* unmanaged<IMFSample*, long*, int>)(lpVtbl[35]))((IMFSample*)Unsafe.AsPointer(ref this), phnsSampleTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT SetSampleTime([NativeTypeName("LONGLONG")] long hnsSampleTime)
        {
            return ((delegate* unmanaged<IMFSample*, long, int>)(lpVtbl[36]))((IMFSample*)Unsafe.AsPointer(ref this), hnsSampleTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT GetSampleDuration([NativeTypeName("LONGLONG *")] long* phnsSampleDuration)
        {
            return ((delegate* unmanaged<IMFSample*, long*, int>)(lpVtbl[37]))((IMFSample*)Unsafe.AsPointer(ref this), phnsSampleDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT SetSampleDuration([NativeTypeName("LONGLONG")] long hnsSampleDuration)
        {
            return ((delegate* unmanaged<IMFSample*, long, int>)(lpVtbl[38]))((IMFSample*)Unsafe.AsPointer(ref this), hnsSampleDuration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT GetBufferCount([NativeTypeName("DWORD *")] uint* pdwBufferCount)
        {
            return ((delegate* unmanaged<IMFSample*, uint*, int>)(lpVtbl[39]))((IMFSample*)Unsafe.AsPointer(ref this), pdwBufferCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT GetBufferByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFMediaBuffer** ppBuffer)
        {
            return ((delegate* unmanaged<IMFSample*, uint, IMFMediaBuffer**, int>)(lpVtbl[40]))((IMFSample*)Unsafe.AsPointer(ref this), dwIndex, ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT ConvertToContiguousBuffer(IMFMediaBuffer** ppBuffer)
        {
            return ((delegate* unmanaged<IMFSample*, IMFMediaBuffer**, int>)(lpVtbl[41]))((IMFSample*)Unsafe.AsPointer(ref this), ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT AddBuffer(IMFMediaBuffer* pBuffer)
        {
            return ((delegate* unmanaged<IMFSample*, IMFMediaBuffer*, int>)(lpVtbl[42]))((IMFSample*)Unsafe.AsPointer(ref this), pBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT RemoveBufferByIndex([NativeTypeName("DWORD")] uint dwIndex)
        {
            return ((delegate* unmanaged<IMFSample*, uint, int>)(lpVtbl[43]))((IMFSample*)Unsafe.AsPointer(ref this), dwIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT RemoveAllBuffers()
        {
            return ((delegate* unmanaged<IMFSample*, int>)(lpVtbl[44]))((IMFSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT GetTotalLength([NativeTypeName("DWORD *")] uint* pcbTotalLength)
        {
            return ((delegate* unmanaged<IMFSample*, uint*, int>)(lpVtbl[45]))((IMFSample*)Unsafe.AsPointer(ref this), pcbTotalLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT CopyToBuffer(IMFMediaBuffer* pBuffer)
        {
            return ((delegate* unmanaged<IMFSample*, IMFMediaBuffer*, int>)(lpVtbl[46]))((IMFSample*)Unsafe.AsPointer(ref this), pBuffer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, PROPVARIANT*, int> GetItem;

            [NativeTypeName("HRESULT (const GUID &, MF_ATTRIBUTE_TYPE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, MF_ATTRIBUTE_TYPE*, int> GetItemType;

            [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;

            [NativeTypeName("HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> Compare;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, uint*, int> GetUINT32;

            [NativeTypeName("HRESULT (const GUID &, UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, ulong*, int> GetUINT64;

            [NativeTypeName("HRESULT (const GUID &, double *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, double*, int> GetDouble;

            [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, Guid*, int> GetGUID;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, uint*, int> GetStringLength;

            [NativeTypeName("HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, ushort*, uint, uint*, int> GetString;

            [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, ushort**, uint*, int> GetAllocatedString;

            [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, uint*, int> GetBlobSize;

            [NativeTypeName("HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, byte*, uint, uint*, int> GetBlob;

            [NativeTypeName("HRESULT (const GUID &, UINT8 **, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, byte**, uint*, int> GetAllocatedBlob;

            [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, Guid*, void**, int> GetUnknown;

            [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, PROPVARIANT*, int> SetItem;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, int> DeleteItem;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, int> DeleteAllItems;

            [NativeTypeName("HRESULT (const GUID &, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, uint, int> SetUINT32;

            [NativeTypeName("HRESULT (const GUID &, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, ulong, int> SetUINT64;

            [NativeTypeName("HRESULT (const GUID &, double) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, double, int> SetDouble;

            [NativeTypeName("HRESULT (const GUID &, const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, Guid*, int> SetGUID;

            [NativeTypeName("HRESULT (const GUID &, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, ushort*, int> SetString;

            [NativeTypeName("HRESULT (const GUID &, const UINT8 *, UINT32) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, byte*, uint, int> SetBlob;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, Guid*, IUnknown*, int> SetUnknown;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, int> LockStore;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, int> UnlockStore;

            [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;

            [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, IMFAttributes*, int> CopyAllItems;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint*, int> GetSampleFlags;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint, int> SetSampleFlags;

            [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, long*, int> GetSampleTime;

            [NativeTypeName("HRESULT (LONGLONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, long, int> SetSampleTime;

            [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, long*, int> GetSampleDuration;

            [NativeTypeName("HRESULT (LONGLONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, long, int> SetSampleDuration;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint*, int> GetBufferCount;

            [NativeTypeName("HRESULT (DWORD, IMFMediaBuffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint, IMFMediaBuffer**, int> GetBufferByIndex;

            [NativeTypeName("HRESULT (IMFMediaBuffer **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, IMFMediaBuffer**, int> ConvertToContiguousBuffer;

            [NativeTypeName("HRESULT (IMFMediaBuffer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, IMFMediaBuffer*, int> AddBuffer;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint, int> RemoveBufferByIndex;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, int> RemoveAllBuffers;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, uint*, int> GetTotalLength;

            [NativeTypeName("HRESULT (IMFMediaBuffer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSample*, IMFMediaBuffer*, int> CopyToBuffer;
        }
    }
}
