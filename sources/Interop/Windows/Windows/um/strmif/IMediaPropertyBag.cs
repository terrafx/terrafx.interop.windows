// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("6025A880-C0D5-11D0-BD4E-00A0C911CE86")]
    [NativeTypeName("struct IMediaPropertyBag : IPropertyBag")]
    [NativeInheritance("IPropertyBag")]
    public unsafe partial struct IMediaPropertyBag : IMediaPropertyBag.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaPropertyBag*, uint>)(lpVtbl[1]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaPropertyBag*, uint>)(lpVtbl[2]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar, IErrorLog* pErrorLog)
        {
            return ((delegate* unmanaged<IMediaPropertyBag*, ushort*, VARIANT*, IErrorLog*, int>)(lpVtbl[3]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar)
        {
            return ((delegate* unmanaged<IMediaPropertyBag*, ushort*, VARIANT*, int>)(lpVtbl[4]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EnumProperty([NativeTypeName("ULONG")] uint iProperty, VARIANT* pvarPropertyName, VARIANT* pvarPropertyValue)
        {
            return ((delegate* unmanaged<IMediaPropertyBag*, uint, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), iProperty, pvarPropertyName, pvarPropertyValue);
        }

        public interface Interface : IPropertyBag.Interface
        {
            [VtblIndex(5)]
            HRESULT EnumProperty([NativeTypeName("ULONG")] uint iProperty, VARIANT* pvarPropertyName, VARIANT* pvarPropertyValue);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaPropertyBag*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaPropertyBag*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaPropertyBag*, uint> Release;

            [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *, IErrorLog *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaPropertyBag*, ushort*, VARIANT*, IErrorLog*, int> Read;

            [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaPropertyBag*, ushort*, VARIANT*, int> Write;

            [NativeTypeName("HRESULT (ULONG, VARIANT *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMediaPropertyBag*, uint, VARIANT*, VARIANT*, int> EnumProperty;
        }
    }
}
