// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_depth_bounds_test")]
    public abstract unsafe partial class ExtDepthBoundsTest : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_depth_bounds_test";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="zmin">
        /// To be added.
        /// </param>
        /// <param name="zmax">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthBoundsEXT")]
        public abstract void DepthBounds([Flow(FlowDirection.In)] double zmin, [Flow(FlowDirection.In)] double zmax);

        public ExtDepthBoundsTest(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

