// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6543DBB6-1B48-42F5-AB82-E97EC74326F6")]
    [NativeTypeName("struct ID3D11InfoQueue : IUnknown")]
    public unsafe partial struct ID3D11InfoQueue
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, uint>)(lpVtbl[1]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, uint>)(lpVtbl[2]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong, int>)(lpVtbl[3]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), MessageCountLimit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearStoredMessages()
        {
            ((delegate* unmanaged<ID3D11InfoQueue*, void>)(lpVtbl[4]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("D3D11_MESSAGE *")] D3D11_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong, D3D11_MESSAGE*, nuint*, int>)(lpVtbl[5]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong>)(lpVtbl[6]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong>)(lpVtbl[7]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong>)(lpVtbl[8]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong>)(lpVtbl[9]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong>)(lpVtbl[10]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, ulong>)(lpVtbl[11]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("D3D11_INFO_QUEUE_FILTER *")] D3D11_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_INFO_QUEUE_FILTER*, int>)(lpVtbl[12]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("D3D11_INFO_QUEUE_FILTER *")] D3D11_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[13]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearStorageFilter()
        {
            ((delegate* unmanaged<ID3D11InfoQueue*, void>)(lpVtbl[14]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, int>)(lpVtbl[15]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, int>)(lpVtbl[16]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("D3D11_INFO_QUEUE_FILTER *")] D3D11_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_INFO_QUEUE_FILTER*, int>)(lpVtbl[17]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopStorageFilter()
        {
            ((delegate* unmanaged<ID3D11InfoQueue*, void>)(lpVtbl[18]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, uint>)(lpVtbl[19]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("D3D11_INFO_QUEUE_FILTER *")] D3D11_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_INFO_QUEUE_FILTER*, int>)(lpVtbl[20]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("D3D11_INFO_QUEUE_FILTER *")] D3D11_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[21]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearRetrievalFilter()
        {
            ((delegate* unmanaged<ID3D11InfoQueue*, void>)(lpVtbl[22]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, int>)(lpVtbl[23]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, int>)(lpVtbl[24]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("D3D11_INFO_QUEUE_FILTER *")] D3D11_INFO_QUEUE_FILTER* pFilter)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_INFO_QUEUE_FILTER*, int>)(lpVtbl[25]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopRetrievalFilter()
        {
            ((delegate* unmanaged<ID3D11InfoQueue*, void>)(lpVtbl[26]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, uint>)(lpVtbl[27]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddMessage(D3D11_MESSAGE_CATEGORY Category, D3D11_MESSAGE_SEVERITY Severity, D3D11_MESSAGE_ID ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_CATEGORY, D3D11_MESSAGE_SEVERITY, D3D11_MESSAGE_ID, sbyte*, int>)(lpVtbl[28]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(D3D11_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_SEVERITY, sbyte*, int>)(lpVtbl[29]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory(D3D11_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_CATEGORY, int, int>)(lpVtbl[30]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Category, bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity(D3D11_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_SEVERITY, int, int>)(lpVtbl[31]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Severity, bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID(D3D11_MESSAGE_ID ID, [NativeTypeName("BOOL")] int bEnable)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_ID, int, int>)(lpVtbl[32]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), ID, bEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory(D3D11_MESSAGE_CATEGORY Category)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_CATEGORY, int>)(lpVtbl[33]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Category);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity(D3D11_MESSAGE_SEVERITY Severity)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_SEVERITY, int>)(lpVtbl[34]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), Severity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID(D3D11_MESSAGE_ID ID)
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, D3D11_MESSAGE_ID, int>)(lpVtbl[35]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), ID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetMuteDebugOutput([NativeTypeName("BOOL")] int bMute)
        {
            ((delegate* unmanaged<ID3D11InfoQueue*, int, void>)(lpVtbl[36]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this), bMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput()
        {
            return ((delegate* unmanaged<ID3D11InfoQueue*, int>)(lpVtbl[37]))((ID3D11InfoQueue*)Unsafe.AsPointer(ref this));
        }
    }
}
