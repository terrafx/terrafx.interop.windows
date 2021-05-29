// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public unsafe partial struct ID2D1SvgElement
    {
        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgAttribute **")] ID2D1SvgAttribute** value)
        {
            var iid = IID_ID2D1SvgAttribute;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgPaint **")] ID2D1SvgPaint** value)
        {
            var iid = IID_ID2D1SvgPaint;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgStrokeDashArray **")] ID2D1SvgStrokeDashArray** value)
        {
            var iid = IID_ID2D1SvgStrokeDashArray;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgPointCollection **")] ID2D1SvgPointCollection** value)
        {
            var iid = IID_ID2D1SvgPointCollection;
            return GetAttributeValue(name, &iid, (void**)value);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("ID2D1SvgPathData **")] ID2D1SvgPathData** value)
        {
            var iid = IID_ID2D1SvgPathData;
            return GetAttributeValue(name, &iid, (void**)value);
        }
    }
}
