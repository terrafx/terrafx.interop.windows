// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A88826F8-186F-4987-AADE-EA0CEF8FBFE8")]
    [NativeTypeName("struct IEnumExplorerCommand : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumExplorerCommand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, Guid*, void**, int>)(lpVtbl[0]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, uint>)(lpVtbl[1]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, uint>)(lpVtbl[2]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IExplorerCommand** pUICommand, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, uint, IExplorerCommand**, uint*, int>)(lpVtbl[3]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this), celt, pUICommand, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, uint, int>)(lpVtbl[4]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, int>)(lpVtbl[5]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumExplorerCommand** ppenum)
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, IEnumExplorerCommand**, int>)(lpVtbl[6]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExplorerCommand*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExplorerCommand*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExplorerCommand*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, IExplorerCommand **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExplorerCommand*, uint, IExplorerCommand**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExplorerCommand*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExplorerCommand*, int> Reset;

            [NativeTypeName("HRESULT (IEnumExplorerCommand **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumExplorerCommand*, IEnumExplorerCommand**, int> Clone;
        }
    }
}
