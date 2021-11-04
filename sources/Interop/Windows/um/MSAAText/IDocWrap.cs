// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DCD285FE-0BE0-43BD-99C9-AAAEC513C555")]
    [NativeTypeName("struct IDocWrap : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDocWrap : IDocWrap.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDocWrap*, Guid*, void**, int>)(lpVtbl[0]))((IDocWrap*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDocWrap*, uint>)(lpVtbl[1]))((IDocWrap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDocWrap*, uint>)(lpVtbl[2]))((IDocWrap*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
        {
            return ((delegate* unmanaged<IDocWrap*, Guid*, IUnknown*, int>)(lpVtbl[3]))((IDocWrap*)Unsafe.AsPointer(ref this), riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetWrappedDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IDocWrap*, Guid*, IUnknown**, int>)(lpVtbl[4]))((IDocWrap*)Unsafe.AsPointer(ref this), riid, ppunk);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown* punk);

            [VtblIndex(4)]
            HRESULT GetWrappedDoc([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDocWrap*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDocWrap*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDocWrap*, uint> Release;

            [NativeTypeName("HRESULT (const IID &, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDocWrap*, Guid*, IUnknown*, int> SetDoc;

            [NativeTypeName("HRESULT (const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDocWrap*, Guid*, IUnknown**, int> GetWrappedDoc;
        }
    }
}
