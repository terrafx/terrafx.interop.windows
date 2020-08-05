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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, void**, int>)(lpVtbl[0]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFOutputSchema*, uint>)(lpVtbl[1]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFOutputSchema*, uint>)(lpVtbl[2]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFOutputSchema*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, uint*, int>)(lpVtbl[7]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, double*, int>)(lpVtbl[9]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, uint*, int>)(lpVtbl[11]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, uint*, int>)(lpVtbl[14]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, int>)(lpVtbl[19]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* stdcall<IMFOutputSchema*, int>)(lpVtbl[20]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, uint, int>)(lpVtbl[21]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, ulong, int>)(lpVtbl[22]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, double, int>)(lpVtbl[23]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* stdcall<IMFOutputSchema*, int>)(lpVtbl[28]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* stdcall<IMFOutputSchema*, int>)(lpVtbl[29]))((IMFOutputSchema*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* stdcall<IMFOutputSchema*, uint*, int>)(lpVtbl[30]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pcItems);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFOutputSchema*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* stdcall<IMFOutputSchema*, IMFAttributes*, int>)(lpVtbl[32]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSchemaType([NativeTypeName("GUID *")] Guid* pguidSchemaType)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, int>)(lpVtbl[33]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pguidSchemaType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConfigurationData([NativeTypeName("DWORD *")] uint* pdwVal)
        {
            return ((delegate* stdcall<IMFOutputSchema*, uint*, int>)(lpVtbl[34]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pdwVal);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOriginatorID([NativeTypeName("GUID *")] Guid* pguidOriginatorID)
        {
            return ((delegate* stdcall<IMFOutputSchema*, Guid*, int>)(lpVtbl[35]))((IMFOutputSchema*)Unsafe.AsPointer(ref this), pguidOriginatorID);
        }
    }
}
