// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6025A880-C0D5-11D0-BD4E-00A0C911CE86")]
    [NativeTypeName("struct IMediaPropertyBag : IPropertyBag")]
    public unsafe partial struct IMediaPropertyBag
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMediaPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMediaPropertyBag*, uint>)(lpVtbl[1]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMediaPropertyBag*, uint>)(lpVtbl[2]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar, [NativeTypeName("IErrorLog *")] IErrorLog* pErrorLog)
        {
            return ((delegate* stdcall<IMediaPropertyBag*, ushort*, VARIANT*, IErrorLog*, int>)(lpVtbl[3]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar, pErrorLog);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("VARIANT *")] VARIANT* pVar)
        {
            return ((delegate* stdcall<IMediaPropertyBag*, ushort*, VARIANT*, int>)(lpVtbl[4]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), pszPropName, pVar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumProperty([NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("VARIANT *")] VARIANT* pvarPropertyName, [NativeTypeName("VARIANT *")] VARIANT* pvarPropertyValue)
        {
            return ((delegate* stdcall<IMediaPropertyBag*, uint, VARIANT*, VARIANT*, int>)(lpVtbl[5]))((IMediaPropertyBag*)Unsafe.AsPointer(ref this), iProperty, pvarPropertyName, pvarPropertyValue);
        }
    }
}
