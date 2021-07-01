// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000011D-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleLink : IUnknown")]
    public unsafe partial struct IOleLink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleLink*, Guid*, void**, int>)(lpVtbl[0]))((IOleLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleLink*, uint>)(lpVtbl[1]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleLink*, uint>)(lpVtbl[2]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpdateOptions([NativeTypeName("DWORD")] uint dwUpdateOpt)
        {
            return ((delegate* unmanaged<IOleLink*, uint, int>)(lpVtbl[3]))((IOleLink*)Unsafe.AsPointer(ref this), dwUpdateOpt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdateOptions([NativeTypeName("DWORD *")] uint* pdwUpdateOpt)
        {
            return ((delegate* unmanaged<IOleLink*, uint*, int>)(lpVtbl[4]))((IOleLink*)Unsafe.AsPointer(ref this), pdwUpdateOpt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceMoniker(IMoniker* pmk, [NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged<IOleLink*, IMoniker*, Guid*, int>)(lpVtbl[5]))((IOleLink*)Unsafe.AsPointer(ref this), pmk, rclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceMoniker(IMoniker** ppmk)
        {
            return ((delegate* unmanaged<IOleLink*, IMoniker**, int>)(lpVtbl[6]))((IOleLink*)Unsafe.AsPointer(ref this), ppmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceDisplayName([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
        {
            return ((delegate* unmanaged<IOleLink*, ushort*, int>)(lpVtbl[7]))((IOleLink*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceDisplayName([NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return ((delegate* unmanaged<IOleLink*, ushort**, int>)(lpVtbl[8]))((IOleLink*)Unsafe.AsPointer(ref this), ppszDisplayName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BindToSource([NativeTypeName("DWORD")] uint bindflags, IBindCtx* pbc)
        {
            return ((delegate* unmanaged<IOleLink*, uint, IBindCtx*, int>)(lpVtbl[9]))((IOleLink*)Unsafe.AsPointer(ref this), bindflags, pbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BindIfRunning()
        {
            return ((delegate* unmanaged<IOleLink*, int>)(lpVtbl[10]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBoundSource(IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IOleLink*, IUnknown**, int>)(lpVtbl[11]))((IOleLink*)Unsafe.AsPointer(ref this), ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnbindSource()
        {
            return ((delegate* unmanaged<IOleLink*, int>)(lpVtbl[12]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update(IBindCtx* pbc)
        {
            return ((delegate* unmanaged<IOleLink*, IBindCtx*, int>)(lpVtbl[13]))((IOleLink*)Unsafe.AsPointer(ref this), pbc);
        }
    }
}
