// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D594D0D8-8DA7-457B-B3B4-CE5DBAAC0B88")]
    [NativeTypeName("struct ITransferAdviseSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITransferAdviseSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, Guid*, void**, int>)(lpVtbl[0]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, uint>)(lpVtbl[1]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, uint>)(lpVtbl[2]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateProgress([NativeTypeName("ULONGLONG")] ulong ullSizeCurrent, [NativeTypeName("ULONGLONG")] ulong ullSizeTotal, int nFilesCurrent, int nFilesTotal, int nFoldersCurrent, int nFoldersTotal)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, ulong, ulong, int, int, int, int, int>)(lpVtbl[3]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), ullSizeCurrent, ullSizeTotal, nFilesCurrent, nFilesTotal, nFoldersCurrent, nFoldersTotal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateTransferState([NativeTypeName("TRANSFER_ADVISE_STATE")] uint ts)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, uint, int>)(lpVtbl[4]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), ts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ConfirmOverwrite(IShellItem* psiSource, IShellItem* psiDestParent, [NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, IShellItem*, IShellItem*, ushort*, int>)(lpVtbl[5]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psiSource, psiDestParent, pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int ConfirmEncryptionLoss(IShellItem* psiSource)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, IShellItem*, int>)(lpVtbl[6]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psiSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int FileFailure(IShellItem* psi, [NativeTypeName("LPCWSTR")] ushort* pszItem, [NativeTypeName("HRESULT")] int hrError, [NativeTypeName("LPWSTR")] ushort* pszRename, [NativeTypeName("ULONG")] uint cchRename)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, IShellItem*, ushort*, int, ushort*, uint, int>)(lpVtbl[7]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psi, pszItem, hrError, pszRename, cchRename);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SubStreamFailure(IShellItem* psi, [NativeTypeName("LPCWSTR")] ushort* pszStreamName, [NativeTypeName("HRESULT")] int hrError)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, IShellItem*, ushort*, int, int>)(lpVtbl[8]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psi, pszStreamName, hrError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int PropertyFailure(IShellItem* psi, [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* pkey, [NativeTypeName("HRESULT")] int hrError)
        {
            return ((delegate* unmanaged<ITransferAdviseSink*, IShellItem*, PROPERTYKEY*, int, int>)(lpVtbl[9]))((ITransferAdviseSink*)Unsafe.AsPointer(ref this), psi, pkey, hrError);
        }
    }
}
