// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0742A90B-C387-483F-B946-30A7E4E61458")]
    public unsafe partial struct ID3D12InfoQueue
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, uint>)(lpVtbl[1]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, uint>)(lpVtbl[2]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong, int>)(lpVtbl[3]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), MessageCountLimit);
        }

        public void ClearStoredMessages()
        {
            ((delegate* stdcall<ID3D12InfoQueue*, void>)(lpVtbl[4]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("D3D12_MESSAGE *")] D3D12_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong, D3D12_MESSAGE*, nuint*, int>)(lpVtbl[5]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong>)(lpVtbl[6]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong>)(lpVtbl[7]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong>)(lpVtbl[8]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong>)(lpVtbl[9]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong>)(lpVtbl[10]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, ulong>)(lpVtbl[11]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[12]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[13]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        public void ClearStorageFilter()
        {
            ((delegate* stdcall<ID3D12InfoQueue*, void>)(lpVtbl[14]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, int>)(lpVtbl[15]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, int>)(lpVtbl[16]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[17]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        public void PopStorageFilter()
        {
            ((delegate* stdcall<ID3D12InfoQueue*, void>)(lpVtbl[18]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, uint>)(lpVtbl[19]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[20]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[21]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        public void ClearRetrievalFilter()
        {
            ((delegate* stdcall<ID3D12InfoQueue*, void>)(lpVtbl[22]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, int>)(lpVtbl[23]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, int>)(lpVtbl[24]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[25]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        public void PopRetrievalFilter()
        {
            ((delegate* stdcall<ID3D12InfoQueue*, void>)(lpVtbl[26]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, uint>)(lpVtbl[27]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage(D3D12_MESSAGE_CATEGORY Category, D3D12_MESSAGE_SEVERITY Severity, D3D12_MESSAGE_ID ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_CATEGORY, D3D12_MESSAGE_SEVERITY, D3D12_MESSAGE_ID, sbyte*, int>)(lpVtbl[28]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_SEVERITY, sbyte*, int>)(lpVtbl[29]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_CATEGORY, int, int>)(lpVtbl[30]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_SEVERITY, int, int>)(lpVtbl[31]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID(D3D12_MESSAGE_ID ID, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_ID, int, int>)(lpVtbl[32]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), ID, bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_CATEGORY, int>)(lpVtbl[33]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_SEVERITY, int>)(lpVtbl[34]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID(D3D12_MESSAGE_ID ID)
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, D3D12_MESSAGE_ID, int>)(lpVtbl[35]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), ID);
        }

        public void SetMuteDebugOutput([NativeTypeName("BOOL")] int bMute)
        {
            ((delegate* stdcall<ID3D12InfoQueue*, int, void>)(lpVtbl[36]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), bMute);
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput()
        {
            return ((delegate* stdcall<ID3D12InfoQueue*, int>)(lpVtbl[37]))((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }
    }
}
