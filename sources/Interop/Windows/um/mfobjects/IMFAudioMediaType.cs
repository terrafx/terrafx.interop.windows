// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26A0ADC3-CE26-4672-9304-69552EDD3FAF")]
    public unsafe partial struct IMFAudioMediaType
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, void**, int>)(lpVtbl[0]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFAudioMediaType*, uint>)(lpVtbl[1]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFAudioMediaType*, uint>)(lpVtbl[2]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, uint*, int>)(lpVtbl[7]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, double*, int>)(lpVtbl[9]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, uint*, int>)(lpVtbl[11]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, uint*, int>)(lpVtbl[14]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, int>)(lpVtbl[19]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* stdcall<IMFAudioMediaType*, int>)(lpVtbl[20]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, uint, int>)(lpVtbl[21]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, ulong, int>)(lpVtbl[22]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, double, int>)(lpVtbl[23]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* stdcall<IMFAudioMediaType*, int>)(lpVtbl[28]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* stdcall<IMFAudioMediaType*, int>)(lpVtbl[29]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, uint*, int>)(lpVtbl[30]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pcItems);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, IMFAttributes*, int>)(lpVtbl[32]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMajorType([NativeTypeName("GUID *")] Guid* pguidMajorType)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid*, int>)(lpVtbl[33]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pguidMajorType);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsCompressedFormat([NativeTypeName("BOOL *")] int* pfCompressed)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, int*, int>)(lpVtbl[34]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pfCompressed);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEqual([NativeTypeName("IMFMediaType *")] IMFMediaType* pIMediaType, [NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, IMFMediaType*, uint*, int>)(lpVtbl[35]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), pIMediaType, pdwFlags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID *")] void** ppvRepresentation)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid, void**, int>)(lpVtbl[36]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, ppvRepresentation);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeRepresentation([NativeTypeName("GUID")] Guid guidRepresentation, [NativeTypeName("LPVOID")] void* pvRepresentation)
        {
            return ((delegate* stdcall<IMFAudioMediaType*, Guid, void*, int>)(lpVtbl[37]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this), guidRepresentation, pvRepresentation);
        }

        [return: NativeTypeName("const WAVEFORMATEX *")]
        public WAVEFORMATEX* GetAudioFormat()
        {
            return ((delegate* stdcall<IMFAudioMediaType*, WAVEFORMATEX*>)(lpVtbl[38]))((IMFAudioMediaType*)Unsafe.AsPointer(ref this));
        }
    }
}
