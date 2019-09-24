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
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIInfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIInfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMessageCountLimit(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("UINT64")] ulong MessageCountLimit
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _ClearStoredMessages(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMessage(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("UINT64")] ulong MessageIndex,
            [Out, Optional] DXGI_INFO_QUEUE_MESSAGE* pMessage,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pMessageByteLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumStoredMessagesAllowedByRetrievalFilters(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumStoredMessages(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumMessagesDiscardedByMessageCountLimit(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetMessageCountLimit(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumMessagesAllowedByStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumMessagesDeniedByStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddStorageFilterEntries(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [Out, Optional] DXGI_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ClearStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushEmptyStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushDenyAllStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushCopyOfStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _PopStorageFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public /* static */ delegate uint _GetStorageFilterStackSize(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddRetrievalFilterEntries(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRetrievalFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [Out, Optional] DXGI_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _ClearRetrievalFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushEmptyRetrievalFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushDenyAllRetrievalFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushCopyOfRetrievalFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushRetrievalFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _PopRetrievalFilter(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public /* static */ delegate uint _GetRetrievalFilterStackSize(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddMessage(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddApplicationMessage(
            [In] IDXGIInfoQueue* This,
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBreakOnCategory(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
            [In, NativeTypeName("BOOL")] int bEnable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBreakOnSeverity(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("BOOL")] int bEnable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBreakOnID(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
            [In, NativeTypeName("BOOL")] int bEnable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetBreakOnCategory(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetBreakOnSeverity(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetBreakOnID(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetMuteDebugOutput(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("BOOL")] int bMute
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetMuteDebugOutput(
            [In] IDXGIInfoQueue* This,
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("UINT64")] ulong MessageCountLimit
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMessageCountLimit>(lpVtbl->SetMessageCountLimit)(
                    This,
                    Producer,
                    MessageCountLimit
                );
            }
        }

        public void ClearStoredMessages(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearStoredMessages>(lpVtbl->ClearStoredMessages)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("UINT64")] ulong MessageIndex,
            [Out, Optional] DXGI_INFO_QUEUE_MESSAGE* pMessage,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pMessageByteLength
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMessage>(lpVtbl->GetMessage)(
                    This,
                    Producer,
                    MessageIndex,
                    pMessage,
                    pMessageByteLength
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilters(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessagesAllowedByRetrievalFilters>(lpVtbl->GetNumStoredMessagesAllowedByRetrievalFilters)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessages>(lpVtbl->GetNumStoredMessages)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDiscardedByMessageCountLimit>(lpVtbl->GetNumMessagesDiscardedByMessageCountLimit)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMessageCountLimit>(lpVtbl->GetMessageCountLimit)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesAllowedByStorageFilter>(lpVtbl->GetNumMessagesAllowedByStorageFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDeniedByStorageFilter>(lpVtbl->GetNumMessagesDeniedByStorageFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddStorageFilterEntries>(lpVtbl->AddStorageFilterEntries)(
                    This,
                    Producer,
                    pFilter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [Out, Optional] DXGI_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStorageFilter>(lpVtbl->GetStorageFilter)(
                    This,
                    Producer,
                    pFilter,
                    pFilterByteLength
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ClearStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ClearStorageFilter>(lpVtbl->ClearStorageFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushEmptyStorageFilter>(lpVtbl->PushEmptyStorageFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushDenyAllStorageFilter>(lpVtbl->PushDenyAllStorageFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushCopyOfStorageFilter>(lpVtbl->PushCopyOfStorageFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushStorageFilter>(lpVtbl->PushStorageFilter)(
                    This,
                    Producer,
                    pFilter
                );
            }
        }

        public void PopStorageFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopStorageFilter>(lpVtbl->PopStorageFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStorageFilterStackSize>(lpVtbl->GetStorageFilterStackSize)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRetrievalFilterEntries>(lpVtbl->AddRetrievalFilterEntries)(
                    This,
                    Producer,
                    pFilter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [Out, Optional] DXGI_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilter>(lpVtbl->GetRetrievalFilter)(
                    This,
                    Producer,
                    pFilter,
                    pFilterByteLength
                );
            }
        }

        public void ClearRetrievalFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearRetrievalFilter>(lpVtbl->ClearRetrievalFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushEmptyRetrievalFilter>(lpVtbl->PushEmptyRetrievalFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushDenyAllRetrievalFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushDenyAllRetrievalFilter>(lpVtbl->PushDenyAllRetrievalFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushCopyOfRetrievalFilter>(lpVtbl->PushCopyOfRetrievalFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushRetrievalFilter>(lpVtbl->PushRetrievalFilter)(
                    This,
                    Producer,
                    pFilter
                );
            }
        }

        public void PopRetrievalFilter(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopRetrievalFilter>(lpVtbl->PopRetrievalFilter)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilterStackSize>(lpVtbl->GetRetrievalFilterStackSize)(
                    This,
                    Producer
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddMessage>(lpVtbl->AddMessage)(
                    This,
                    Producer,
                    Category,
                    Severity,
                    ID,
                    pDescription
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddApplicationMessage>(lpVtbl->AddApplicationMessage)(
                    This,
                    Severity,
                    pDescription
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnCategory(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
            [In, NativeTypeName("BOOL")] int bEnable
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnCategory>(lpVtbl->SetBreakOnCategory)(
                    This,
                    Producer,
                    Category,
                    bEnable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("BOOL")] int bEnable
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnSeverity>(lpVtbl->SetBreakOnSeverity)(
                    This,
                    Producer,
                    Severity,
                    bEnable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
            [In, NativeTypeName("BOOL")] int bEnable
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnID>(lpVtbl->SetBreakOnID)(
                    This,
                    Producer,
                    ID,
                    bEnable
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnCategory>(lpVtbl->GetBreakOnCategory)(
                    This,
                    Producer,
                    Category
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In] DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnSeverity>(lpVtbl->GetBreakOnSeverity)(
                    This,
                    Producer,
                    Severity
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnID>(lpVtbl->GetBreakOnID)(
                    This,
                    Producer,
                    ID
                );
            }
        }

        public void SetMuteDebugOutput(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [In, NativeTypeName("BOOL")] int bMute
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMuteDebugOutput>(lpVtbl->SetMuteDebugOutput)(
                    This,
                    Producer,
                    bMute
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput(
            [In, NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        )
        {
            fixed (IDXGIInfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMuteDebugOutput>(lpVtbl->GetMuteDebugOutput)(
                    This,
                    Producer
                );
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
