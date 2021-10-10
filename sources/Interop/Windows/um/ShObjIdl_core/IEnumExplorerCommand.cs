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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, IExplorerCommand** pUICommand, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, uint, IExplorerCommand**, uint*, int>)(lpVtbl[3]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this), celt, pUICommand, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, uint, int>)(lpVtbl[4]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, int>)(lpVtbl[5]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumExplorerCommand** ppenum)
        {
            return ((delegate* unmanaged<IEnumExplorerCommand*, IEnumExplorerCommand**, int>)(lpVtbl[6]))((IEnumExplorerCommand*)Unsafe.AsPointer(ref this), ppenum);
        }
    }
}
