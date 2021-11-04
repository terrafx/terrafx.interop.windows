// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("973510DB-7D7F-452B-8975-74A85828D354")]
    [NativeTypeName("struct IFileDialogEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IFileDialogEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, Guid*, void**, int>)(lpVtbl[0]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileDialogEvents*, uint>)(lpVtbl[1]))((IFileDialogEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileDialogEvents*, uint>)(lpVtbl[2]))((IFileDialogEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnFileOk(IFileDialog* pfd)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int>)(lpVtbl[3]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), pfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnFolderChanging(IFileDialog* pfd, IShellItem* psiFolder)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, IFileDialog*, IShellItem*, int>)(lpVtbl[4]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), pfd, psiFolder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnFolderChange(IFileDialog* pfd)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int>)(lpVtbl[5]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), pfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnSelectionChange(IFileDialog* pfd)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int>)(lpVtbl[6]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), pfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnShareViolation(IFileDialog* pfd, IShellItem* psi, FDE_SHAREVIOLATION_RESPONSE* pResponse)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, IFileDialog*, IShellItem*, FDE_SHAREVIOLATION_RESPONSE*, int>)(lpVtbl[7]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), pfd, psi, pResponse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnTypeChange(IFileDialog* pfd)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int>)(lpVtbl[8]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), pfd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnOverwrite(IFileDialog* pfd, IShellItem* psi, FDE_OVERWRITE_RESPONSE* pResponse)
        {
            return ((delegate* unmanaged<IFileDialogEvents*, IFileDialog*, IShellItem*, FDE_OVERWRITE_RESPONSE*, int>)(lpVtbl[9]))((IFileDialogEvents*)Unsafe.AsPointer(ref this), pfd, psi, pResponse);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, uint> Release;

            [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int> OnFileOk;

            [NativeTypeName("HRESULT (IFileDialog *, IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, IFileDialog*, IShellItem*, int> OnFolderChanging;

            [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int> OnFolderChange;

            [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int> OnSelectionChange;

            [NativeTypeName("HRESULT (IFileDialog *, IShellItem *, FDE_SHAREVIOLATION_RESPONSE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, IFileDialog*, IShellItem*, FDE_SHAREVIOLATION_RESPONSE*, int> OnShareViolation;

            [NativeTypeName("HRESULT (IFileDialog *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, IFileDialog*, int> OnTypeChange;

            [NativeTypeName("HRESULT (IFileDialog *, IShellItem *, FDE_OVERWRITE_RESPONSE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileDialogEvents*, IFileDialog*, IShellItem*, FDE_OVERWRITE_RESPONSE*, int> OnOverwrite;
        }
    }
}
