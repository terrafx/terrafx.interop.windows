// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
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
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, Guid*, void**, int>)(lpVtbl[0]))((IOleLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, uint>)(lpVtbl[1]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, uint>)(lpVtbl[2]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUpdateOptions([NativeTypeName("DWORD")] uint dwUpdateOpt)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, uint, int>)(lpVtbl[3]))((IOleLink*)Unsafe.AsPointer(ref this), dwUpdateOpt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdateOptions([NativeTypeName("DWORD *")] uint* pdwUpdateOpt)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, uint*, int>)(lpVtbl[4]))((IOleLink*)Unsafe.AsPointer(ref this), pdwUpdateOpt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceMoniker([NativeTypeName("IMoniker *")] IMoniker* pmk, [NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, IMoniker*, Guid*, int>)(lpVtbl[5]))((IOleLink*)Unsafe.AsPointer(ref this), pmk, rclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceMoniker([NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, IMoniker**, int>)(lpVtbl[6]))((IOleLink*)Unsafe.AsPointer(ref this), ppmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSourceDisplayName([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, ushort*, int>)(lpVtbl[7]))((IOleLink*)Unsafe.AsPointer(ref this), pszStatusText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSourceDisplayName([NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, ushort**, int>)(lpVtbl[8]))((IOleLink*)Unsafe.AsPointer(ref this), ppszDisplayName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BindToSource([NativeTypeName("DWORD")] uint bindflags, [NativeTypeName("IBindCtx *")] IBindCtx* pbc)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, uint, IBindCtx*, int>)(lpVtbl[9]))((IOleLink*)Unsafe.AsPointer(ref this), bindflags, pbc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int BindIfRunning()
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, int>)(lpVtbl[10]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBoundSource([NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, IUnknown**, int>)(lpVtbl[11]))((IOleLink*)Unsafe.AsPointer(ref this), ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnbindSource()
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, int>)(lpVtbl[12]))((IOleLink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update([NativeTypeName("IBindCtx *")] IBindCtx* pbc)
        {
            return ((delegate* unmanaged[Stdcall]<IOleLink*, IBindCtx*, int>)(lpVtbl[13]))((IOleLink*)Unsafe.AsPointer(ref this), pbc);
        }
    }
}
