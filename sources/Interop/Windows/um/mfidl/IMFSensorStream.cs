// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E9A42171-C56E-498A-8B39-EDA5A070B7FC")]
    [NativeTypeName("struct IMFSensorStream : IMFAttributes")]
    public unsafe partial struct IMFSensorStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, void**, int>)(lpVtbl[0]))((IMFSensorStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFSensorStream*, uint>)(lpVtbl[1]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFSensorStream*, uint>)(lpVtbl[2]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFSensorStream*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, uint*, int>)(lpVtbl[7]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, double*, int>)(lpVtbl[9]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, uint*, int>)(lpVtbl[11]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, uint*, int>)(lpVtbl[14]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, int>)(lpVtbl[19]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* stdcall<IMFSensorStream*, int>)(lpVtbl[20]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, uint, int>)(lpVtbl[21]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, ulong, int>)(lpVtbl[22]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, double, int>)(lpVtbl[23]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IMFSensorStream*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFSensorStream*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* stdcall<IMFSensorStream*, int>)(lpVtbl[28]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* stdcall<IMFSensorStream*, int>)(lpVtbl[29]))((IMFSensorStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* stdcall<IMFSensorStream*, uint*, int>)(lpVtbl[30]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFSensorStream*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFSensorStream*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* stdcall<IMFSensorStream*, IMFAttributes*, int>)(lpVtbl[32]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* stdcall<IMFSensorStream*, uint*, int>)(lpVtbl[33]))((IMFSensorStream*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaType([NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppMediaType)
        {
            return ((delegate* stdcall<IMFSensorStream*, uint, IMFMediaType**, int>)(lpVtbl[34]))((IMFSensorStream*)Unsafe.AsPointer(ref this), dwIndex, ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloneSensorStream([NativeTypeName("IMFSensorStream **")] IMFSensorStream** ppStream)
        {
            return ((delegate* stdcall<IMFSensorStream*, IMFSensorStream**, int>)(lpVtbl[35]))((IMFSensorStream*)Unsafe.AsPointer(ref this), ppStream);
        }
    }
}
