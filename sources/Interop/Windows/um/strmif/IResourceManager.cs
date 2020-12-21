// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868AC-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IResourceManager : IUnknown")]
    public unsafe partial struct IResourceManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, Guid*, void**, int>)(lpVtbl[0]))((IResourceManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, uint>)(lpVtbl[1]))((IResourceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, uint>)(lpVtbl[2]))((IResourceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int cResource, [NativeTypeName("LONG *")] int* plToken)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, ushort*, int, int*, int>)(lpVtbl[3]))((IResourceManager*)Unsafe.AsPointer(ref this), pName, cResource, plToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterGroup([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int cResource, [NativeTypeName("LONG *")] int* palTokens, [NativeTypeName("LONG *")] int* plToken)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, ushort*, int, int*, int*, int>)(lpVtbl[4]))((IResourceManager*)Unsafe.AsPointer(ref this), pName, cResource, palTokens, plToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestResource([NativeTypeName("LONG")] int idResource, [NativeTypeName("IUnknown *")] IUnknown* pFocusObject, [NativeTypeName("IResourceConsumer *")] IResourceConsumer* pConsumer)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, int, IUnknown*, IResourceConsumer*, int>)(lpVtbl[5]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pFocusObject, pConsumer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyAcquire([NativeTypeName("LONG")] int idResource, [NativeTypeName("IResourceConsumer *")] IResourceConsumer* pConsumer, [NativeTypeName("HRESULT")] int hr)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, int, IResourceConsumer*, int, int>)(lpVtbl[6]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pConsumer, hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NotifyRelease([NativeTypeName("LONG")] int idResource, [NativeTypeName("IResourceConsumer *")] IResourceConsumer* pConsumer, [NativeTypeName("BOOL")] int bStillWant)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, int, IResourceConsumer*, int, int>)(lpVtbl[7]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pConsumer, bStillWant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CancelRequest([NativeTypeName("LONG")] int idResource, [NativeTypeName("IResourceConsumer *")] IResourceConsumer* pConsumer)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, int, IResourceConsumer*, int>)(lpVtbl[8]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pConsumer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFocus([NativeTypeName("IUnknown *")] IUnknown* pFocusObject)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, IUnknown*, int>)(lpVtbl[9]))((IResourceManager*)Unsafe.AsPointer(ref this), pFocusObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseFocus([NativeTypeName("IUnknown *")] IUnknown* pFocusObject)
        {
            return ((delegate* unmanaged[Stdcall]<IResourceManager*, IUnknown*, int>)(lpVtbl[10]))((IResourceManager*)Unsafe.AsPointer(ref this), pFocusObject);
        }
    }
}
