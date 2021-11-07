// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868AC-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IResourceManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IResourceManager : IResourceManager.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IResourceManager*, Guid*, void**, int>)(lpVtbl[0]))((IResourceManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IResourceManager*, uint>)(lpVtbl[1]))((IResourceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IResourceManager*, uint>)(lpVtbl[2]))((IResourceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Register([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int cResource, [NativeTypeName("LONG *")] int* plToken)
        {
            return ((delegate* unmanaged<IResourceManager*, ushort*, int, int*, int>)(lpVtbl[3]))((IResourceManager*)Unsafe.AsPointer(ref this), pName, cResource, plToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RegisterGroup([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int cResource, [NativeTypeName("LONG *")] int* palTokens, [NativeTypeName("LONG *")] int* plToken)
        {
            return ((delegate* unmanaged<IResourceManager*, ushort*, int, int*, int*, int>)(lpVtbl[4]))((IResourceManager*)Unsafe.AsPointer(ref this), pName, cResource, palTokens, plToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RequestResource([NativeTypeName("LONG")] int idResource, IUnknown* pFocusObject, IResourceConsumer* pConsumer)
        {
            return ((delegate* unmanaged<IResourceManager*, int, IUnknown*, IResourceConsumer*, int>)(lpVtbl[5]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pFocusObject, pConsumer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT NotifyAcquire([NativeTypeName("LONG")] int idResource, IResourceConsumer* pConsumer, HRESULT hr)
        {
            return ((delegate* unmanaged<IResourceManager*, int, IResourceConsumer*, HRESULT, int>)(lpVtbl[6]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pConsumer, hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT NotifyRelease([NativeTypeName("LONG")] int idResource, IResourceConsumer* pConsumer, BOOL bStillWant)
        {
            return ((delegate* unmanaged<IResourceManager*, int, IResourceConsumer*, BOOL, int>)(lpVtbl[7]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pConsumer, bStillWant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CancelRequest([NativeTypeName("LONG")] int idResource, IResourceConsumer* pConsumer)
        {
            return ((delegate* unmanaged<IResourceManager*, int, IResourceConsumer*, int>)(lpVtbl[8]))((IResourceManager*)Unsafe.AsPointer(ref this), idResource, pConsumer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetFocus(IUnknown* pFocusObject)
        {
            return ((delegate* unmanaged<IResourceManager*, IUnknown*, int>)(lpVtbl[9]))((IResourceManager*)Unsafe.AsPointer(ref this), pFocusObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ReleaseFocus(IUnknown* pFocusObject)
        {
            return ((delegate* unmanaged<IResourceManager*, IUnknown*, int>)(lpVtbl[10]))((IResourceManager*)Unsafe.AsPointer(ref this), pFocusObject);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Register([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int cResource, [NativeTypeName("LONG *")] int* plToken);

            [VtblIndex(4)]
            HRESULT RegisterGroup([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int cResource, [NativeTypeName("LONG *")] int* palTokens, [NativeTypeName("LONG *")] int* plToken);

            [VtblIndex(5)]
            HRESULT RequestResource([NativeTypeName("LONG")] int idResource, IUnknown* pFocusObject, IResourceConsumer* pConsumer);

            [VtblIndex(6)]
            HRESULT NotifyAcquire([NativeTypeName("LONG")] int idResource, IResourceConsumer* pConsumer, HRESULT hr);

            [VtblIndex(7)]
            HRESULT NotifyRelease([NativeTypeName("LONG")] int idResource, IResourceConsumer* pConsumer, BOOL bStillWant);

            [VtblIndex(8)]
            HRESULT CancelRequest([NativeTypeName("LONG")] int idResource, IResourceConsumer* pConsumer);

            [VtblIndex(9)]
            HRESULT SetFocus(IUnknown* pFocusObject);

            [VtblIndex(10)]
            HRESULT ReleaseFocus(IUnknown* pFocusObject);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, LONG, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, ushort*, int, int*, int> Register;

            [NativeTypeName("HRESULT (LPCWSTR, LONG, LONG *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, ushort*, int, int*, int*, int> RegisterGroup;

            [NativeTypeName("HRESULT (LONG, IUnknown *, IResourceConsumer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, int, IUnknown*, IResourceConsumer*, int> RequestResource;

            [NativeTypeName("HRESULT (LONG, IResourceConsumer *, HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, int, IResourceConsumer*, HRESULT, int> NotifyAcquire;

            [NativeTypeName("HRESULT (LONG, IResourceConsumer *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, int, IResourceConsumer*, BOOL, int> NotifyRelease;

            [NativeTypeName("HRESULT (LONG, IResourceConsumer *) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, int, IResourceConsumer*, int> CancelRequest;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, IUnknown*, int> SetFocus;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IResourceManager*, IUnknown*, int> ReleaseFocus;
        }
    }
}
