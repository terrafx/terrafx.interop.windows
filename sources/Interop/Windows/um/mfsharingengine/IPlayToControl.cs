// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("607574EB-F4B6-45C1-B08C-CB715122901D")]
    [NativeTypeName("struct IPlayToControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPlayToControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPlayToControl*, Guid*, void**, int>)(lpVtbl[0]))((IPlayToControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPlayToControl*, uint>)(lpVtbl[1]))((IPlayToControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPlayToControl*, uint>)(lpVtbl[2]))((IPlayToControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Connect(IMFSharingEngineClassFactory* pFactory)
        {
            return ((delegate* unmanaged<IPlayToControl*, IMFSharingEngineClassFactory*, int>)(lpVtbl[3]))((IPlayToControl*)Unsafe.AsPointer(ref this), pFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Disconnect()
        {
            return ((delegate* unmanaged<IPlayToControl*, int>)(lpVtbl[4]))((IPlayToControl*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IPlayToControl*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPlayToControl*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IPlayToControl*, uint> Release;

            [NativeTypeName("HRESULT (IMFSharingEngineClassFactory *) __attribute__((stdcall))")]
            public delegate* unmanaged<IPlayToControl*, IMFSharingEngineClassFactory*, int> Connect;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IPlayToControl*, int> Disconnect;
        }
    }
}
