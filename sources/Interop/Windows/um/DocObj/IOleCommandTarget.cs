// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B722BCCB-4E68-101B-A2BC-00AA00404770")]
    [NativeTypeName("struct IOleCommandTarget : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOleCommandTarget
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleCommandTarget*, Guid*, void**, int>)(lpVtbl[0]))((IOleCommandTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleCommandTarget*, uint>)(lpVtbl[1]))((IOleCommandTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleCommandTarget*, uint>)(lpVtbl[2]))((IOleCommandTarget*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryStatus([NativeTypeName("const GUID *")] Guid* pguidCmdGroup, [NativeTypeName("ULONG")] uint cCmds, [NativeTypeName("OLECMD []")] OLECMD* prgCmds, OLECMDTEXT* pCmdText)
        {
            return ((delegate* unmanaged<IOleCommandTarget*, Guid*, uint, OLECMD*, OLECMDTEXT*, int>)(lpVtbl[3]))((IOleCommandTarget*)Unsafe.AsPointer(ref this), pguidCmdGroup, cCmds, prgCmds, pCmdText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Exec([NativeTypeName("const GUID *")] Guid* pguidCmdGroup, [NativeTypeName("DWORD")] uint nCmdID, [NativeTypeName("DWORD")] uint nCmdexecopt, VARIANT* pvaIn, VARIANT* pvaOut)
        {
            return ((delegate* unmanaged<IOleCommandTarget*, Guid*, uint, uint, VARIANT*, VARIANT*, int>)(lpVtbl[4]))((IOleCommandTarget*)Unsafe.AsPointer(ref this), pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
        }
    }
}
