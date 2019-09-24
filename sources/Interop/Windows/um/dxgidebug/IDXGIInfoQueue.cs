// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dxgidebug.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D67441C7-672A-476F-9E82-CD55B44949CE")]
    public unsafe struct IDXGIInfoQueue
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIInfoQueue* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIInfoQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIInfoQueue* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMessageCountLimit(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearStoredMessages(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMessage(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, [Optional] DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T")] UIntPtr* pMessageByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumStoredMessagesAllowedByRetrievalFilters(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumStoredMessages(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesDiscardedByMessageCountLimit(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetMessageCountLimit(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesAllowedByStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetNumMessagesDeniedByStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddStorageFilterEntries(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [Optional] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ClearStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushEmptyStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushDenyAllStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushCopyOfStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopStorageFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetStorageFilterStackSize(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddRetrievalFilterEntries(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRetrievalFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [Optional] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearRetrievalFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushEmptyRetrievalFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushDenyAllRetrievalFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushCopyOfRetrievalFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _PushRetrievalFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _PopRetrievalFilter(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetRetrievalFilterStackSize(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddMessage(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AddApplicationMessage(IDXGIInfoQueue* This, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnCategory(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnSeverity(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBreakOnID(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("BOOL")] int bEnable);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnCategory(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnSeverity(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetBreakOnID(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMuteDebugOutput(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("BOOL")] int bMute);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _GetMuteDebugOutput(IDXGIInfoQueue* This, [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMessageCountLimit>(lpVtbl->SetMessageCountLimit)(This, Producer, MessageCountLimit);
            }
        }

        public void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearStoredMessages>(lpVtbl->ClearStoredMessages)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, [Optional] DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T")] UIntPtr* pMessageByteLength)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMessage>(lpVtbl->GetMessage)(This, Producer, MessageIndex, pMessage, pMessageByteLength);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilters([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessagesAllowedByRetrievalFilters>(lpVtbl->GetNumStoredMessagesAllowedByRetrievalFilters)(This, Producer);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessages>(lpVtbl->GetNumStoredMessages)(This, Producer);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDiscardedByMessageCountLimit>(lpVtbl->GetNumMessagesDiscardedByMessageCountLimit)(This, Producer);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMessageCountLimit>(lpVtbl->GetMessageCountLimit)(This, Producer);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesAllowedByStorageFilter>(lpVtbl->GetNumMessagesAllowedByStorageFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDeniedByStorageFilter>(lpVtbl->GetNumMessagesDeniedByStorageFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddStorageFilterEntries>(lpVtbl->AddStorageFilterEntries)(This, Producer, pFilter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [Optional] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStorageFilter>(lpVtbl->GetStorageFilter)(This, Producer, pFilter, pFilterByteLength);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ClearStorageFilter>(lpVtbl->ClearStorageFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushEmptyStorageFilter>(lpVtbl->PushEmptyStorageFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushDenyAllStorageFilter>(lpVtbl->PushDenyAllStorageFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushCopyOfStorageFilter>(lpVtbl->PushCopyOfStorageFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushStorageFilter>(lpVtbl->PushStorageFilter)(This, Producer, pFilter);
            }
        }

        public void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopStorageFilter>(lpVtbl->PopStorageFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStorageFilterStackSize>(lpVtbl->GetStorageFilterStackSize)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRetrievalFilterEntries>(lpVtbl->AddRetrievalFilterEntries)(This, Producer, pFilter);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [Optional] DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilter>(lpVtbl->GetRetrievalFilter)(This, Producer, pFilter, pFilterByteLength);
            }
        }

        public void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearRetrievalFilter>(lpVtbl->ClearRetrievalFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushEmptyRetrievalFilter>(lpVtbl->PushEmptyRetrievalFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushDenyAllRetrievalFilter>(lpVtbl->PushDenyAllRetrievalFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushCopyOfRetrievalFilter>(lpVtbl->PushCopyOfRetrievalFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushRetrievalFilter>(lpVtbl->PushRetrievalFilter)(This, Producer, pFilter);
            }
        }

        public void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopRetrievalFilter>(lpVtbl->PopRetrievalFilter)(This, Producer);
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilterStackSize>(lpVtbl->GetRetrievalFilterStackSize)(This, Producer);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddMessage>(lpVtbl->AddMessage)(This, Producer, Category, Severity, ID, pDescription);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddApplicationMessage>(lpVtbl->AddApplicationMessage)(This, Severity, pDescription);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, [NativeTypeName("BOOL")] int bEnable)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnCategory>(lpVtbl->SetBreakOnCategory)(This, Producer, Category, bEnable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("BOOL")] int bEnable)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnSeverity>(lpVtbl->SetBreakOnSeverity)(This, Producer, Severity, bEnable);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("BOOL")] int bEnable)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnID>(lpVtbl->SetBreakOnID)(This, Producer, ID, bEnable);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnCategory>(lpVtbl->GetBreakOnCategory)(This, Producer, Category);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnSeverity>(lpVtbl->GetBreakOnSeverity)(This, Producer, Severity);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnID>(lpVtbl->GetBreakOnID)(This, Producer, ID);
            }
        }

        public void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("BOOL")] int bMute)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMuteDebugOutput>(lpVtbl->SetMuteDebugOutput)(This, Producer, bMute);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMuteDebugOutput>(lpVtbl->GetMuteDebugOutput)(This, Producer);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetMessageCountLimit;

            public IntPtr ClearStoredMessages;

            public IntPtr GetMessage;

            public IntPtr GetNumStoredMessagesAllowedByRetrievalFilters;

            public IntPtr GetNumStoredMessages;

            public IntPtr GetNumMessagesDiscardedByMessageCountLimit;

            public IntPtr GetMessageCountLimit;

            public IntPtr GetNumMessagesAllowedByStorageFilter;

            public IntPtr GetNumMessagesDeniedByStorageFilter;

            public IntPtr AddStorageFilterEntries;

            public IntPtr GetStorageFilter;

            public IntPtr ClearStorageFilter;

            public IntPtr PushEmptyStorageFilter;

            public IntPtr PushDenyAllStorageFilter;

            public IntPtr PushCopyOfStorageFilter;

            public IntPtr PushStorageFilter;

            public IntPtr PopStorageFilter;

            public IntPtr GetStorageFilterStackSize;

            public IntPtr AddRetrievalFilterEntries;

            public IntPtr GetRetrievalFilter;

            public IntPtr ClearRetrievalFilter;

            public IntPtr PushEmptyRetrievalFilter;

            public IntPtr PushDenyAllRetrievalFilter;

            public IntPtr PushCopyOfRetrievalFilter;

            public IntPtr PushRetrievalFilter;

            public IntPtr PopRetrievalFilter;

            public IntPtr GetRetrievalFilterStackSize;

            public IntPtr AddMessage;

            public IntPtr AddApplicationMessage;

            public IntPtr SetBreakOnCategory;

            public IntPtr SetBreakOnSeverity;

            public IntPtr SetBreakOnID;

            public IntPtr GetBreakOnCategory;

            public IntPtr GetBreakOnSeverity;

            public IntPtr GetBreakOnID;

            public IntPtr SetMuteDebugOutput;

            public IntPtr GetMuteDebugOutput;
        }
    }
}
