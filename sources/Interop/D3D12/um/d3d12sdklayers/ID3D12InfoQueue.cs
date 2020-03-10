// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0742A90B-C387-483F-B946-30A7E4E61458")]
    public unsafe partial struct ID3D12InfoQueue
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID3D12InfoQueue* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMessageCountLimit(ID3D12InfoQueue* pThis, [NativeTypeName("UINT64")] ulong MessageCountLimit);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearStoredMessages(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMessage(ID3D12InfoQueue* pThis, [NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("D3D12_MESSAGE *")] D3D12_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] UIntPtr* pMessageByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesAllowedByStorageFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesDeniedByStorageFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumStoredMessages(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumStoredMessagesAllowedByRetrievalFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesDiscardedByMessageCountLimit(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetMessageCountLimit(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddStorageFilterEntries(ID3D12InfoQueue* pThis, [NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStorageFilter(ID3D12InfoQueue* pThis, [NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] UIntPtr* pFilterByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearStorageFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushEmptyStorageFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushCopyOfStorageFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushStorageFilter(ID3D12InfoQueue* pThis, [NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopStorageFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetStorageFilterStackSize(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddRetrievalFilterEntries(ID3D12InfoQueue* pThis, [NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRetrievalFilter(ID3D12InfoQueue* pThis, [NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] UIntPtr* pFilterByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearRetrievalFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushEmptyRetrievalFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushCopyOfRetrievalFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushRetrievalFilter(ID3D12InfoQueue* pThis, [NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopRetrievalFilter(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetRetrievalFilterStackSize(ID3D12InfoQueue* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddMessage(ID3D12InfoQueue* pThis, D3D12_MESSAGE_CATEGORY Category, D3D12_MESSAGE_SEVERITY Severity, D3D12_MESSAGE_ID ID, [NativeTypeName("LPCSTR")] sbyte* pDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddApplicationMessage(ID3D12InfoQueue* pThis, D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnCategory(ID3D12InfoQueue* pThis, D3D12_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnSeverity(ID3D12InfoQueue* pThis, D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnID(ID3D12InfoQueue* pThis, D3D12_MESSAGE_ID ID, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnCategory(ID3D12InfoQueue* pThis, D3D12_MESSAGE_CATEGORY Category);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnSeverity(ID3D12InfoQueue* pThis, D3D12_MESSAGE_SEVERITY Severity);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnID(ID3D12InfoQueue* pThis, D3D12_MESSAGE_ID ID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMuteDebugOutput(ID3D12InfoQueue* pThis, [NativeTypeName("BOOL")] int bMute);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetMuteDebugOutput(ID3D12InfoQueue* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMessageCountLimit>(lpVtbl->SetMessageCountLimit)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), MessageCountLimit);
        }

        public void ClearStoredMessages()
        {
            Marshal.GetDelegateForFunctionPointer<_ClearStoredMessages>(lpVtbl->ClearStoredMessages)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("UINT64")] ulong MessageIndex, [NativeTypeName("D3D12_MESSAGE *")] D3D12_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] UIntPtr* pMessageByteLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMessage>(lpVtbl->GetMessage)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesAllowedByStorageFilter>(lpVtbl->GetNumMessagesAllowedByStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDeniedByStorageFilter>(lpVtbl->GetNumMessagesDeniedByStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessages>(lpVtbl->GetNumStoredMessages)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessagesAllowedByRetrievalFilter>(lpVtbl->GetNumStoredMessagesAllowedByRetrievalFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDiscardedByMessageCountLimit>(lpVtbl->GetNumMessagesDiscardedByMessageCountLimit)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMessageCountLimit>(lpVtbl->GetMessageCountLimit)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddStorageFilterEntries>(lpVtbl->AddStorageFilterEntries)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] UIntPtr* pFilterByteLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStorageFilter>(lpVtbl->GetStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        public void ClearStorageFilter()
        {
            Marshal.GetDelegateForFunctionPointer<_ClearStorageFilter>(lpVtbl->ClearStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter()
        {
            return Marshal.GetDelegateForFunctionPointer<_PushEmptyStorageFilter>(lpVtbl->PushEmptyStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter()
        {
            return Marshal.GetDelegateForFunctionPointer<_PushCopyOfStorageFilter>(lpVtbl->PushCopyOfStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushStorageFilter>(lpVtbl->PushStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        public void PopStorageFilter()
        {
            Marshal.GetDelegateForFunctionPointer<_PopStorageFilter>(lpVtbl->PopStorageFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetStorageFilterStackSize>(lpVtbl->GetStorageFilterStackSize)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRetrievalFilterEntries>(lpVtbl->AddRetrievalFilterEntries)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] UIntPtr* pFilterByteLength)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilter>(lpVtbl->GetRetrievalFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
        }

        public void ClearRetrievalFilter()
        {
            Marshal.GetDelegateForFunctionPointer<_ClearRetrievalFilter>(lpVtbl->ClearRetrievalFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter()
        {
            return Marshal.GetDelegateForFunctionPointer<_PushEmptyRetrievalFilter>(lpVtbl->PushEmptyRetrievalFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter()
        {
            return Marshal.GetDelegateForFunctionPointer<_PushCopyOfRetrievalFilter>(lpVtbl->PushCopyOfRetrievalFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("D3D12_INFO_QUEUE_FILTER *")] D3D12_INFO_QUEUE_FILTER* pFilter)
        {
            return Marshal.GetDelegateForFunctionPointer<_PushRetrievalFilter>(lpVtbl->PushRetrievalFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
        }

        public void PopRetrievalFilter()
        {
            Marshal.GetDelegateForFunctionPointer<_PopRetrievalFilter>(lpVtbl->PopRetrievalFilter)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilterStackSize>(lpVtbl->GetRetrievalFilterStackSize)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage(D3D12_MESSAGE_CATEGORY Category, D3D12_MESSAGE_SEVERITY Severity, D3D12_MESSAGE_ID ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddMessage>(lpVtbl->AddMessage)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            return Marshal.GetDelegateForFunctionPointer<_AddApplicationMessage>(lpVtbl->AddApplicationMessage)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBreakOnCategory>(lpVtbl->SetBreakOnCategory)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBreakOnSeverity>(lpVtbl->SetBreakOnSeverity)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity, bEnable);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID(D3D12_MESSAGE_ID ID, [NativeTypeName("BOOL")] int bEnable)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBreakOnID>(lpVtbl->SetBreakOnID)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), ID, bEnable);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBreakOnCategory>(lpVtbl->GetBreakOnCategory)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Category);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBreakOnSeverity>(lpVtbl->GetBreakOnSeverity)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), Severity);
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID(D3D12_MESSAGE_ID ID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBreakOnID>(lpVtbl->GetBreakOnID)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), ID);
        }

        public void SetMuteDebugOutput([NativeTypeName("BOOL")] int bMute)
        {
            Marshal.GetDelegateForFunctionPointer<_SetMuteDebugOutput>(lpVtbl->SetMuteDebugOutput)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this), bMute);
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMuteDebugOutput>(lpVtbl->GetMuteDebugOutput)((ID3D12InfoQueue*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
            public IntPtr SetMessageCountLimit;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr ClearStoredMessages;

            [NativeTypeName("HRESULT (UINT64, D3D12_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetMessage;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetNumMessagesAllowedByStorageFilter;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetNumMessagesDeniedByStorageFilter;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetNumStoredMessages;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetNumStoredMessagesAllowedByRetrievalFilter;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetNumMessagesDiscardedByMessageCountLimit;

            [NativeTypeName("UINT64 () __attribute__((stdcall))")]
            public IntPtr GetMessageCountLimit;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr AddStorageFilterEntries;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetStorageFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr ClearStorageFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr PushEmptyStorageFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr PushCopyOfStorageFilter;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr PushStorageFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr PopStorageFilter;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetStorageFilterStackSize;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr AddRetrievalFilterEntries;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
            public IntPtr GetRetrievalFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr ClearRetrievalFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr PushEmptyRetrievalFilter;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr PushCopyOfRetrievalFilter;

            [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
            public IntPtr PushRetrievalFilter;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public IntPtr PopRetrievalFilter;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetRetrievalFilterStackSize;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_CATEGORY, D3D12_MESSAGE_SEVERITY, D3D12_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
            public IntPtr AddMessage;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
            public IntPtr AddApplicationMessage;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
            public IntPtr SetBreakOnCategory;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
            public IntPtr SetBreakOnSeverity;

            [NativeTypeName("HRESULT (D3D12_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
            public IntPtr SetBreakOnID;

            [NativeTypeName("BOOL (D3D12_MESSAGE_CATEGORY) __attribute__((stdcall))")]
            public IntPtr GetBreakOnCategory;

            [NativeTypeName("BOOL (D3D12_MESSAGE_SEVERITY) __attribute__((stdcall))")]
            public IntPtr GetBreakOnSeverity;

            [NativeTypeName("BOOL (D3D12_MESSAGE_ID) __attribute__((stdcall))")]
            public IntPtr GetBreakOnID;

            [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
            public IntPtr SetMuteDebugOutput;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr GetMuteDebugOutput;
        }
    }
}
