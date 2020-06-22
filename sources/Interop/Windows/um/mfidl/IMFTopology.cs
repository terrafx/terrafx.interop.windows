// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83CF873A-F6DA-4BC8-823F-BACFD55DC433")]
    public unsafe partial struct IMFTopology
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopology*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFTopology*, uint>)(lpVtbl[1]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFTopology*, uint>)(lpVtbl[2]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* stdcall<IMFTopology*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFTopology*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, uint*, int>)(lpVtbl[7]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, double*, int>)(lpVtbl[9]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, uint*, int>)(lpVtbl[11]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, uint*, int>)(lpVtbl[14]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, int>)(lpVtbl[19]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey);
        }

        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* stdcall<IMFTopology*, int>)(lpVtbl[20]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, uint, int>)(lpVtbl[21]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, ulong, int>)(lpVtbl[22]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, double, int>)(lpVtbl[23]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* stdcall<IMFTopology*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFTopology*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* stdcall<IMFTopology*, int>)(lpVtbl[28]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* stdcall<IMFTopology*, int>)(lpVtbl[29]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* stdcall<IMFTopology*, uint*, int>)(lpVtbl[30]))((IMFTopology*)Unsafe.AsPointer(ref this), pcItems);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* stdcall<IMFTopology*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFTopology*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* stdcall<IMFTopology*, IMFAttributes*, int>)(lpVtbl[32]))((IMFTopology*)Unsafe.AsPointer(ref this), pDest);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTopologyID([NativeTypeName("TOPOID *")] ulong* pID)
        {
            return ((delegate* stdcall<IMFTopology*, ulong*, int>)(lpVtbl[33]))((IMFTopology*)Unsafe.AsPointer(ref this), pID);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddNode([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode)
        {
            return ((delegate* stdcall<IMFTopology*, IMFTopologyNode*, int>)(lpVtbl[34]))((IMFTopology*)Unsafe.AsPointer(ref this), pNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveNode([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode)
        {
            return ((delegate* stdcall<IMFTopology*, IMFTopologyNode*, int>)(lpVtbl[35]))((IMFTopology*)Unsafe.AsPointer(ref this), pNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNodeCount([NativeTypeName("WORD *")] ushort* pwNodes)
        {
            return ((delegate* stdcall<IMFTopology*, ushort*, int>)(lpVtbl[36]))((IMFTopology*)Unsafe.AsPointer(ref this), pwNodes);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNode([NativeTypeName("WORD")] ushort wIndex, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppNode)
        {
            return ((delegate* stdcall<IMFTopology*, ushort, IMFTopologyNode**, int>)(lpVtbl[37]))((IMFTopology*)Unsafe.AsPointer(ref this), wIndex, ppNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int Clear()
        {
            return ((delegate* stdcall<IMFTopology*, int>)(lpVtbl[38]))((IMFTopology*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CloneFrom([NativeTypeName("IMFTopology *")] IMFTopology* pTopology)
        {
            return ((delegate* stdcall<IMFTopology*, IMFTopology*, int>)(lpVtbl[39]))((IMFTopology*)Unsafe.AsPointer(ref this), pTopology);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetNodeByID([NativeTypeName("TOPOID")] ulong qwTopoNodeID, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppNode)
        {
            return ((delegate* stdcall<IMFTopology*, ulong, IMFTopologyNode**, int>)(lpVtbl[40]))((IMFTopology*)Unsafe.AsPointer(ref this), qwTopoNodeID, ppNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSourceNodeCollection([NativeTypeName("IMFCollection **")] IMFCollection** ppCollection)
        {
            return ((delegate* stdcall<IMFTopology*, IMFCollection**, int>)(lpVtbl[41]))((IMFTopology*)Unsafe.AsPointer(ref this), ppCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOutputNodeCollection([NativeTypeName("IMFCollection **")] IMFCollection** ppCollection)
        {
            return ((delegate* stdcall<IMFTopology*, IMFCollection**, int>)(lpVtbl[42]))((IMFTopology*)Unsafe.AsPointer(ref this), ppCollection);
        }
    }
}
