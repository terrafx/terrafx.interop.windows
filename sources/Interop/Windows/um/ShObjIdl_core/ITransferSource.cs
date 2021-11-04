// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00ADB003-BDE9-45C6-8E29-D09F9353E108")]
    [NativeTypeName("struct ITransferSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITransferSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITransferSource*, Guid*, void**, int>)(lpVtbl[0]))((ITransferSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITransferSource*, uint>)(lpVtbl[1]))((ITransferSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITransferSource*, uint>)(lpVtbl[2]))((ITransferSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Advise(ITransferAdviseSink* psink, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITransferSource*, ITransferAdviseSink*, uint*, int>)(lpVtbl[3]))((ITransferSource*)Unsafe.AsPointer(ref this), psink, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITransferSource*, uint, int>)(lpVtbl[4]))((ITransferSource*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetProperties(IPropertyChangeArray* pproparray)
        {
            return ((delegate* unmanaged<ITransferSource*, IPropertyChangeArray*, int>)(lpVtbl[5]))((ITransferSource*)Unsafe.AsPointer(ref this), pproparray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OpenItem(IShellItem* psi, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, uint, Guid*, void**, int>)(lpVtbl[6]))((ITransferSource*)Unsafe.AsPointer(ref this), psi, flags, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT MoveItem(IShellItem* psi, IShellItem* psiParentDst, [NativeTypeName("LPCWSTR")] ushort* pszNameDst, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, IShellItem** ppsiNew)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, ushort*, uint, IShellItem**, int>)(lpVtbl[7]))((ITransferSource*)Unsafe.AsPointer(ref this), psi, psiParentDst, pszNameDst, flags, ppsiNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RecycleItem(IShellItem* psiSource, IShellItem* psiParentDest, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, IShellItem** ppsiNewDest)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, uint, IShellItem**, int>)(lpVtbl[8]))((ITransferSource*)Unsafe.AsPointer(ref this), psiSource, psiParentDest, flags, ppsiNewDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT RemoveItem(IShellItem* psiSource, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, uint, int>)(lpVtbl[9]))((ITransferSource*)Unsafe.AsPointer(ref this), psiSource, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT RenameItem(IShellItem* psiSource, [NativeTypeName("LPCWSTR")] ushort* pszNewName, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, IShellItem** ppsiNewDest)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, ushort*, uint, IShellItem**, int>)(lpVtbl[10]))((ITransferSource*)Unsafe.AsPointer(ref this), psiSource, pszNewName, flags, ppsiNewDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT LinkItem(IShellItem* psiSource, IShellItem* psiParentDest, [NativeTypeName("LPCWSTR")] ushort* pszNewName, [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags, IShellItem** ppsiNewDest)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, ushort*, uint, IShellItem**, int>)(lpVtbl[11]))((ITransferSource*)Unsafe.AsPointer(ref this), psiSource, psiParentDest, pszNewName, flags, ppsiNewDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT ApplyPropertiesToItem(IShellItem* psiSource, IShellItem** ppsiNew)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem**, int>)(lpVtbl[12]))((ITransferSource*)Unsafe.AsPointer(ref this), psiSource, ppsiNew);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetDefaultDestinationName(IShellItem* psiSource, IShellItem* psiParentDest, [NativeTypeName("LPWSTR *")] ushort** ppszDestinationName)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, ushort**, int>)(lpVtbl[13]))((ITransferSource*)Unsafe.AsPointer(ref this), psiSource, psiParentDest, ppszDestinationName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT EnterFolder(IShellItem* psiChildFolderDest)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, int>)(lpVtbl[14]))((ITransferSource*)Unsafe.AsPointer(ref this), psiChildFolderDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT LeaveFolder(IShellItem* psiChildFolderDest)
        {
            return ((delegate* unmanaged<ITransferSource*, IShellItem*, int>)(lpVtbl[15]))((ITransferSource*)Unsafe.AsPointer(ref this), psiChildFolderDest);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, uint> Release;

            [NativeTypeName("HRESULT (ITransferAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, ITransferAdviseSink*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IPropertyChangeArray *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IPropertyChangeArray*, int> SetProperties;

            [NativeTypeName("HRESULT (IShellItem *, TRANSFER_SOURCE_FLAGS, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, uint, Guid*, void**, int> OpenItem;

            [NativeTypeName("HRESULT (IShellItem *, IShellItem *, LPCWSTR, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, ushort*, uint, IShellItem**, int> MoveItem;

            [NativeTypeName("HRESULT (IShellItem *, IShellItem *, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, uint, IShellItem**, int> RecycleItem;

            [NativeTypeName("HRESULT (IShellItem *, TRANSFER_SOURCE_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, uint, int> RemoveItem;

            [NativeTypeName("HRESULT (IShellItem *, LPCWSTR, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, ushort*, uint, IShellItem**, int> RenameItem;

            [NativeTypeName("HRESULT (IShellItem *, IShellItem *, LPCWSTR, TRANSFER_SOURCE_FLAGS, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, ushort*, uint, IShellItem**, int> LinkItem;

            [NativeTypeName("HRESULT (IShellItem *, IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem**, int> ApplyPropertiesToItem;

            [NativeTypeName("HRESULT (IShellItem *, IShellItem *, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, IShellItem*, ushort**, int> GetDefaultDestinationName;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, int> EnterFolder;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITransferSource*, IShellItem*, int> LeaveFolder;
        }
    }
}
