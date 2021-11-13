// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("CD45F185-1B21-48E2-967B-EAD743A8914E")]
    [NativeTypeName("struct IZoneIdentifier : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IZoneIdentifier : IZoneIdentifier.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IZoneIdentifier*, Guid*, void**, int>)(lpVtbl[0]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IZoneIdentifier*, uint>)(lpVtbl[1]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IZoneIdentifier*, uint>)(lpVtbl[2]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwZone)
        {
            return ((delegate* unmanaged<IZoneIdentifier*, uint*, int>)(lpVtbl[3]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), pdwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetId([NativeTypeName("DWORD")] uint dwZone)
        {
            return ((delegate* unmanaged<IZoneIdentifier*, uint, int>)(lpVtbl[4]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), dwZone);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Remove()
        {
            return ((delegate* unmanaged<IZoneIdentifier*, int>)(lpVtbl[5]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwZone);

            [VtblIndex(4)]
            HRESULT SetId([NativeTypeName("DWORD")] uint dwZone);

            [VtblIndex(5)]
            HRESULT Remove();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IZoneIdentifier*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IZoneIdentifier*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IZoneIdentifier*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IZoneIdentifier*, uint*, int> GetId;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IZoneIdentifier*, uint, int> SetId;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IZoneIdentifier*, int> Remove;
        }
    }
}
