// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0742A90B-C387-483F-B946-30A7E4E61458")]
    public unsafe struct ID3D12InfoQueue
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID3D12InfoQueue* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetMessageCountLimit(
            [In] ID3D12InfoQueue* This,
            [In, NativeTypeName("UINT64")] ulong MessageCountLimit
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _ClearStoredMessages(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetMessage(
            [In] ID3D12InfoQueue* This,
            [In, NativeTypeName("UINT64")] ulong MessageIndex,
            [Out, Optional] D3D12_MESSAGE* pMessage,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pMessageByteLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumMessagesAllowedByStorageFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumMessagesDeniedByStorageFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumStoredMessages(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumStoredMessagesAllowedByRetrievalFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetNumMessagesDiscardedByMessageCountLimit(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetMessageCountLimit(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddStorageFilterEntries(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetStorageFilter(
            [In] ID3D12InfoQueue* This,
            [Out, Optional] D3D12_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _ClearStorageFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushEmptyStorageFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushCopyOfStorageFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushStorageFilter(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _PopStorageFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public /* static */ delegate uint _GetStorageFilterStackSize(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddRetrievalFilterEntries(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetRetrievalFilter(
            [In] ID3D12InfoQueue* This,
            [Out, Optional] D3D12_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _ClearRetrievalFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushEmptyRetrievalFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushCopyOfRetrievalFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _PushRetrievalFilter(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _PopRetrievalFilter(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public /* static */ delegate uint _GetRetrievalFilterStackSize(
            [In] ID3D12InfoQueue* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddMessage(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_CATEGORY Category,
            [In] D3D12_MESSAGE_SEVERITY Severity,
            [In] D3D12_MESSAGE_ID ID,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddApplicationMessage(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBreakOnCategory(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_CATEGORY Category,
            [In, NativeTypeName("BOOL")] int bEnable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBreakOnSeverity(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("BOOL")] int bEnable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetBreakOnID(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_ID ID,
            [In, NativeTypeName("BOOL")] int bEnable
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetBreakOnCategory(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_CATEGORY Category
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetBreakOnSeverity(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_SEVERITY Severity
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetBreakOnID(
            [In] ID3D12InfoQueue* This,
            [In] D3D12_MESSAGE_ID ID
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetMuteDebugOutput(
            [In] ID3D12InfoQueue* This,
            [In, NativeTypeName("BOOL")] int bMute
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _GetMuteDebugOutput(
            [In] ID3D12InfoQueue* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
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
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMessageCountLimit(
            [In, NativeTypeName("UINT64")] ulong MessageCountLimit
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetMessageCountLimit>(lpVtbl->SetMessageCountLimit)(
                    This,
                    MessageCountLimit
                );
            }
        }

        public void ClearStoredMessages()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearStoredMessages>(lpVtbl->ClearStoredMessages)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMessage(
            [In, NativeTypeName("UINT64")] ulong MessageIndex,
            [Out, Optional] D3D12_MESSAGE* pMessage,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pMessageByteLength
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMessage>(lpVtbl->GetMessage)(
                    This,
                    MessageIndex,
                    pMessage,
                    pMessageByteLength
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesAllowedByStorageFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesAllowedByStorageFilter>(lpVtbl->GetNumMessagesAllowedByStorageFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDeniedByStorageFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDeniedByStorageFilter>(lpVtbl->GetNumMessagesDeniedByStorageFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessages()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessages>(lpVtbl->GetNumStoredMessages)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumStoredMessagesAllowedByRetrievalFilter>(lpVtbl->GetNumStoredMessagesAllowedByRetrievalFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetNumMessagesDiscardedByMessageCountLimit()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetNumMessagesDiscardedByMessageCountLimit>(lpVtbl->GetNumMessagesDiscardedByMessageCountLimit)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMessageCountLimit()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMessageCountLimit>(lpVtbl->GetMessageCountLimit)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddStorageFilterEntries(
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddStorageFilterEntries>(lpVtbl->AddStorageFilterEntries)(
                    This,
                    pFilter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStorageFilter(
            [Out, Optional] D3D12_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStorageFilter>(lpVtbl->GetStorageFilter)(
                    This,
                    pFilter,
                    pFilterByteLength
                );
            }
        }

        public void ClearStorageFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearStorageFilter>(lpVtbl->ClearStorageFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyStorageFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushEmptyStorageFilter>(lpVtbl->PushEmptyStorageFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfStorageFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushCopyOfStorageFilter>(lpVtbl->PushCopyOfStorageFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushStorageFilter(
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushStorageFilter>(lpVtbl->PushStorageFilter)(
                    This,
                    pFilter
                );
            }
        }

        public void PopStorageFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopStorageFilter>(lpVtbl->PopStorageFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetStorageFilterStackSize()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStorageFilterStackSize>(lpVtbl->GetStorageFilterStackSize)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddRetrievalFilterEntries(
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRetrievalFilterEntries>(lpVtbl->AddRetrievalFilterEntries)(
                    This,
                    pFilter
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRetrievalFilter(
            [Out, Optional] D3D12_INFO_QUEUE_FILTER* pFilter,
            [In, Out, NativeTypeName("SIZE_T")] UIntPtr* pFilterByteLength
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilter>(lpVtbl->GetRetrievalFilter)(
                    This,
                    pFilter,
                    pFilterByteLength
                );
            }
        }

        public void ClearRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearRetrievalFilter>(lpVtbl->ClearRetrievalFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushEmptyRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushEmptyRetrievalFilter>(lpVtbl->PushEmptyRetrievalFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushCopyOfRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushCopyOfRetrievalFilter>(lpVtbl->PushCopyOfRetrievalFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int PushRetrievalFilter(
            [In] D3D12_INFO_QUEUE_FILTER* pFilter
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_PushRetrievalFilter>(lpVtbl->PushRetrievalFilter)(
                    This,
                    pFilter
                );
            }
        }

        public void PopRetrievalFilter()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_PopRetrievalFilter>(lpVtbl->PopRetrievalFilter)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT")]
        public uint GetRetrievalFilterStackSize()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRetrievalFilterStackSize>(lpVtbl->GetRetrievalFilterStackSize)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMessage(
            [In] D3D12_MESSAGE_CATEGORY Category,
            [In] D3D12_MESSAGE_SEVERITY Severity,
            [In] D3D12_MESSAGE_ID ID,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddMessage>(lpVtbl->AddMessage)(
                    This,
                    Category,
                    Severity,
                    ID,
                    pDescription
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddApplicationMessage(
            [In] D3D12_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("LPCSTR")] sbyte* pDescription
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
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
            [In] D3D12_MESSAGE_CATEGORY Category,
            [In, NativeTypeName("BOOL")] int bEnable
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnCategory>(lpVtbl->SetBreakOnCategory)(
                    This,
                    Category,
                    bEnable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnSeverity(
            [In] D3D12_MESSAGE_SEVERITY Severity,
            [In, NativeTypeName("BOOL")] int bEnable
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnSeverity>(lpVtbl->SetBreakOnSeverity)(
                    This,
                    Severity,
                    bEnable
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBreakOnID(
            [In] D3D12_MESSAGE_ID ID,
            [In, NativeTypeName("BOOL")] int bEnable
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetBreakOnID>(lpVtbl->SetBreakOnID)(
                    This,
                    ID,
                    bEnable
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnCategory(
            [In] D3D12_MESSAGE_CATEGORY Category
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnCategory>(lpVtbl->GetBreakOnCategory)(
                    This,
                    Category
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnSeverity(
            [In] D3D12_MESSAGE_SEVERITY Severity
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnSeverity>(lpVtbl->GetBreakOnSeverity)(
                    This,
                    Severity
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetBreakOnID(
            [In] D3D12_MESSAGE_ID ID
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetBreakOnID>(lpVtbl->GetBreakOnID)(
                    This,
                    ID
                );
            }
        }

        public void SetMuteDebugOutput(
            [In, NativeTypeName("BOOL")] int bMute
        )
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMuteDebugOutput>(lpVtbl->SetMuteDebugOutput)(
                    This,
                    bMute
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int GetMuteDebugOutput()
        {
            fixed (ID3D12InfoQueue* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMuteDebugOutput>(lpVtbl->GetMuteDebugOutput)(
                    This
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

            public IntPtr GetNumMessagesAllowedByStorageFilter;

            public IntPtr GetNumMessagesDeniedByStorageFilter;

            public IntPtr GetNumStoredMessages;

            public IntPtr GetNumStoredMessagesAllowedByRetrievalFilter;

            public IntPtr GetNumMessagesDiscardedByMessageCountLimit;

            public IntPtr GetMessageCountLimit;

            public IntPtr AddStorageFilterEntries;

            public IntPtr GetStorageFilter;

            public IntPtr ClearStorageFilter;

            public IntPtr PushEmptyStorageFilter;

            public IntPtr PushCopyOfStorageFilter;

            public IntPtr PushStorageFilter;

            public IntPtr PopStorageFilter;

            public IntPtr GetStorageFilterStackSize;

            public IntPtr AddRetrievalFilterEntries;

            public IntPtr GetRetrievalFilter;

            public IntPtr ClearRetrievalFilter;

            public IntPtr PushEmptyRetrievalFilter;

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
