// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("64961751-0835-43C0-8FFE-D57686530E64")]
    [NativeTypeName("struct IExplorerCommandProvider : IUnknown")]
    public unsafe partial struct IExplorerCommandProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExplorerCommandProvider*, Guid*, void**, int>)(lpVtbl[0]))((IExplorerCommandProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExplorerCommandProvider*, uint>)(lpVtbl[1]))((IExplorerCommandProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExplorerCommandProvider*, uint>)(lpVtbl[2]))((IExplorerCommandProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCommands(IUnknown* punkSite, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IExplorerCommandProvider*, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IExplorerCommandProvider*)Unsafe.AsPointer(ref this), punkSite, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCommand([NativeTypeName("const GUID &")] Guid* rguidCommandId, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IExplorerCommandProvider*, Guid*, Guid*, void**, int>)(lpVtbl[4]))((IExplorerCommandProvider*)Unsafe.AsPointer(ref this), rguidCommandId, riid, ppv);
        }
    }
}
