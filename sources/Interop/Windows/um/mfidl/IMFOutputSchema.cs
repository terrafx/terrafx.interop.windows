// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BE0FC5B-ABD9-44FB-A5C8-F50136E71599")]
    [NativeTypeName("struct IMFOutputSchema : IMFAttributes")]
    public unsafe partial struct IMFOutputSchema
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, void**, int>)(lpVtbl[0]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFOutputSchema*, uint>)(lpVtbl[1]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFOutputSchema*, uint>)(lpVtbl[2]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, uint*, int>)(lpVtbl[7]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, double*, int>)(lpVtbl[9]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, uint*, int>)(lpVtbl[11]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, uint*, int>)(lpVtbl[14]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, int>)(lpVtbl[19]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFOutputSchema*, int>)(lpVtbl[20]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, uint, int>)(lpVtbl[21]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, ulong, int>)(lpVtbl[22]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, double, int>)(lpVtbl[23]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* unmanaged<IMFOutputSchema*, int>)(lpVtbl[28]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* unmanaged<IMFOutputSchema*, int>)(lpVtbl[29]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, uint*, int>)(lpVtbl[30]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems(IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, IMFAttributes*, int>)(lpVtbl[32]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSchemaType([NativeTypeName("GUID *")] Guid* pguidSchemaType)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, int>)(lpVtbl[33]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pguidSchemaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetConfigurationData([NativeTypeName("DWORD *")] uint* pdwVal)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, uint*, int>)(lpVtbl[34]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pdwVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOriginatorID([NativeTypeName("GUID *")] Guid* pguidOriginatorID)
        {
            return ((delegate* unmanaged<IMFOutputSchema*, Guid*, int>)(lpVtbl[35]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pguidOriginatorID);
        }
    }
}
