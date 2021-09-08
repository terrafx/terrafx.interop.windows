// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("947AAB5F-0A5C-4C13-B4D6-4BF7836FC9F8")]
    [NativeTypeName("struct IFileOperation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFileOperation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileOperation*, Guid*, void**, int>)(lpVtbl[0]))((IFileOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileOperation*, uint>)(lpVtbl[1]))((IFileOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileOperation*, uint>)(lpVtbl[2]))((IFileOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Advise(IFileOperationProgressSink* pfops, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IFileOperation*, IFileOperationProgressSink*, uint*, int>)(lpVtbl[3]))((IFileOperation*)Unsafe.AsPointer(ref this), pfops, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IFileOperation*, uint, int>)(lpVtbl[4]))((IFileOperation*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetOperationFlags([NativeTypeName("DWORD")] uint dwOperationFlags)
        {
            return ((delegate* unmanaged<IFileOperation*, uint, int>)(lpVtbl[5]))((IFileOperation*)Unsafe.AsPointer(ref this), dwOperationFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetProgressMessage([NativeTypeName("LPCWSTR")] ushort* pszMessage)
        {
            return ((delegate* unmanaged<IFileOperation*, ushort*, int>)(lpVtbl[6]))((IFileOperation*)Unsafe.AsPointer(ref this), pszMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetProgressDialog(IOperationsProgressDialog* popd)
        {
            return ((delegate* unmanaged<IFileOperation*, IOperationsProgressDialog*, int>)(lpVtbl[7]))((IFileOperation*)Unsafe.AsPointer(ref this), popd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperties(IPropertyChangeArray* pproparray)
        {
            return ((delegate* unmanaged<IFileOperation*, IPropertyChangeArray*, int>)(lpVtbl[8]))((IFileOperation*)Unsafe.AsPointer(ref this), pproparray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetOwnerWindow([NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<IFileOperation*, IntPtr, int>)(lpVtbl[9]))((IFileOperation*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyPropertiesToItem(IShellItem* psiItem)
        {
            return ((delegate* unmanaged<IFileOperation*, IShellItem*, int>)(lpVtbl[10]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyPropertiesToItems(IUnknown* punkItems)
        {
            return ((delegate* unmanaged<IFileOperation*, IUnknown*, int>)(lpVtbl[11]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int RenameItem(IShellItem* psiItem, [NativeTypeName("LPCWSTR")] ushort* pszNewName, IFileOperationProgressSink* pfopsItem)
        {
            return ((delegate* unmanaged<IFileOperation*, IShellItem*, ushort*, IFileOperationProgressSink*, int>)(lpVtbl[12]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, pszNewName, pfopsItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int RenameItems(IUnknown* pUnkItems, [NativeTypeName("LPCWSTR")] ushort* pszNewName)
        {
            return ((delegate* unmanaged<IFileOperation*, IUnknown*, ushort*, int>)(lpVtbl[13]))((IFileOperation*)Unsafe.AsPointer(ref this), pUnkItems, pszNewName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int MoveItem(IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszNewName, IFileOperationProgressSink* pfopsItem)
        {
            return ((delegate* unmanaged<IFileOperation*, IShellItem*, IShellItem*, ushort*, IFileOperationProgressSink*, int>)(lpVtbl[14]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, psiDestinationFolder, pszNewName, pfopsItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int MoveItems(IUnknown* punkItems, IShellItem* psiDestinationFolder)
        {
            return ((delegate* unmanaged<IFileOperation*, IUnknown*, IShellItem*, int>)(lpVtbl[15]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems, psiDestinationFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int CopyItem(IShellItem* psiItem, IShellItem* psiDestinationFolder, [NativeTypeName("LPCWSTR")] ushort* pszCopyName, IFileOperationProgressSink* pfopsItem)
        {
            return ((delegate* unmanaged<IFileOperation*, IShellItem*, IShellItem*, ushort*, IFileOperationProgressSink*, int>)(lpVtbl[16]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, psiDestinationFolder, pszCopyName, pfopsItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int CopyItems(IUnknown* punkItems, IShellItem* psiDestinationFolder)
        {
            return ((delegate* unmanaged<IFileOperation*, IUnknown*, IShellItem*, int>)(lpVtbl[17]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems, psiDestinationFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteItem(IShellItem* psiItem, IFileOperationProgressSink* pfopsItem)
        {
            return ((delegate* unmanaged<IFileOperation*, IShellItem*, IFileOperationProgressSink*, int>)(lpVtbl[18]))((IFileOperation*)Unsafe.AsPointer(ref this), psiItem, pfopsItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteItems(IUnknown* punkItems)
        {
            return ((delegate* unmanaged<IFileOperation*, IUnknown*, int>)(lpVtbl[19]))((IFileOperation*)Unsafe.AsPointer(ref this), punkItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int NewItem(IShellItem* psiDestinationFolder, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszTemplateName, IFileOperationProgressSink* pfopsItem)
        {
            return ((delegate* unmanaged<IFileOperation*, IShellItem*, uint, ushort*, ushort*, IFileOperationProgressSink*, int>)(lpVtbl[20]))((IFileOperation*)Unsafe.AsPointer(ref this), psiDestinationFolder, dwFileAttributes, pszName, pszTemplateName, pfopsItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int PerformOperations()
        {
            return ((delegate* unmanaged<IFileOperation*, int>)(lpVtbl[21]))((IFileOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int GetAnyOperationsAborted([NativeTypeName("BOOL *")] int* pfAnyOperationsAborted)
        {
            return ((delegate* unmanaged<IFileOperation*, int*, int>)(lpVtbl[22]))((IFileOperation*)Unsafe.AsPointer(ref this), pfAnyOperationsAborted);
        }
    }
}
