// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX
{
    public unsafe partial struct ID2D1SvgElement
    {
        public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, ID2D1SvgAttribute** value)
        {
            return GetAttributeValue(name, __uuidof<ID2D1SvgAttribute>(), (void**)value);
        }

        public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, ID2D1SvgPaint** value)
        {
            return GetAttributeValue(name, __uuidof<ID2D1SvgPaint>(), (void**)value);
        }

        public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, ID2D1SvgStrokeDashArray** value)
        {
            return GetAttributeValue(name, __uuidof<ID2D1SvgStrokeDashArray>(), (void**)value);
        }

        public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, ID2D1SvgPointCollection** value)
        {
            return GetAttributeValue(name, __uuidof<ID2D1SvgPointCollection>(), (void**)value);
        }

        public HRESULT GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, ID2D1SvgPathData** value)
        {
            return GetAttributeValue(name, __uuidof<ID2D1SvgPathData>(), (void**)value);
        }
    }
}
