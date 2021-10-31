// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("04B0F1A7-9490-44BC-96E1-4296A31252E2")]
    [NativeTypeName("struct IFileOperationProgressSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFileOperationProgressSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, Guid*, void**, int>)(lpVtbl[0]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint>)(lpVtbl[1]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint>)(lpVtbl[2]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT StartOperations()
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, int>)(lpVtbl[3]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT FinishOperations(HRESULT hrResult)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, HRESULT, int>)(lpVtbl[4]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), hrResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT PreRenameItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem, [NativeTypeName("LPCWSTR")] ushort* pszNewName)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, ushort*, int>)(lpVtbl[5]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem, pszNewName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT PostRenameItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem, [NativeTypeName("LPCWSTR")] ushort* pszNewName, HRESULT hrRename, IShellItem* psiNewlyCreated)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, ushort*, HRESULT, IShellItem*, int>)(lpVtbl[6]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem, pszNewName, hrRename, psiNewlyCreated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT PreMoveItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, IShellItem*, ushort*, int>)(lpVtbl[7]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem, psiDestinationFolder, pszNewName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT PostMoveItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName, HRESULT hrMove, IShellItem* psiNewlyCreated)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, IShellItem*, ushort*, HRESULT, IShellItem*, int>)(lpVtbl[8]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem, psiDestinationFolder, pszNewName, hrMove, psiNewlyCreated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT PreCopyItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, IShellItem*, ushort*, int>)(lpVtbl[9]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem, psiDestinationFolder, pszNewName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT PostCopyItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName, HRESULT hrCopy, IShellItem* psiNewlyCreated)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, IShellItem*, ushort*, HRESULT, IShellItem*, int>)(lpVtbl[10]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem, psiDestinationFolder, pszNewName, hrCopy, psiNewlyCreated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT PreDeleteItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, int>)(lpVtbl[11]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT PostDeleteItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiItem, HRESULT hrDelete, IShellItem* psiNewlyCreated)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, HRESULT, IShellItem*, int>)(lpVtbl[12]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiItem, hrDelete, psiNewlyCreated);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT PreNewItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, ushort*, int>)(lpVtbl[13]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiDestinationFolder, pszNewName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT PostNewItem([NativeTypeName("DWORD")] uint dwFlags, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName, [NativeTypeName("LPCWSTR")] ushort* pszTemplateName, [NativeTypeName("DWORD")] uint dwFileAttributes, HRESULT hrNew, IShellItem* psiNewItem)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, IShellItem*, ushort*, ushort*, uint, HRESULT, IShellItem*, int>)(lpVtbl[14]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), dwFlags, psiDestinationFolder, pszNewName, pszTemplateName, dwFileAttributes, hrNew, psiNewItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT UpdateProgress([NativeTypeName("UINT")] uint iWorkTotal, [NativeTypeName("UINT")] uint iWorkSoFar)
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, uint, uint, int>)(lpVtbl[15]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this), iWorkTotal, iWorkSoFar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT ResetTimer()
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, int>)(lpVtbl[16]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT PauseTimer()
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, int>)(lpVtbl[17]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT ResumeTimer()
        {
            return ((delegate* unmanaged<IFileOperationProgressSink*, int>)(lpVtbl[18]))((IFileOperationProgressSink*)Unsafe.AsPointer(ref this));
        }
    }
}
