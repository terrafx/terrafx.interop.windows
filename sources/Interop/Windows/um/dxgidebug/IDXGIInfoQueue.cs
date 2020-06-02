// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D67441C7-672A-476F-9E82-CD55B44949CE")]
    public unsafe partial struct IDXGIInfoQueue
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return lpVtbl->SetMessageCountLimit((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageCountLimit);
        }

        public void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            lpVtbl->ClearStoredMessages((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE *")] DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return lpVtbl->GetMessage((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageIndex, pMessage, pMessageByteLength);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilters([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetNumStoredMessagesAllowedByRetrievalFilters((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetNumStoredMessages((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetNumMessagesDiscardedByMessageCountLimit((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetMessageCountLimit((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetNumMessagesAllowedByStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetNumMessagesDeniedByStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->AddStorageFilterEntries((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return lpVtbl->GetStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        public void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            lpVtbl->ClearStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->PushEmptyStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->PushDenyAllStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->PushCopyOfStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->PushStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        public void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            lpVtbl->PopStorageFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetStorageFilterStackSize((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->AddRetrievalFilterEntries((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return lpVtbl->GetRetrievalFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        public void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            lpVtbl->ClearRetrievalFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->PushEmptyRetrievalFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->PushDenyAllRetrievalFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->PushCopyOfRetrievalFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return lpVtbl->PushRetrievalFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        public void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            lpVtbl->PopRetrievalFilter((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetRetrievalFilterStackSize((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return lpVtbl->AddMessage((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, Severity, ID, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return lpVtbl->AddApplicationMessage((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            return lpVtbl->SetBreakOnCategory((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            return lpVtbl->SetBreakOnSeverity((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("BOOL")] int bEnable)
        {
            return lpVtbl->SetBreakOnID((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID, bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category)
        {
            return lpVtbl->GetBreakOnCategory((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity)
        {
            return lpVtbl->GetBreakOnSeverity((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID)
        {
            return lpVtbl->GetBreakOnID((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID);
        }

        public void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("BOOL")] int bMute)
        {
            lpVtbl->SetMuteDebugOutput((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, bMute);
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return lpVtbl->GetMuteDebugOutput((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, uint> Release;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong, int> SetMessageCountLimit;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, void> ClearStoredMessages;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64, DXGI_INFO_QUEUE_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong, DXGI_INFO_QUEUE_MESSAGE*, nuint*, int> GetMessage;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong> GetNumStoredMessagesAllowedByRetrievalFilters;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong> GetNumStoredMessages;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong> GetNumMessagesDiscardedByMessageCountLimit;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong> GetMessageCountLimit;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong> GetNumMessagesAllowedByStorageFilter;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, ulong> GetNumMessagesDeniedByStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> AddStorageFilterEntries;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> GetStorageFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, void> ClearStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int> PushEmptyStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int> PushDenyAllStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int> PushCopyOfStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushStorageFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, void> PopStorageFilter;

            [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, uint> GetStorageFilterStackSize;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> AddRetrievalFilterEntries;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> GetRetrievalFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, void> ClearRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int> PushEmptyRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int> PushDenyAllRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int> PushCopyOfRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushRetrievalFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, void> PopRetrievalFilter;

            [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, uint> GetRetrievalFilterStackSize;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, DXGI_INFO_QUEUE_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, sbyte*, int> AddMessage;

            [NativeTypeName("HRESULT (DXGI_INFO_QUEUE_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, sbyte*, int> AddApplicationMessage;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int, int> SetBreakOnCategory;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, int> SetBreakOnSeverity;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int, int, int> SetBreakOnID;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int> GetBreakOnCategory;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int> GetBreakOnSeverity;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int, int> GetBreakOnID;

            [NativeTypeName("void (DXGI_DEBUG_ID, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int, void> SetMuteDebugOutput;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIInfoQueue*, Guid, int> GetMuteDebugOutput;
        }
    }
}
