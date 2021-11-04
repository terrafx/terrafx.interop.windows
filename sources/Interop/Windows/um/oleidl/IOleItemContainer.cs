// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011C-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleItemContainer : IOleContainer")]
    [NativeInheritance("IOleContainer")]
    public unsafe partial struct IOleItemContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleItemContainer*, Guid*, void**, int>)(lpVtbl[0]))((IOleItemContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleItemContainer*, uint>)(lpVtbl[1]))((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleItemContainer*, uint>)(lpVtbl[2]))((IOleItemContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ParseDisplayName(IBindCtx* pbc, [NativeTypeName("LPOLESTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, IMoniker** ppmkOut)
        {
            return ((delegate* unmanaged<IOleItemContainer*, IBindCtx*, ushort*, uint*, IMoniker**, int>)(lpVtbl[3]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pbc, pszDisplayName, pchEaten, ppmkOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown** ppenum)
        {
            return ((delegate* unmanaged<IOleItemContainer*, uint, IEnumUnknown**, int>)(lpVtbl[4]))((IOleItemContainer*)Unsafe.AsPointer(ref this), grfFlags, ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT LockContainer(BOOL fLock)
        {
            return ((delegate* unmanaged<IOleItemContainer*, BOOL, int>)(lpVtbl[5]))((IOleItemContainer*)Unsafe.AsPointer(ref this), fLock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetObject([NativeTypeName("LPOLESTR")] ushort* pszItem, [NativeTypeName("DWORD")] uint dwSpeedNeeded, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleItemContainer*, ushort*, uint, IBindCtx*, Guid*, void**, int>)(lpVtbl[6]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, dwSpeedNeeded, pbc, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetObjectStorage([NativeTypeName("LPOLESTR")] ushort* pszItem, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppvStorage)
        {
            return ((delegate* unmanaged<IOleItemContainer*, ushort*, IBindCtx*, Guid*, void**, int>)(lpVtbl[7]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem, pbc, riid, ppvStorage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT IsRunning([NativeTypeName("LPOLESTR")] ushort* pszItem)
        {
            return ((delegate* unmanaged<IOleItemContainer*, ushort*, int>)(lpVtbl[8]))((IOleItemContainer*)Unsafe.AsPointer(ref this), pszItem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, uint> Release;

            [NativeTypeName("HRESULT (IBindCtx *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, IBindCtx*, ushort*, uint*, IMoniker**, int> ParseDisplayName;

            [NativeTypeName("HRESULT (DWORD, IEnumUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, uint, IEnumUnknown**, int> EnumObjects;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, BOOL, int> LockContainer;

            [NativeTypeName("HRESULT (LPOLESTR, DWORD, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, ushort*, uint, IBindCtx*, Guid*, void**, int> GetObject;

            [NativeTypeName("HRESULT (LPOLESTR, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, ushort*, IBindCtx*, Guid*, void**, int> GetObjectStorage;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleItemContainer*, ushort*, int> IsRunning;
        }
    }
}
