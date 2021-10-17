// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F3EC-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ICSSFilter : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICSSFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICSSFilter*, Guid*, void**, int>)(lpVtbl[0]))((ICSSFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICSSFilter*, uint>)(lpVtbl[1]))((ICSSFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICSSFilter*, uint>)(lpVtbl[2]))((ICSSFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetSite(ICSSFilterSite* pSink)
        {
            return ((delegate* unmanaged<ICSSFilter*, ICSSFilterSite*, int>)(lpVtbl[3]))((ICSSFilter*)Unsafe.AsPointer(ref this), pSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int OnAmbientPropertyChange([NativeTypeName("LONG")] int dispid)
        {
            return ((delegate* unmanaged<ICSSFilter*, int, int>)(lpVtbl[4]))((ICSSFilter*)Unsafe.AsPointer(ref this), dispid);
        }
    }
}
