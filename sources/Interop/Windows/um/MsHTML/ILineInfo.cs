// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F7E2-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ILineInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ILineInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILineInfo*, Guid*, void**, int>)(lpVtbl[0]))((ILineInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILineInfo*, uint>)(lpVtbl[1]))((ILineInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILineInfo*, uint>)(lpVtbl[2]))((ILineInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_x([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[3]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int get_baseLine([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[4]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_textDescent([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[5]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int get_textHeight([NativeTypeName("long *")] int* p)
        {
            return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[6]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_lineDirection([NativeTypeName("LONG *")] int* p)
        {
            return ((delegate* unmanaged<ILineInfo*, int*, int>)(lpVtbl[7]))((ILineInfo*)Unsafe.AsPointer(ref this), p);
        }
    }
}
