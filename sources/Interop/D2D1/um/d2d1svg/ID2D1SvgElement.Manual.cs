// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;
using static TerraFX.Interop.D2D1_SVG_ATTRIBUTE_POD_TYPE;

namespace TerraFX.Interop
{
    public unsafe partial struct ID2D1SvgElement
    {
        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("FLOAT")] float value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, &value, sizeof(float));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("FLOAT *")] float* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FLOAT, value, sizeof(float));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, unchecked((uint)sizeof(DXGI_RGBA)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_COLOR_F *")] DXGI_RGBA* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_COLOR, value, unchecked((uint)sizeof(DXGI_RGBA)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_FILL_MODE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, &value, sizeof(D2D1_FILL_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_FILL_MODE *")] D2D1_FILL_MODE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_FILL_MODE, value, sizeof(D2D1_FILL_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_DISPLAY value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, &value, sizeof(D2D1_SVG_DISPLAY));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_DISPLAY *")] D2D1_SVG_DISPLAY* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_DISPLAY, value, sizeof(D2D1_SVG_DISPLAY));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_OVERFLOW value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, &value, sizeof(D2D1_SVG_OVERFLOW));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_OVERFLOW *")] D2D1_SVG_OVERFLOW* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_OVERFLOW, value, sizeof(D2D1_SVG_OVERFLOW));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_JOIN value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, &value, sizeof(D2D1_SVG_LINE_JOIN));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LINE_JOIN *")] D2D1_SVG_LINE_JOIN* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_JOIN, value, sizeof(D2D1_SVG_LINE_JOIN));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_LINE_CAP value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, &value, sizeof(D2D1_SVG_LINE_CAP));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LINE_CAP *")] D2D1_SVG_LINE_CAP* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LINE_CAP, value, sizeof(D2D1_SVG_LINE_CAP));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_VISIBILITY value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, &value, sizeof(D2D1_SVG_VISIBILITY));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_VISIBILITY *")] D2D1_SVG_VISIBILITY* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_VISIBILITY, value, sizeof(D2D1_SVG_VISIBILITY));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_MATRIX_3X2_F &")] D2D_MATRIX_3X2_F* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, unchecked((uint)sizeof(D2D_MATRIX_3X2_F)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_MATRIX, value, unchecked((uint)sizeof(D2D_MATRIX_3X2_F)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_SVG_UNIT_TYPE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, &value, sizeof(D2D1_SVG_UNIT_TYPE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_UNIT_TYPE *")] D2D1_SVG_UNIT_TYPE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_UNIT_TYPE, value, sizeof(D2D1_SVG_UNIT_TYPE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, D2D1_EXTEND_MODE value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, &value, sizeof(D2D1_EXTEND_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_EXTEND_MODE *")] D2D1_EXTEND_MODE* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_EXTEND_MODE, value, sizeof(D2D1_EXTEND_MODE));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_SVG_PRESERVE_ASPECT_RATIO &")] D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, unchecked((uint)sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_PRESERVE_ASPECT_RATIO *")] D2D1_SVG_PRESERVE_ASPECT_RATIO* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_PRESERVE_ASPECT_RATIO, value, unchecked((uint)sizeof(D2D1_SVG_PRESERVE_ASPECT_RATIO)));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("const D2D1_SVG_LENGTH &")] D2D1_SVG_LENGTH* value)
        {
            return SetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, unchecked((uint)sizeof(D2D1_SVG_LENGTH)));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAttributeValue([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* value)
        {
            return GetAttributeValue(name, D2D1_SVG_ATTRIBUTE_POD_TYPE_LENGTH, value, unchecked((uint)sizeof(D2D1_SVG_LENGTH)));
        }

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
