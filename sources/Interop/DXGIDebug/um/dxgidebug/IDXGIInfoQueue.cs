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

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIInfoQueue* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIInfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIInfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMessageCountLimit(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearStoredMessages(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMessage(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE *")] DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumStoredMessagesAllowedByRetrievalFilters(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumStoredMessages(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesDiscardedByMessageCountLimit(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetMessageCountLimit(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesAllowedByStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesDeniedByStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddStorageFilterEntries(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushEmptyStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushDenyAllStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushCopyOfStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopStorageFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetStorageFilterStackSize(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddRetrievalFilterEntries(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRetrievalFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearRetrievalFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushEmptyRetrievalFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushDenyAllRetrievalFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushCopyOfRetrievalFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushRetrievalFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopRetrievalFilter(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetRetrievalFilterStackSize(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddMessage(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddApplicationMessage(IDXGIInfoQueue* pThis, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnCategory(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnSeverity(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnID(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnCategory(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnSeverity(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnID(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMuteDebugOutput(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("BOOL")] int bMute);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetMuteDebugOutput(IDXGIInfoQueue* pThis, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMessageCountLimit>(lpVtbl->SetMessageCountLimit)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageCountLimit);
        }

        public void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearStoredMessages>(lpVtbl->ClearStoredMessages)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE *")] DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMessage>(lpVtbl->GetMessage)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageIndex, pMessage, pMessageByteLength);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilters([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessagesAllowedByRetrievalFilters>(lpVtbl->GetNumStoredMessagesAllowedByRetrievalFilters)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessages>(lpVtbl->GetNumStoredMessages)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDiscardedByMessageCountLimit>(lpVtbl->GetNumMessagesDiscardedByMessageCountLimit)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMessageCountLimit>(lpVtbl->GetMessageCountLimit)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesAllowedByStorageFilter>(lpVtbl->GetNumMessagesAllowedByStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDeniedByStorageFilter>(lpVtbl->GetNumMessagesDeniedByStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddStorageFilterEntries>(lpVtbl->AddStorageFilterEntries)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStorageFilter>(lpVtbl->GetStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        public void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearStorageFilter>(lpVtbl->ClearStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushEmptyStorageFilter>(lpVtbl->PushEmptyStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushDenyAllStorageFilter>(lpVtbl->PushDenyAllStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushCopyOfStorageFilter>(lpVtbl->PushCopyOfStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushStorageFilter>(lpVtbl->PushStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        public void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            Marshal.GetDelegateForFunctionPointer<_PopStorageFilter>(lpVtbl->PopStorageFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStorageFilterStackSize>(lpVtbl->GetStorageFilterStackSize)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRetrievalFilterEntries>(lpVtbl->AddRetrievalFilterEntries)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilter>(lpVtbl->GetRetrievalFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
        }

        public void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            Marshal.GetDelegateForFunctionPointer<_ClearRetrievalFilter>(lpVtbl->ClearRetrievalFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushEmptyRetrievalFilter>(lpVtbl->PushEmptyRetrievalFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushDenyAllRetrievalFilter>(lpVtbl->PushDenyAllRetrievalFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushCopyOfRetrievalFilter>(lpVtbl->PushCopyOfRetrievalFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_FILTER *")] DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushRetrievalFilter>(lpVtbl->PushRetrievalFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
        }

        public void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            Marshal.GetDelegateForFunctionPointer<_PopRetrievalFilter>(lpVtbl->PopRetrievalFilter)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilterStackSize>(lpVtbl->GetRetrievalFilterStackSize)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddMessage>(lpVtbl->AddMessage)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, Severity, ID, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddApplicationMessage>(lpVtbl->AddApplicationMessage)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBreakOnCategory>(lpVtbl->SetBreakOnCategory)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBreakOnSeverity>(lpVtbl->SetBreakOnSeverity)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("BOOL")] int bEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBreakOnID>(lpVtbl->SetBreakOnID)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID, bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBreakOnCategory>(lpVtbl->GetBreakOnCategory)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBreakOnSeverity>(lpVtbl->GetBreakOnSeverity)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBreakOnID>(lpVtbl->GetBreakOnID)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID);
        }

        public void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("BOOL")] int bMute)
        {
            Marshal.GetDelegateForFunctionPointer<_SetMuteDebugOutput>(lpVtbl->SetMuteDebugOutput)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, bMute);
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMuteDebugOutput>(lpVtbl->GetMuteDebugOutput)((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64) __attribute__((stdcall))")]
            public IntPtr SetMessageCountLimit;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr ClearStoredMessages;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64, DXGI_INFO_QUEUE_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetMessage;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetNumStoredMessagesAllowedByRetrievalFilters;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetNumStoredMessages;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetNumMessagesDiscardedByMessageCountLimit;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetMessageCountLimit;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetNumMessagesAllowedByStorageFilter;

            [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetNumMessagesDeniedByStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr AddStorageFilterEntries;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetStorageFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr ClearStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PushEmptyStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PushDenyAllStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PushCopyOfStorageFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr PushStorageFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PopStorageFilter;

            [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetStorageFilterStackSize;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr AddRetrievalFilterEntries;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetRetrievalFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr ClearRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PushEmptyRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PushDenyAllRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PushCopyOfRetrievalFilter;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr PushRetrievalFilter;

            [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr PopRetrievalFilter;

            [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetRetrievalFilterStackSize;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, DXGI_INFO_QUEUE_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
            public IntPtr AddMessage;

            [NativeTypeName("HRESULT (DXGI_INFO_QUEUE_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
            public IntPtr AddApplicationMessage;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
            public IntPtr SetBreakOnCategory;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
            public IntPtr SetBreakOnSeverity;

            [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
            public IntPtr SetBreakOnID;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY) __attribute__((stdcall))")]
            public IntPtr GetBreakOnCategory;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY) __attribute__((stdcall))")]
            public IntPtr GetBreakOnSeverity;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID) __attribute__((stdcall))")]
            public IntPtr GetBreakOnID;

            [NativeTypeName("void (DXGI_DEBUG_ID, BOOL) __attribute__((stdcall))")]
            public IntPtr SetMuteDebugOutput;

            [NativeTypeName("BOOL (DXGI_DEBUG_ID) __attribute__((stdcall))")]
            public IntPtr GetMuteDebugOutput;
        }
    }
}
