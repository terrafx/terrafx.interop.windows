// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83CF873A-F6DA-4BC8-823F-BACFD55DC430")]
    [NativeTypeName("struct IMFTopologyNode : IMFAttributes")]
    public unsafe partial struct IMFTopologyNode
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, void**, int>)(lpVtbl[0]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint>)(lpVtbl[1]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint>)(lpVtbl[2]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("MF_ATTRIBUTE_TYPE *")] MF_ATTRIBUTE_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, PROPVARIANT*, int*, int>)(lpVtbl[5]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compare([NativeTypeName("IMFAttributes *")] IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, [NativeTypeName("BOOL *")] int* pbResult)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, int*, int>)(lpVtbl[6]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint*, int>)(lpVtbl[7]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, punValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("double *")] double* pfValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, double*, int>)(lpVtbl[9]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pfValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("GUID *")] Guid* pguidValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint*, int>)(lpVtbl[11]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint*, int>)(lpVtbl[14]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, int>)(lpVtbl[19]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAllItems()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, int>)(lpVtbl[20]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, uint, int>)(lpVtbl[21]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ulong, int>)(lpVtbl[22]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, unValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, double, int>)(lpVtbl[23]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, fValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, guidValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, wszValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockStore()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, int>)(lpVtbl[28]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnlockStore()
        {
            return ((delegate* unmanaged<IMFTopologyNode*, int>)(lpVtbl[29]))((IMFTopologyNode*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint*, int>)(lpVtbl[30]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pcItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, [NativeTypeName("GUID *")] Guid* pguidKey, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* pValue)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAllItems([NativeTypeName("IMFAttributes *")] IMFAttributes* pDest)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IMFAttributes*, int>)(lpVtbl[32]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetObject([NativeTypeName("IUnknown *")] IUnknown* pObject)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IUnknown*, int>)(lpVtbl[33]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObject([NativeTypeName("IUnknown **")] IUnknown** ppObject)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IUnknown**, int>)(lpVtbl[34]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), ppObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetNodeType([NativeTypeName("MF_TOPOLOGY_TYPE *")] MF_TOPOLOGY_TYPE* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, MF_TOPOLOGY_TYPE*, int>)(lpVtbl[35]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTopoNodeID([NativeTypeName("TOPOID *")] ulong* pID)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, ulong*, int>)(lpVtbl[36]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTopoNodeID([NativeTypeName("TOPOID")] ulong ullTopoID)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, ulong, int>)(lpVtbl[37]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), ullTopoID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputCount([NativeTypeName("DWORD *")] uint* pcInputs)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint*, int>)(lpVtbl[38]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pcInputs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputCount([NativeTypeName("DWORD *")] uint* pcOutputs)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint*, int>)(lpVtbl[39]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pcOutputs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ConnectOutput([NativeTypeName("DWORD")] uint dwOutputIndex, [NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pDownstreamNode, [NativeTypeName("DWORD")] uint dwInputIndexOnDownstreamNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFTopologyNode*, uint, int>)(lpVtbl[40]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, pDownstreamNode, dwInputIndexOnDownstreamNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisconnectOutput([NativeTypeName("DWORD")] uint dwOutputIndex)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, int>)(lpVtbl[41]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInput([NativeTypeName("DWORD")] uint dwInputIndex, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppUpstreamNode, [NativeTypeName("DWORD *")] uint* pdwOutputIndexOnUpstreamNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFTopologyNode**, uint*, int>)(lpVtbl[42]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwInputIndex, ppUpstreamNode, pdwOutputIndexOnUpstreamNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutput([NativeTypeName("DWORD")] uint dwOutputIndex, [NativeTypeName("IMFTopologyNode **")] IMFTopologyNode** ppDownstreamNode, [NativeTypeName("DWORD *")] uint* pdwInputIndexOnDownstreamNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFTopologyNode**, uint*, int>)(lpVtbl[43]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, ppDownstreamNode, pdwInputIndexOnDownstreamNode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOutputPrefType([NativeTypeName("DWORD")] uint dwOutputIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType*, int>)(lpVtbl[44]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputPrefType([NativeTypeName("DWORD")] uint dwOutputIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType**, int>)(lpVtbl[45]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwOutputIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetInputPrefType([NativeTypeName("DWORD")] uint dwInputIndex, [NativeTypeName("IMFMediaType *")] IMFMediaType* pType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType*, int>)(lpVtbl[46]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwInputIndex, pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputPrefType([NativeTypeName("DWORD")] uint dwInputIndex, [NativeTypeName("IMFMediaType **")] IMFMediaType** ppType)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, uint, IMFMediaType**, int>)(lpVtbl[47]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), dwInputIndex, ppType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CloneFrom([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode)
        {
            return ((delegate* unmanaged<IMFTopologyNode*, IMFTopologyNode*, int>)(lpVtbl[48]))((IMFTopologyNode*)Unsafe.AsPointer(ref this), pNode);
        }
    }
}
